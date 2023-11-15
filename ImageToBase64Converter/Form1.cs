namespace ImageToBase64Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string ConvertToBase64(string filePath)
        {
            using (Image image = Image.FromFile(filePath))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

        private static Image ConvertToImage(string base64)
        {
            //data:image/gif;base64,
            //this image is a single pixel (black)
            byte[] bytes = Convert.FromBase64String(base64);

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            return image;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.FileName;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string file;

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Photos",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "Image",
                Filter = "Image (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
"All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    file = openFileDialog1.FileName;
                    textBox1.Text = file;
                    pbInputPhoto.ImageLocation = file;
                    pbInputPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    rtbBase64Output.Text = ConvertToBase64(file);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid file");
                }

            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                pbOutputImage.Image = ConvertToImage(rtbBase64Input.Text);
                pbOutputImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid base64 string");
            }

        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbBase64Output.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtbBase64Input.Text = null;
        }
    }
}
