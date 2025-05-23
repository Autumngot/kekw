using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace create_form
{
    public partial class FormImage: Form
    {
        private Image originalImage;

        public FormImage()
        {
            InitializeComponent();
            this.Text = "Открытие изображений";
        }

        private void FormImage_Load(object sender, EventArgs e)
        {

        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                int newWidth = (int)nudWidth.Value;
                int newHeight = (int)nudHeight.Value;
                Image resized = new Bitmap(originalImage, new Size(newWidth, newHeight));
                pbImage.Image = resized;
            }
            else
            {
                MessageBox.Show("Сначала загрузите изображение!");
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            new ThreeForms().Show();
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                originalImage = Image.FromFile(ofd.FileName);
                pbImage.Image = originalImage;
            }
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                // Получаем размеры из NumericUpDown
                int newWidth = (int)nudWidth.Value;
                int newHeight = (int)nudHeight.Value;

                // Создаём новое изображение с нужным размером
                Bitmap resizedImage = new Bitmap(originalImage, new Size(newWidth, newHeight));

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                sfd.FileName = "resized_image";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ImageFormat format = ImageFormat.Png;
                    string ext = Path.GetExtension(sfd.FileName).ToLower();
                    if (ext == ".jpg" || ext == ".jpeg")
                        format = ImageFormat.Jpeg;
                    else if (ext == ".bmp")
                        format = ImageFormat.Bmp;

                    resizedImage.Save(sfd.FileName, format);
                    MessageBox.Show("Изображение сохранено с новым размером.");
                }

                resizedImage.Dispose(); // очищаем ресурсы
            }
            else
            {
                MessageBox.Show("Сначала загрузите изображение.");
            }
        }
    }
}
