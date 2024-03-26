using System.Drawing;
using System.Windows.Forms;

namespace NegativaIMG
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btCarregaImgA = new System.Windows.Forms.Button();
            this.btDownload = new System.Windows.Forms.Button();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxResultado = new System.Windows.Forms.PictureBox();
            this.btNegativo = new System.Windows.Forms.Button();
            this.pictureBoxSegunda = new System.Windows.Forms.PictureBox();
            this.btCarregaImgB = new System.Windows.Forms.Button();
            this.gbA = new System.Windows.Forms.GroupBox();
            this.gbB = new System.Windows.Forms.GroupBox();
            this.gbR = new System.Windows.Forms.GroupBox();
            this.btSomar = new System.Windows.Forms.Button();
            this.gbSelecao = new System.Windows.Forms.GroupBox();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbAB = new System.Windows.Forms.RadioButton();
            this.gbOpArit = new System.Windows.Forms.GroupBox();
            this.btSubtrair = new System.Windows.Forms.Button();
            this.gbGirar = new System.Windows.Forms.GroupBox();
            this.btFlipLR = new System.Windows.Forms.Button();
            this.btFlipUD = new System.Windows.Forms.Button();
            this.gbRecortar = new System.Windows.Forms.GroupBox();
            this.gbConcatenar = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSegunda)).BeginInit();
            this.gbA.SuspendLayout();
            this.gbB.SuspendLayout();
            this.gbR.SuspendLayout();
            this.gbSelecao.SuspendLayout();
            this.gbOpArit.SuspendLayout();
            this.gbGirar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCarregaImgA
            // 
            this.btCarregaImgA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCarregaImgA.Font = new System.Drawing.Font("Arial", 12F);
            this.btCarregaImgA.Location = new System.Drawing.Point(16, 29);
            this.btCarregaImgA.Name = "btCarregaImgA";
            this.btCarregaImgA.Size = new System.Drawing.Size(280, 34);
            this.btCarregaImgA.TabIndex = 0;
            this.btCarregaImgA.Text = "Carregar";
            this.btCarregaImgA.Click += new System.EventHandler(this.btCarregaImgA_Click);
            // 
            // btDownload
            // 
            this.btDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDownload.Enabled = false;
            this.btDownload.Font = new System.Drawing.Font("Arial", 12F);
            this.btDownload.Location = new System.Drawing.Point(6, 19);
            this.btDownload.Name = "btDownload";
            this.btDownload.Size = new System.Drawing.Size(280, 34);
            this.btDownload.TabIndex = 1;
            this.btDownload.Text = "Download Imagem";
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.AccessibleName = "";
            this.pictureBoxOriginal.Location = new System.Drawing.Point(16, 69);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(280, 280);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 2;
            this.pictureBoxOriginal.TabStop = false;
            this.pictureBoxOriginal.Tag = "Imagem 1";
            // 
            // pictureBoxResultado
            // 
            this.pictureBoxResultado.Location = new System.Drawing.Point(6, 59);
            this.pictureBoxResultado.Name = "pictureBoxResultado";
            this.pictureBoxResultado.Size = new System.Drawing.Size(280, 280);
            this.pictureBoxResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResultado.TabIndex = 3;
            this.pictureBoxResultado.TabStop = false;
            // 
            // btNegativo
            // 
            this.btNegativo.Location = new System.Drawing.Point(525, 548);
            this.btNegativo.Name = "btNegativo";
            this.btNegativo.Size = new System.Drawing.Size(93, 27);
            this.btNegativo.TabIndex = 4;
            this.btNegativo.Text = "Aplicar Negativo";
            this.btNegativo.UseVisualStyleBackColor = true;
            this.btNegativo.Click += new System.EventHandler(this.btNegativo_Click);
            // 
            // pictureBoxSegunda
            // 
            this.pictureBoxSegunda.AccessibleName = "";
            this.pictureBoxSegunda.Location = new System.Drawing.Point(16, 69);
            this.pictureBoxSegunda.Name = "pictureBoxSegunda";
            this.pictureBoxSegunda.Size = new System.Drawing.Size(280, 280);
            this.pictureBoxSegunda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSegunda.TabIndex = 5;
            this.pictureBoxSegunda.TabStop = false;
            // 
            // btCarregaImgB
            // 
            this.btCarregaImgB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCarregaImgB.Font = new System.Drawing.Font("Arial", 12F);
            this.btCarregaImgB.Location = new System.Drawing.Point(16, 29);
            this.btCarregaImgB.Name = "btCarregaImgB";
            this.btCarregaImgB.Size = new System.Drawing.Size(280, 34);
            this.btCarregaImgB.TabIndex = 6;
            this.btCarregaImgB.Text = "Carregar";
            this.btCarregaImgB.Click += new System.EventHandler(this.btCarregaImgB_Click);
            // 
            // gbA
            // 
            this.gbA.Controls.Add(this.btCarregaImgA);
            this.gbA.Controls.Add(this.pictureBoxOriginal);
            this.gbA.Location = new System.Drawing.Point(21, 20);
            this.gbA.Name = "gbA";
            this.gbA.Size = new System.Drawing.Size(311, 355);
            this.gbA.TabIndex = 7;
            this.gbA.TabStop = false;
            this.gbA.Text = "Imagem A";
            // 
            // gbB
            // 
            this.gbB.Controls.Add(this.btCarregaImgB);
            this.gbB.Controls.Add(this.pictureBoxSegunda);
            this.gbB.Location = new System.Drawing.Point(21, 411);
            this.gbB.Name = "gbB";
            this.gbB.Size = new System.Drawing.Size(311, 355);
            this.gbB.TabIndex = 8;
            this.gbB.TabStop = false;
            this.gbB.Text = "Imagem B";
            // 
            // gbR
            // 
            this.gbR.Controls.Add(this.btDownload);
            this.gbR.Controls.Add(this.pictureBoxResultado);
            this.gbR.Location = new System.Drawing.Point(919, 12);
            this.gbR.Name = "gbR";
            this.gbR.Size = new System.Drawing.Size(293, 342);
            this.gbR.TabIndex = 9;
            this.gbR.TabStop = false;
            this.gbR.Text = "Resultado";
            // 
            // btSomar
            // 
            this.btSomar.Location = new System.Drawing.Point(6, 19);
            this.btSomar.Name = "btSomar";
            this.btSomar.Size = new System.Drawing.Size(102, 27);
            this.btSomar.TabIndex = 10;
            this.btSomar.Text = "Somar Imagens";
            this.btSomar.UseVisualStyleBackColor = true;
            // 
            // gbSelecao
            // 
            this.gbSelecao.Controls.Add(this.rbAB);
            this.gbSelecao.Controls.Add(this.rbB);
            this.gbSelecao.Controls.Add(this.rbA);
            this.gbSelecao.Location = new System.Drawing.Point(367, 71);
            this.gbSelecao.Name = "gbSelecao";
            this.gbSelecao.Size = new System.Drawing.Size(106, 100);
            this.gbSelecao.TabIndex = 11;
            this.gbSelecao.TabStop = false;
            this.gbSelecao.Text = "1. Seleção";
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Location = new System.Drawing.Point(7, 20);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(72, 17);
            this.rbA.TabIndex = 0;
            this.rbA.TabStop = true;
            this.rbA.Text = "Imagem A";
            this.rbA.UseVisualStyleBackColor = true;
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Location = new System.Drawing.Point(7, 44);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(72, 17);
            this.rbB.TabIndex = 1;
            this.rbB.TabStop = true;
            this.rbB.Text = "Imagem B";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbAB
            // 
            this.rbAB.AutoSize = true;
            this.rbAB.Location = new System.Drawing.Point(7, 68);
            this.rbAB.Name = "rbAB";
            this.rbAB.Size = new System.Drawing.Size(57, 17);
            this.rbAB.TabIndex = 2;
            this.rbAB.TabStop = true;
            this.rbAB.Text = "Ambas";
            this.rbAB.UseVisualStyleBackColor = true;
            // 
            // gbOpArit
            // 
            this.gbOpArit.Controls.Add(this.btSubtrair);
            this.gbOpArit.Controls.Add(this.btSomar);
            this.gbOpArit.Location = new System.Drawing.Point(525, 71);
            this.gbOpArit.Name = "gbOpArit";
            this.gbOpArit.Size = new System.Drawing.Size(151, 100);
            this.gbOpArit.TabIndex = 12;
            this.gbOpArit.TabStop = false;
            this.gbOpArit.Text = "Operações Aritméticas:";
            // 
            // btSubtrair
            // 
            this.btSubtrair.Location = new System.Drawing.Point(6, 52);
            this.btSubtrair.Name = "btSubtrair";
            this.btSubtrair.Size = new System.Drawing.Size(102, 27);
            this.btSubtrair.TabIndex = 11;
            this.btSubtrair.Text = "Subtrair Imagens";
            this.btSubtrair.UseVisualStyleBackColor = true;
            // 
            // gbGirar
            // 
            this.gbGirar.Controls.Add(this.btFlipLR);
            this.gbGirar.Controls.Add(this.btFlipUD);
            this.gbGirar.Location = new System.Drawing.Point(525, 187);
            this.gbGirar.Name = "gbGirar";
            this.gbGirar.Size = new System.Drawing.Size(151, 100);
            this.gbGirar.TabIndex = 13;
            this.gbGirar.TabStop = false;
            this.gbGirar.Text = "Girar:";
            // 
            // btFlipLR
            // 
            this.btFlipLR.Location = new System.Drawing.Point(6, 55);
            this.btFlipLR.Name = "btFlipLR";
            this.btFlipLR.Size = new System.Drawing.Size(102, 27);
            this.btFlipLR.TabIndex = 13;
            this.btFlipLR.Text = "Flip Left/Rigth";
            this.btFlipLR.UseVisualStyleBackColor = true;
            // 
            // btFlipUD
            // 
            this.btFlipUD.Location = new System.Drawing.Point(6, 22);
            this.btFlipUD.Name = "btFlipUD";
            this.btFlipUD.Size = new System.Drawing.Size(102, 27);
            this.btFlipUD.TabIndex = 12;
            this.btFlipUD.Text = "Flip Up/Down";
            this.btFlipUD.UseVisualStyleBackColor = true;
            // 
            // gbRecortar
            // 
            this.gbRecortar.Location = new System.Drawing.Point(525, 308);
            this.gbRecortar.Name = "gbRecortar";
            this.gbRecortar.Size = new System.Drawing.Size(151, 100);
            this.gbRecortar.TabIndex = 14;
            this.gbRecortar.TabStop = false;
            this.gbRecortar.Text = "Recortar:";
            // 
            // gbConcatenar
            // 
            this.gbConcatenar.Location = new System.Drawing.Point(525, 423);
            this.gbConcatenar.Name = "gbConcatenar";
            this.gbConcatenar.Size = new System.Drawing.Size(151, 100);
            this.gbConcatenar.TabIndex = 15;
            this.gbConcatenar.TabStop = false;
            this.gbConcatenar.Text = "Concatenar:";
            // 
            // FormPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(1224, 855);
            this.Controls.Add(this.gbConcatenar);
            this.Controls.Add(this.gbRecortar);
            this.Controls.Add(this.gbGirar);
            this.Controls.Add(this.gbOpArit);
            this.Controls.Add(this.btNegativo);
            this.Controls.Add(this.gbSelecao);
            this.Controls.Add(this.gbR);
            this.Controls.Add(this.gbB);
            this.Controls.Add(this.gbA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edições em Imagem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSegunda)).EndInit();
            this.gbA.ResumeLayout(false);
            this.gbB.ResumeLayout(false);
            this.gbR.ResumeLayout(false);
            this.gbSelecao.ResumeLayout(false);
            this.gbSelecao.PerformLayout();
            this.gbOpArit.ResumeLayout(false);
            this.gbGirar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btNegativo;
        private PictureBox pictureBoxSegunda;
        private Button btCarregaImgB;
        private GroupBox gbA;
        private GroupBox gbB;
        private GroupBox gbR;
        private Button btSomar;
        private GroupBox gbSelecao;
        private RadioButton rbAB;
        private RadioButton rbB;
        private RadioButton rbA;
        private GroupBox gbOpArit;
        private Button btSubtrair;
        private GroupBox gbGirar;
        private Button btFlipLR;
        private Button btFlipUD;
        private GroupBox gbRecortar;
        private GroupBox gbConcatenar;
    }
}
