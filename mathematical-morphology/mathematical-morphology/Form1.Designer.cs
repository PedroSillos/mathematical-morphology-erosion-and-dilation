
namespace mathematical_morphology
{
    partial class Form1
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
            this.button_carregar_imagem = new System.Windows.Forms.Button();
            this.pictureBox_sem_filtros = new System.Windows.Forms.PictureBox();
            this.pictureBox_com_filtros = new System.Windows.Forms.PictureBox();
            this.button_erosao = new System.Windows.Forms.Button();
            this.button_Dilatacao = new System.Windows.Forms.Button();
            this.button_achar_bordas = new System.Windows.Forms.Button();
            this.button_escala_cinza = new System.Windows.Forms.Button();
            this.button_limiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sem_filtros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_com_filtros)).BeginInit();
            this.SuspendLayout();
            // 
            // button_carregar_imagem
            // 
            this.button_carregar_imagem.AccessibleDescription = "Carregar imagem";
            this.button_carregar_imagem.AccessibleName = "botão carregar imagem";
            this.button_carregar_imagem.AutoSize = true;
            this.button_carregar_imagem.Location = new System.Drawing.Point(18, 34);
            this.button_carregar_imagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_carregar_imagem.Name = "button_carregar_imagem";
            this.button_carregar_imagem.Size = new System.Drawing.Size(173, 36);
            this.button_carregar_imagem.TabIndex = 0;
            this.button_carregar_imagem.Text = "Carregar imagem";
            this.button_carregar_imagem.UseVisualStyleBackColor = true;
            this.button_carregar_imagem.Click += new System.EventHandler(this.button_carregar_imagem_Click);
            // 
            // pictureBox_sem_filtros
            // 
            this.pictureBox_sem_filtros.Location = new System.Drawing.Point(198, 19);
            this.pictureBox_sem_filtros.Name = "pictureBox_sem_filtros";
            this.pictureBox_sem_filtros.Size = new System.Drawing.Size(360, 360);
            this.pictureBox_sem_filtros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_sem_filtros.TabIndex = 1;
            this.pictureBox_sem_filtros.TabStop = false;
            // 
            // pictureBox_com_filtros
            // 
            this.pictureBox_com_filtros.Location = new System.Drawing.Point(745, 19);
            this.pictureBox_com_filtros.Name = "pictureBox_com_filtros";
            this.pictureBox_com_filtros.Size = new System.Drawing.Size(360, 360);
            this.pictureBox_com_filtros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_com_filtros.TabIndex = 3;
            this.pictureBox_com_filtros.TabStop = false;
            // 
            // button_erosao
            // 
            this.button_erosao.AccessibleDescription = "Erosão";
            this.button_erosao.AccessibleName = "botão Erosão";
            this.button_erosao.AutoSize = true;
            this.button_erosao.Location = new System.Drawing.Point(565, 126);
            this.button_erosao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_erosao.Name = "button_erosao";
            this.button_erosao.Size = new System.Drawing.Size(173, 36);
            this.button_erosao.TabIndex = 2;
            this.button_erosao.Text = "Erosão";
            this.button_erosao.UseVisualStyleBackColor = true;
            this.button_erosao.Click += new System.EventHandler(this.button_erosao_Click);
            // 
            // button_Dilatacao
            // 
            this.button_Dilatacao.AccessibleDescription = "Dilatação";
            this.button_Dilatacao.AccessibleName = "botão Dilatação";
            this.button_Dilatacao.AutoSize = true;
            this.button_Dilatacao.Location = new System.Drawing.Point(565, 172);
            this.button_Dilatacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Dilatacao.Name = "button_Dilatacao";
            this.button_Dilatacao.Size = new System.Drawing.Size(173, 36);
            this.button_Dilatacao.TabIndex = 4;
            this.button_Dilatacao.Text = "Dilatação";
            this.button_Dilatacao.UseVisualStyleBackColor = true;
            this.button_Dilatacao.Click += new System.EventHandler(this.button_Dilatacao_Click);
            // 
            // button_achar_bordas
            // 
            this.button_achar_bordas.AccessibleDescription = "Achar bordas";
            this.button_achar_bordas.AccessibleName = "botão Achar bordas";
            this.button_achar_bordas.AutoSize = true;
            this.button_achar_bordas.Location = new System.Drawing.Point(565, 218);
            this.button_achar_bordas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_achar_bordas.Name = "button_achar_bordas";
            this.button_achar_bordas.Size = new System.Drawing.Size(173, 36);
            this.button_achar_bordas.TabIndex = 5;
            this.button_achar_bordas.Text = "Achar bordas";
            this.button_achar_bordas.UseVisualStyleBackColor = true;
            // 
            // button_escala_cinza
            // 
            this.button_escala_cinza.AccessibleDescription = "Escala de cinza";
            this.button_escala_cinza.AccessibleName = "botão escala de cinza";
            this.button_escala_cinza.AutoSize = true;
            this.button_escala_cinza.Location = new System.Drawing.Point(565, 34);
            this.button_escala_cinza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_escala_cinza.Name = "button_escala_cinza";
            this.button_escala_cinza.Size = new System.Drawing.Size(173, 36);
            this.button_escala_cinza.TabIndex = 6;
            this.button_escala_cinza.Text = "Escala de cinza";
            this.button_escala_cinza.UseVisualStyleBackColor = true;
            this.button_escala_cinza.Click += new System.EventHandler(this.button_escala_cinza_Click);
            // 
            // button_limiar
            // 
            this.button_limiar.AccessibleDescription = "";
            this.button_limiar.AccessibleName = "botão Limiar";
            this.button_limiar.AutoSize = true;
            this.button_limiar.Location = new System.Drawing.Point(565, 80);
            this.button_limiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_limiar.Name = "button_limiar";
            this.button_limiar.Size = new System.Drawing.Size(173, 36);
            this.button_limiar.TabIndex = 7;
            this.button_limiar.Text = "Limiar";
            this.button_limiar.UseVisualStyleBackColor = true;
            this.button_limiar.Click += new System.EventHandler(this.button_limiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 419);
            this.Controls.Add(this.button_limiar);
            this.Controls.Add(this.button_escala_cinza);
            this.Controls.Add(this.button_achar_bordas);
            this.Controls.Add(this.button_Dilatacao);
            this.Controls.Add(this.pictureBox_com_filtros);
            this.Controls.Add(this.button_erosao);
            this.Controls.Add(this.pictureBox_sem_filtros);
            this.Controls.Add(this.button_carregar_imagem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sem_filtros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_com_filtros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_carregar_imagem;
        private System.Windows.Forms.PictureBox pictureBox_sem_filtros;
        private System.Windows.Forms.PictureBox pictureBox_com_filtros;
        private System.Windows.Forms.Button button_erosao;
        private System.Windows.Forms.Button button_Dilatacao;
        private System.Windows.Forms.Button button_achar_bordas;
        private System.Windows.Forms.Button button_escala_cinza;
        private System.Windows.Forms.Button button_limiar;
    }
}

