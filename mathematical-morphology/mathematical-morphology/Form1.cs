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
    }
}