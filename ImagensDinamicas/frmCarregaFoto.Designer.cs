namespace ImagensDinamicas
{
    partial class frmCarregaFoto
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
            this.opdFoto = new System.Windows.Forms.OpenFileDialog();
            this.txtNomeJog2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeJog1 = new System.Windows.Forms.TextBox();
            this.lblNomeJog1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCarregarFoto1 = new System.Windows.Forms.Button();
            this.btnCarregaFoto2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnJogar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeJog2
            // 
            this.txtNomeJog2.Location = new System.Drawing.Point(459, 59);
            this.txtNomeJog2.Name = "txtNomeJog2";
            this.txtNomeJog2.Size = new System.Drawing.Size(160, 20);
            this.txtNomeJog2.TabIndex = 12;
            this.txtNomeJog2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome Jogador 2:";
            // 
            // txtNomeJog1
            // 
            this.txtNomeJog1.Location = new System.Drawing.Point(86, 59);
            this.txtNomeJog1.Name = "txtNomeJog1";
            this.txtNomeJog1.Size = new System.Drawing.Size(160, 20);
            this.txtNomeJog1.TabIndex = 14;
            this.txtNomeJog1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNomeJog1
            // 
            this.lblNomeJog1.AutoSize = true;
            this.lblNomeJog1.Cursor = System.Windows.Forms.Cursors.No;
            this.lblNomeJog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJog1.Location = new System.Drawing.Point(82, 33);
            this.lblNomeJog1.Name = "lblNomeJog1";
            this.lblNomeJog1.Size = new System.Drawing.Size(130, 20);
            this.lblNomeJog1.TabIndex = 13;
            this.lblNomeJog1.Text = "Nome Jogador 1:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(105, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCarregarFoto1
            // 
            this.btnCarregarFoto1.Location = new System.Drawing.Point(122, 203);
            this.btnCarregarFoto1.Name = "btnCarregarFoto1";
            this.btnCarregarFoto1.Size = new System.Drawing.Size(74, 35);
            this.btnCarregarFoto1.TabIndex = 9;
            this.btnCarregarFoto1.Text = "Carregar Foto";
            this.btnCarregarFoto1.UseVisualStyleBackColor = true;
            this.btnCarregarFoto1.Click += new System.EventHandler(this.btnCarregarFoto1_Click);
            // 
            // btnCarregaFoto2
            // 
            this.btnCarregaFoto2.Location = new System.Drawing.Point(495, 203);
            this.btnCarregaFoto2.Name = "btnCarregaFoto2";
            this.btnCarregaFoto2.Size = new System.Drawing.Size(74, 35);
            this.btnCarregaFoto2.TabIndex = 16;
            this.btnCarregaFoto2.Text = "Carregar Foto";
            this.btnCarregaFoto2.UseVisualStyleBackColor = true;
            this.btnCarregaFoto2.Click += new System.EventHandler(this.btnCarregaFoto2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(478, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(305, 203);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(101, 50);
            this.btnJogar.TabIndex = 17;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // frmCarregaFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 292);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnCarregaFoto2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtNomeJog1);
            this.Controls.Add(this.lblNomeJog1);
            this.Controls.Add(this.txtNomeJog2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCarregarFoto1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCarregaFoto";
            this.Text = "Carregar Foto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog opdFoto;
        private System.Windows.Forms.TextBox txtNomeJog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeJog1;
        private System.Windows.Forms.Label lblNomeJog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCarregarFoto1;
        private System.Windows.Forms.Button btnCarregaFoto2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnJogar;
    }
}

