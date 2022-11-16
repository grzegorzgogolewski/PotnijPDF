using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.DocIO.DLS;
using Syncfusion.Pdf.Parsing;
using HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment;

namespace PotnijPDF
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonZrodlo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                ShowNewFolderButton = false,
                SelectedPath = Properties.Settings.Default.FolderZrodlowy,
                Description = "Wybierz folder z plikami PDF (pobiera również z podfolderów)"
            };

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxZrodlowy.Text = fbd.SelectedPath;

                Properties.Settings.Default.FolderZrodlowy = fbd.SelectedPath;

                Properties.Settings.Default.Save();

                if (textBoxZrodlowy.Text != "" && textBoxWynikowy.Text != "")
                {
                    buttonStart.Enabled = true;
                }
            }
        }

        private void ButtonWynikowy_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                SelectedPath = Properties.Settings.Default.FolderWynikowy,
                Description = "Wybierz lub utwórz folder z pikami wynikowymi"
            };

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxWynikowy.Text = fbd.SelectedPath;

                Properties.Settings.Default.FolderWynikowy = fbd.SelectedPath;

                Properties.Settings.Default.Save();

                if (textBoxZrodlowy.Text != "" && textBoxWynikowy.Text != "")
                {
                    buttonStart.Enabled = true;
                }
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonZrodlo.Enabled = false;
            buttonWynikowy.Enabled = false;

            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string[] listaPlikowPdf = Directory.EnumerateFiles(textBoxZrodlowy.Text, "*.pdf", SearchOption.AllDirectories).ToArray();

            foreach (string nazwaPlikuPdf in listaPlikowPdf)
            {
                statusLabel.Text = $"Przetwarzanie pliku: {nazwaPlikuPdf}";
                PdfLoadedDocument pdfDoc = new PdfLoadedDocument(nazwaPlikuPdf);

                string nazwaPlikuWynikowa = nazwaPlikuPdf.Replace(textBoxZrodlowy.Text, textBoxWynikowy.Text);

                WordDocument document = new WordDocument();
                
                bool konwersja = int.TryParse(textBoxDpi.Text, out int dpi);

                if (!konwersja)
                {
                    MessageBox.Show("Wartość dpi musi być liczbą całkowitą!", "Bład wartości", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                konwersja = int.TryParse(textBoxWysokoscPaska.Text, out int wysokoscCm);

                if (!konwersja)
                {
                    MessageBox.Show("Wartość cm musi być liczbą całkowitą!", "Bład wartości", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                konwersja = float.TryParse(textBoxMargines.Text.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out float margines);

                if (konwersja)
                {
                    margines *= 28.35F;
                }
                else
                {
                    MessageBox.Show("Wartość marginesu musi być liczbą!", "Bład wartości", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                for (int i = 0; i < pdfDoc.Pages.Count; i++)
                {
                    IWSection section = document.AddSection();

                    section.PageSetup.Margins = new MarginsF { Bottom = margines, Top = margines, Left = margines, Right = margines };

                    ImageExportSettings settings = new ImageExportSettings { DpiX = dpi, DpiY = dpi, KeepAspectRatio = true };

                    Bitmap obraz = pdfDoc.ExportAsImage(i, settings);

                    int szerokoscObrazu = obraz.Width;
                    int wysokoscObrazu = obraz.Height;

                    int wysokosc5CmObrazu = Convert.ToInt32(dpi / 2.54) * wysokoscCm;

                    int iloscPaskow = Convert.ToInt32(Math.Ceiling((double)wysokoscObrazu / wysokosc5CmObrazu));

                    for (int j = 0; j < iloscPaskow; j++)
                    {
                        Rectangle clip = j * wysokosc5CmObrazu + Convert.ToInt32(wysokosc5CmObrazu) <= wysokoscObrazu
                            ? new Rectangle(0, j * wysokosc5CmObrazu, szerokoscObrazu, Convert.ToInt32(wysokosc5CmObrazu))
                            : new Rectangle(0, j * wysokosc5CmObrazu, szerokoscObrazu, wysokoscObrazu - j * wysokosc5CmObrazu);

                        Bitmap bmpCrop = obraz.Clone(clip, obraz.PixelFormat);

                        Directory.CreateDirectory(Path.GetDirectoryName(nazwaPlikuWynikowa) ?? throw new InvalidOperationException());

                        bmpCrop.Save(Path.Combine(Path.GetDirectoryName(nazwaPlikuWynikowa) ?? throw new InvalidOperationException(), Path.GetFileNameWithoutExtension(nazwaPlikuWynikowa) + $"_{i+1}_{j+1}.jpg") , ImageFormat.Jpeg);

                        IWParagraph paragraph = section.AddParagraph();

                        paragraph.ParagraphFormat.HorizontalAlignment = HorizontalAlignment.Center;
                        
                        IWPicture picture = paragraph.AppendPicture(bmpCrop);
                        
                        float clientWidth = section.PageSetup.ClientWidth;

                        float ratio =  clientWidth / picture.Width;

                        picture.Width = clientWidth;
                        picture.Height *= ratio;

                        bmpCrop.Dispose();
                    }
                }

                pdfDoc.Close(true);

                
                document.Save(Path.Combine(Path.GetDirectoryName(nazwaPlikuWynikowa) ?? throw new InvalidOperationException(), Path.GetFileNameWithoutExtension(nazwaPlikuWynikowa) + ".docx"));
                document.Close();

            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            buttonStart.Enabled = true;
            buttonZrodlo.Enabled = true;
            buttonWynikowy.Enabled = true;

            statusLabel.Text = "Przetwarzanie zakończone";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
        }
    }
}
