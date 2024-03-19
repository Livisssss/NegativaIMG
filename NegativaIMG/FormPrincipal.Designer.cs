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
            this.btCarregar = new System.Windows.Forms.Button();
            this.btDownload = new System.Windows.Forms.Button();
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxNegativa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNegativa)).BeginInit();
            this.SuspendLayout();
            // 
            // btCarregar
            // 
            this.btCarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCarregar.Font = new System.Drawing.Font("Arial", 12F);
            this.btCarregar.Location = new System.Drawing.Point(50, 20);
            this.btCarregar.Name = "btCarregar";
            this.btCarregar.Size = new System.Drawing.Size(400, 34);
            this.btCarregar.TabIndex = 0;
            this.btCarregar.Text = "Carregar Imagem";
            this.btCarregar.Click += new System.EventHandler(this.btCarregar_Click);
            // 
            // btDownload
            // 
            this.btDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDownload.Enabled = false;
            this.btDownload.Font = new System.Drawing.Font("Arial", 12F);
            this.btDownload.Location = new System.Drawing.Point(538, 20);
            this.btDownload.Name = "btDownload";
            this.btDownload.Size = new System.Drawing.Size(400, 34);
            this.btDownload.TabIndex = 1;
            this.btDownload.Text = "Download Negativo";
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.Location = new System.Drawing.Point(50, 60);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 2;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxNegativa
            // 
            this.pictureBoxNegativa.Location = new System.Drawing.Point(538, 60);
            this.pictureBoxNegativa.Name = "pictureBoxNegativa";
            this.pictureBoxNegativa.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxNegativa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNegativa.TabIndex = 3;
            this.pictureBoxNegativa.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(1035, 505);
            this.Controls.Add(this.btCarregar);
            this.Controls.Add(this.btDownload);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Controls.Add(this.pictureBoxNegativa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicação de Negativo em Imagem";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNegativa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

