using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace NegativaIMG
{
    public partial class FormPrincipal : Form
    {
        private PictureBox pictureBoxOriginal;
        private PictureBox pictureBoxNegativa;
        private Button btCarregar;
        private Button btDownload;
        private Bitmap imagemOriginal;
        private Bitmap imagemNegativa;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Selecione a imagem";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagemPath = openFileDialog.FileName;

                // Carrega a imagem original
                imagemOriginal = new Bitmap(imagemPath);
                pictureBoxOriginal.Image = imagemOriginal;

                // Calcula o negativo da imagem
                imagemNegativa = new Bitmap(imagemOriginal.Width, imagemOriginal.Height);
                for (int y = 0; y < imagemOriginal.Height; y++)
                {
                    for (int x = 0; x < imagemOriginal.Width; x++)
                    {
                        Color pixelOriginal = imagemOriginal.GetPixel(x, y);
                        Color pixelNegativo = Color.FromArgb(255 - pixelOriginal.R, 255 - pixelOriginal.G, 255 - pixelOriginal.B);
                        imagemNegativa.SetPixel(x, y, pixelNegativo);
                    }
                }
                pictureBoxNegativa.Image = imagemNegativa;
                btDownload.Enabled = true; // Habilita o botão de download
            }
        }

        private void btDownload_Click(object sender, EventArgs e)
        {
            if (imagemNegativa != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                saveFileDialog.Title = "Salvar Imagem Negativa";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagemNegativa.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                }
            }
        }
    }
}
