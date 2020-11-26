using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathematical_morphology
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void limpar_Tela()
        {
            pictureBox_sem_filtros.Image = null;
            pictureBox_com_filtros.Image = null;
        }

        private void button_carregar_imagem_Click(object sender, EventArgs e)
        {
            //abre o open file dialog
            OpenFileDialog dialog_carregar_imagem = new OpenFileDialog();
            dialog_carregar_imagem.Filter = "Image |*.png;*.jpg;*.jpeg";
            if (dialog_carregar_imagem.ShowDialog() == DialogResult.OK)
            {
                limpar_Tela();
                pictureBox_sem_filtros.Image = new Bitmap(dialog_carregar_imagem.FileName);
            }
        }

        private Bitmap escala_cinza(Bitmap imagem_antiga)
        {
            int largura = imagem_antiga.Width;
            int altura = imagem_antiga.Height;

            Bitmap imagem_nova = new Bitmap(largura, altura);

            for (int coluna_antiga = 0; coluna_antiga < largura; coluna_antiga++)
            {
                for (int linha_antiga = 0; linha_antiga < altura; linha_antiga++)
                {
                    Color pixel_antigo = imagem_antiga.GetPixel(coluna_antiga, linha_antiga);
                    int vermelho = Convert.ToInt32(pixel_antigo.R.ToString());
                    int verde = Convert.ToInt32(pixel_antigo.G.ToString());
                    int azul = Convert.ToInt32(pixel_antigo.B.ToString());

                    int cinza_novo = (vermelho / 3) + (verde / 3) + (azul / 3);

                    Color pixel_novo = Color.FromArgb(255, cinza_novo, cinza_novo, cinza_novo);
                    imagem_nova.SetPixel(coluna_antiga, linha_antiga, pixel_novo);
                }
            }

            return imagem_nova;
        }

        private void button_escala_cinza_Click(object sender, EventArgs e)
        {
            if (pictureBox_com_filtros.Image != null)
            {
                pictureBox_com_filtros.Image = escala_cinza((Bitmap)pictureBox_com_filtros.Image);
            }
            else
            {
                pictureBox_com_filtros.Image = escala_cinza((Bitmap)pictureBox_sem_filtros.Image);
            }
        }

        private Bitmap limiar(Bitmap imagem_antiga)
        {
            int largura = imagem_antiga.Width;
            int altura = imagem_antiga.Height;

            Bitmap imagem_nova = new Bitmap(largura, altura);

            for (int coluna_antiga = 0; coluna_antiga < largura; coluna_antiga++)
            {
                for (int linha_antiga = 0; linha_antiga < altura; linha_antiga++)
                {
                    Color pixel_antigo = imagem_antiga.GetPixel(coluna_antiga, linha_antiga);
                    int cinza = Convert.ToInt32(pixel_antigo.R.ToString());
                    if(cinza > 70)
                    {
                        cinza = 255;
                    }
                    else
                    {
                        cinza = 0;
                    }

                    Color pixel_novo = Color.FromArgb(255, cinza, cinza, cinza);
                    imagem_nova.SetPixel(coluna_antiga, linha_antiga, pixel_novo);
                }
            }

            return imagem_nova;
        }

        private void button_limiar_Click(object sender, EventArgs e)
        {
            if (pictureBox_com_filtros.Image != null)
            {
                pictureBox_com_filtros.Image = limiar((Bitmap)pictureBox_com_filtros.Image);
            }
            else
            {
                pictureBox_com_filtros.Image = limiar((Bitmap)pictureBox_sem_filtros.Image);
            }
        }

        private Bitmap template_erosao(Bitmap imagem_antiga)
        {
            int largura = imagem_antiga.Width;
            int altura = imagem_antiga.Height;

            Bitmap imagem_nova = new Bitmap(largura, altura);

            for (int coluna_antiga = 0; coluna_antiga < largura; coluna_antiga++)
            {
                for (int linha_antiga = 0; linha_antiga < altura; linha_antiga++)
                {
                    Color pixel_antigo = imagem_antiga.GetPixel(coluna_antiga, linha_antiga);
                    int cor_antiga = Convert.ToInt32(pixel_antigo.R.ToString());

                    if (cor_antiga == 255)
                    {
                        for (int coluna_template = coluna_antiga - 1; coluna_template <= coluna_antiga + 1; coluna_template++)
                        {
                            for (int linha_template = linha_antiga - 1; linha_template <= linha_antiga + 1; linha_template++)
                            {

                                if (coluna_template >= 0 && linha_template >= 0) {
                                    if (coluna_template < largura && linha_template < altura) {
                                        
                                        Color pixel_template = imagem_antiga.GetPixel(coluna_template, linha_template);
                                        int cor_template = Convert.ToInt32(pixel_template.R.ToString());

                                        if (cor_template == 0)
                                        {
                                            //cima
                                            if (coluna_template == coluna_antiga && linha_template == linha_antiga-1) cor_antiga = 0;
                                            //esquerda
                                            if (coluna_template == coluna_antiga - 1 && linha_template == linha_antiga) cor_antiga = 0;
                                            //baixo
                                            if (coluna_template == coluna_antiga && linha_template == linha_antiga + 1) cor_antiga = 0;
                                            //direita
                                            if (coluna_template == coluna_antiga + 1 && linha_template == linha_antiga) cor_antiga = 0;
                                        }

                                    }
                                }

                            }
                        }
                    }

                    Color pixel_novo = Color.FromArgb(255, cor_antiga, cor_antiga, cor_antiga);
                    imagem_nova.SetPixel(coluna_antiga, linha_antiga, pixel_novo);
                }
            }

            return imagem_nova;
        }

        private void button_erosao_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< 2; i++)
            {
                if (pictureBox_com_filtros.Image != null)
                {
                    pictureBox_com_filtros.Image = template_erosao((Bitmap)pictureBox_com_filtros.Image);
                }
                else
                {
                    pictureBox_com_filtros.Image = template_erosao((Bitmap)pictureBox_sem_filtros.Image);
                }
            }
        }

    }
}