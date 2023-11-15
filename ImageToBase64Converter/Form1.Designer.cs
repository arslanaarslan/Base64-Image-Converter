namespace ImageToBase64Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            btnBrowse = new Button();
            textBox1 = new TextBox();
            pbInputPhoto = new PictureBox();
            btnCopyToClipboard = new Button();
            rtbBase64Output = new RichTextBox();
            tabPage2 = new TabPage();
            splitContainer2 = new SplitContainer();
            btnClear = new Button();
            btnConvert = new Button();
            rtbBase64Input = new RichTextBox();
            pbOutputImage = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbInputPhoto).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbOutputImage).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AccessibleDescription = "Image To Base64";
            tabControl1.AccessibleName = "Image To Base64";
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 438);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 408);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Image To Base64";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnBrowse);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(pbInputPhoto);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnCopyToClipboard);
            splitContainer1.Panel2.Controls.Add(rtbBase64Output);
            splitContainer1.Size = new Size(762, 402);
            splitContainer1.SplitterDistance = 367;
            splitContainer1.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(281, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(83, 30);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 25);
            textBox1.TabIndex = 1;
            // 
            // pbInputPhoto
            // 
            pbInputPhoto.Location = new Point(3, 38);
            pbInputPhoto.Name = "pbInputPhoto";
            pbInputPhoto.Size = new Size(361, 361);
            pbInputPhoto.TabIndex = 0;
            pbInputPhoto.TabStop = false;
            // 
            // btnCopyToClipboard
            // 
            btnCopyToClipboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCopyToClipboard.Location = new Point(3, 2);
            btnCopyToClipboard.Name = "btnCopyToClipboard";
            btnCopyToClipboard.Size = new Size(381, 30);
            btnCopyToClipboard.TabIndex = 1;
            btnCopyToClipboard.Text = "Copy To Clipboard";
            btnCopyToClipboard.UseVisualStyleBackColor = true;
            btnCopyToClipboard.Click += btnCopyToClipboard_Click;
            // 
            // rtbBase64Output
            // 
            rtbBase64Output.Location = new Point(3, 38);
            rtbBase64Output.Name = "rtbBase64Output";
            rtbBase64Output.Size = new Size(385, 361);
            rtbBase64Output.TabIndex = 0;
            rtbBase64Output.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 408);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Base64 To Image";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(btnClear);
            splitContainer2.Panel1.Controls.Add(btnConvert);
            splitContainer2.Panel1.Controls.Add(rtbBase64Input);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(pbOutputImage);
            splitContainer2.Size = new Size(762, 402);
            splitContainer2.SplitterDistance = 367;
            splitContainer2.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(3, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(180, 30);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvert.Location = new Point(184, 3);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(180, 30);
            btnConvert.TabIndex = 1;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // rtbBase64Input
            // 
            rtbBase64Input.Location = new Point(3, 37);
            rtbBase64Input.Name = "rtbBase64Input";
            rtbBase64Input.Size = new Size(361, 361);
            rtbBase64Input.TabIndex = 0;
            rtbBase64Input.Text = "";
            // 
            // pbOutputImage
            // 
            pbOutputImage.Location = new Point(3, 3);
            pbOutputImage.Name = "pbOutputImage";
            pbOutputImage.Size = new Size(385, 396);
            pbOutputImage.TabIndex = 0;
            pbOutputImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "png";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "photo files (*.png)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Browse Photos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Base64 Image Converter";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbInputPhoto).EndInit();
            tabPage2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbOutputImage).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private SplitContainer splitContainer1;
        private RichTextBox rtbBase64Output;
        private SplitContainer splitContainer2;
        private RichTextBox rtbBase64Input;
        private PictureBox pbOutputImage;
        private PictureBox pbInputPhoto;
        private OpenFileDialog openFileDialog1;
        private Button btnBrowse;
        private TextBox textBox1;
        private Button btnConvert;
        private Button btnCopyToClipboard;
        private Button btnClear;
    }
}
