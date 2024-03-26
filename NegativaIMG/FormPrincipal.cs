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
        private PictureBox pictureBoxResultado;
        private Button btCarregaImgA;
        private Button btDownload;
        private Bitmap imgA;
        private Bitmap imagemNegativa;
        private int[] pixelData; // Array para armazenar os valores ARGB dos pixels

        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void btCarregaImgA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de imagem (**.jpg, *.jpeg, *.png *.tif)|*.jpg;*.jpeg;*.png; *.tif";

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                imgA = new Bitmap(openFileDialog.FileName);
                pictureBoxOriginal.Image = imgA;

                SalvarImagemEmArray(imgA);

            }
            else
            {
                MessageBox.Show("Selecione uma imagem válida");
            }
        }

        private void btCarregaImgB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de imagem (*.jpg, *.jpeg, *.png *.tif)|*.jpg;*.jpeg;*.png; *.tif";

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Carrega a segunda imagem
                Bitmap imgB = new Bitmap(openFileDialog.FileName);

                imgB = new Bitmap(openFileDialog.FileName);
                pictureBoxSegunda.Image = imgB;

                // Salva a segunda imagem em um array
                SalvarImagemEmArray(imgB);
            }
            else
            {
                MessageBox.Show("Selecione uma imagem válida");
            }
        }


        private void SalvarImagemEmArray(Bitmap imagem)
        {
            int largura = imagem.Width;
            int altura = imagem.Height;

            // Cria um array para armazenar os valores ARGB dos pixels da imagem
            pixelData = new int[largura * altura];

            // Preenche o array com os valores ARGB dos pixels da imagem
            int index = 0;
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    Color pixel = imagem.GetPixel(x, y);
                    pixelData[index] = pixel.ToArgb();
                    index++;
                }
            }
        }

        private void btNegativo_Click(object sender, EventArgs e)
        {
            if (imgA != null)
            {
                // Calcula o negativo da imagem original
                CalcularNegativo();
            }
            else
            {
                MessageBox.Show("O negativo não pode ser aplicado, pois não há imagem carregada.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btDownload_Click(object sender, EventArgs e)
        {
            if (imagemNegativa != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                saveFileDialog.Title = "Salvar Imagem";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagemNegativa.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                }
            }
            else
            {
                MessageBox.Show("Não há imagem para salvar.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }







        // funções
        private void CalcularNegativo()
        {
            if (pixelData != null)
            {
                int largura = imgA.Width;
                int altura = imgA.Height;

                // Inicializa a imagem negativa com as mesmas dimensões que a imagem original
                imagemNegativa = new Bitmap(largura, altura);

                // Itera sobre cada pixel no array de dados e aplica o negativo
                for (int i = 0; i < pixelData.Length; i++)
                {
                    // Obtém os componentes ARGB do pixel
                    int argb = pixelData[i];

                    int alpha = (argb >> 24) & 0xFF;  // >> para deslocar os bits para a direita e & 0xFF para aplicar a máscara e pegar apenas os 8 bits menos significativos
                    int red = (argb >> 16) & 0xFF;
                    int green = (argb >> 8) & 0xFF;
                    int blue = argb & 0xFF;

                    // Aplica o negativo, formando novo valor ARGB para representar a cor do pixel negativo fazendo -255
                    int negativo = (alpha << 24) | ((255 - red) << 16) | ((255 - green) << 8) | (255 - blue);

                    // Define o pixel negativo na imagem negativa   % nos da a coordenada x (posição horizontal) e / nos da a coordenada y (posição vertical)
                    imagemNegativa.SetPixel(i % largura, i / largura, Color.FromArgb(negativo));
                }

                // Exibe a imagem negativa no pictureBoxNegativa
                pictureBoxResultado.Image = imagemNegativa;

                // Habilita o botão de download
                btDownload.Enabled = true;
            }
        }

    }
}
