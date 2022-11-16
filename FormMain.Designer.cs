namespace PotnijPDF
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxZrodlowy = new System.Windows.Forms.GroupBox();
            this.buttonZrodlo = new System.Windows.Forms.Button();
            this.textBoxZrodlowy = new System.Windows.Forms.TextBox();
            this.groupBoxWynikowy = new System.Windows.Forms.GroupBox();
            this.buttonWynikowy = new System.Windows.Forms.Button();
            this.textBoxWynikowy = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBoxParametry = new System.Windows.Forms.GroupBox();
            this.textBoxMargines = new System.Windows.Forms.TextBox();
            this.labelMargines = new System.Windows.Forms.Label();
            this.textBoxWysokoscPaska = new System.Windows.Forms.TextBox();
            this.labelWysokosc = new System.Windows.Forms.Label();
            this.textBoxDpi = new System.Windows.Forms.TextBox();
            this.labelDpi = new System.Windows.Forms.Label();
            this.groupBoxZrodlowy.SuspendLayout();
            this.groupBoxWynikowy.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.groupBoxParametry.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxZrodlowy
            // 
            this.groupBoxZrodlowy.Controls.Add(this.buttonZrodlo);
            this.groupBoxZrodlowy.Controls.Add(this.textBoxZrodlowy);
            this.groupBoxZrodlowy.Location = new System.Drawing.Point(12, 12);
            this.groupBoxZrodlowy.Name = "groupBoxZrodlowy";
            this.groupBoxZrodlowy.Size = new System.Drawing.Size(523, 78);
            this.groupBoxZrodlowy.TabIndex = 0;
            this.groupBoxZrodlowy.TabStop = false;
            this.groupBoxZrodlowy.Text = "Folder źródłowy";
            // 
            // buttonZrodlo
            // 
            this.buttonZrodlo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZrodlo.Location = new System.Drawing.Point(442, 46);
            this.buttonZrodlo.Name = "buttonZrodlo";
            this.buttonZrodlo.Size = new System.Drawing.Size(75, 23);
            this.buttonZrodlo.TabIndex = 1;
            this.buttonZrodlo.Text = "Wybierz";
            this.buttonZrodlo.UseVisualStyleBackColor = true;
            this.buttonZrodlo.Click += new System.EventHandler(this.ButtonZrodlo_Click);
            // 
            // textBoxZrodlowy
            // 
            this.textBoxZrodlowy.Location = new System.Drawing.Point(7, 20);
            this.textBoxZrodlowy.Multiline = true;
            this.textBoxZrodlowy.Name = "textBoxZrodlowy";
            this.textBoxZrodlowy.ReadOnly = true;
            this.textBoxZrodlowy.Size = new System.Drawing.Size(510, 20);
            this.textBoxZrodlowy.TabIndex = 0;
            // 
            // groupBoxWynikowy
            // 
            this.groupBoxWynikowy.Controls.Add(this.buttonWynikowy);
            this.groupBoxWynikowy.Controls.Add(this.textBoxWynikowy);
            this.groupBoxWynikowy.Location = new System.Drawing.Point(12, 96);
            this.groupBoxWynikowy.Name = "groupBoxWynikowy";
            this.groupBoxWynikowy.Size = new System.Drawing.Size(523, 78);
            this.groupBoxWynikowy.TabIndex = 2;
            this.groupBoxWynikowy.TabStop = false;
            this.groupBoxWynikowy.Text = "Folder wynikowy";
            // 
            // buttonWynikowy
            // 
            this.buttonWynikowy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWynikowy.Location = new System.Drawing.Point(442, 46);
            this.buttonWynikowy.Name = "buttonWynikowy";
            this.buttonWynikowy.Size = new System.Drawing.Size(75, 23);
            this.buttonWynikowy.TabIndex = 1;
            this.buttonWynikowy.Text = "Wybierz";
            this.buttonWynikowy.UseVisualStyleBackColor = true;
            this.buttonWynikowy.Click += new System.EventHandler(this.ButtonWynikowy_Click);
            // 
            // textBoxWynikowy
            // 
            this.textBoxWynikowy.Location = new System.Drawing.Point(7, 20);
            this.textBoxWynikowy.Multiline = true;
            this.textBoxWynikowy.Name = "textBoxWynikowy";
            this.textBoxWynikowy.ReadOnly = true;
            this.textBoxWynikowy.Size = new System.Drawing.Size(510, 20);
            this.textBoxWynikowy.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.ForeColor = System.Drawing.Color.Red;
            this.buttonStart.Location = new System.Drawing.Point(460, 255);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStripMain.Location = new System.Drawing.Point(0, 291);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(544, 22);
            this.statusStripMain.SizingGrip = false;
            this.statusStripMain.TabIndex = 3;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(48, 17);
            this.statusLabel.Text = "Gotowy";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // groupBoxParametry
            // 
            this.groupBoxParametry.Controls.Add(this.textBoxMargines);
            this.groupBoxParametry.Controls.Add(this.labelMargines);
            this.groupBoxParametry.Controls.Add(this.textBoxWysokoscPaska);
            this.groupBoxParametry.Controls.Add(this.labelWysokosc);
            this.groupBoxParametry.Controls.Add(this.textBoxDpi);
            this.groupBoxParametry.Controls.Add(this.labelDpi);
            this.groupBoxParametry.Location = new System.Drawing.Point(12, 181);
            this.groupBoxParametry.Name = "groupBoxParametry";
            this.groupBoxParametry.Size = new System.Drawing.Size(523, 68);
            this.groupBoxParametry.TabIndex = 4;
            this.groupBoxParametry.TabStop = false;
            this.groupBoxParametry.Text = "Parametry";
            // 
            // textBoxMargines
            // 
            this.textBoxMargines.Location = new System.Drawing.Point(442, 26);
            this.textBoxMargines.Name = "textBoxMargines";
            this.textBoxMargines.Size = new System.Drawing.Size(55, 20);
            this.textBoxMargines.TabIndex = 5;
            this.textBoxMargines.Text = "2.5";
            this.textBoxMargines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMargines
            // 
            this.labelMargines.AutoSize = true;
            this.labelMargines.Location = new System.Drawing.Point(334, 30);
            this.labelMargines.Name = "labelMargines";
            this.labelMargines.Size = new System.Drawing.Size(102, 13);
            this.labelMargines.TabIndex = 4;
            this.labelMargines.Text = "Margines Word [cm]";
            // 
            // textBoxWysokoscPaska
            // 
            this.textBoxWysokoscPaska.Location = new System.Drawing.Point(243, 27);
            this.textBoxWysokoscPaska.Name = "textBoxWysokoscPaska";
            this.textBoxWysokoscPaska.Size = new System.Drawing.Size(55, 20);
            this.textBoxWysokoscPaska.TabIndex = 3;
            this.textBoxWysokoscPaska.Text = "5";
            this.textBoxWysokoscPaska.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelWysokosc
            // 
            this.labelWysokosc.AutoSize = true;
            this.labelWysokosc.Location = new System.Drawing.Point(125, 30);
            this.labelWysokosc.Name = "labelWysokosc";
            this.labelWysokosc.Size = new System.Drawing.Size(112, 13);
            this.labelWysokosc.TabIndex = 2;
            this.labelWysokosc.Text = "Wysokość paska [cm]";
            // 
            // textBoxDpi
            // 
            this.textBoxDpi.Location = new System.Drawing.Point(47, 27);
            this.textBoxDpi.Name = "textBoxDpi";
            this.textBoxDpi.Size = new System.Drawing.Size(55, 20);
            this.textBoxDpi.TabIndex = 1;
            this.textBoxDpi.Text = "300";
            this.textBoxDpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDpi
            // 
            this.labelDpi.AutoSize = true;
            this.labelDpi.Location = new System.Drawing.Point(6, 30);
            this.labelDpi.Name = "labelDpi";
            this.labelDpi.Size = new System.Drawing.Size(25, 13);
            this.labelDpi.TabIndex = 0;
            this.labelDpi.Text = "DPI";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 313);
            this.Controls.Add(this.groupBoxParametry);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBoxWynikowy);
            this.Controls.Add(this.groupBoxZrodlowy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Potnij PDF";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxZrodlowy.ResumeLayout(false);
            this.groupBoxZrodlowy.PerformLayout();
            this.groupBoxWynikowy.ResumeLayout(false);
            this.groupBoxWynikowy.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.groupBoxParametry.ResumeLayout(false);
            this.groupBoxParametry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxZrodlowy;
        private System.Windows.Forms.TextBox textBoxZrodlowy;
        private System.Windows.Forms.Button buttonZrodlo;
        private System.Windows.Forms.GroupBox groupBoxWynikowy;
        private System.Windows.Forms.Button buttonWynikowy;
        private System.Windows.Forms.TextBox textBoxWynikowy;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.GroupBox groupBoxParametry;
        private System.Windows.Forms.TextBox textBoxDpi;
        private System.Windows.Forms.Label labelDpi;
        private System.Windows.Forms.TextBox textBoxWysokoscPaska;
        private System.Windows.Forms.Label labelWysokosc;
        private System.Windows.Forms.TextBox textBoxMargines;
        private System.Windows.Forms.Label labelMargines;
    }
}

