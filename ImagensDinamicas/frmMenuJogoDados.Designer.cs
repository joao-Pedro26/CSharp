namespace ImagensDinamicas
{
    partial class frmMenuJogoDados
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
            this.lblNomeJog1 = new System.Windows.Forms.Label();
            this.txtNomeJog1 = new System.Windows.Forms.TextBox();
            this.txtNomeJog2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btFrmDados = new System.Windows.Forms.Button();
            this.btFrmFotos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeJog1
            // 
            this.lblNomeJog1.AutoSize = true;
            this.lblNomeJog1.Cursor = System.Windows.Forms.Cursors.No;
            this.lblNomeJog1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJog1.Location = new System.Drawing.Point(44, 240);
            this.lblNomeJog1.Name = "lblNomeJog1";
            this.lblNomeJog1.Size = new System.Drawing.Size(173, 23);
            this.lblNomeJog1.TabIndex = 0;
            this.lblNomeJog1.Text = "Nome Jogador 1:";
            // 
            // txtNomeJog1
            // 
            this.txtNomeJog1.Location = new System.Drawing.Point(48, 266);
            this.txtNomeJog1.Name = "txtNomeJog1";
            this.txtNomeJog1.Size = new System.Drawing.Size(160, 20);
            this.txtNomeJog1.TabIndex = 2;
            this.txtNomeJog1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeJog2
            // 
            this.txtNomeJog2.Location = new System.Drawing.Point(346, 266);
            this.txtNomeJog2.Name = "txtNomeJog2";
            this.txtNomeJog2.Size = new System.Drawing.Size(160, 20);
            this.txtNomeJog2.TabIndex = 4;
            this.txtNomeJog2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Jogador 2:";
            // 
            // btFrmDados
            // 
            this.btFrmDados.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFrmDados.Location = new System.Drawing.Point(75, 85);
            this.btFrmDados.Name = "btFrmDados";
            this.btFrmDados.Size = new System.Drawing.Size(111, 96);
            this.btFrmDados.TabIndex = 5;
            this.btFrmDados.Text = "Dados";
            this.btFrmDados.UseVisualStyleBackColor = true;
            this.btFrmDados.Click += new System.EventHandler(this.btFrmDados_Click);
            // 
            // btFrmFotos
            // 
            this.btFrmFotos.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFrmFotos.Location = new System.Drawing.Point(371, 85);
            this.btFrmFotos.Name = "btFrmFotos";
            this.btFrmFotos.Size = new System.Drawing.Size(111, 96);
            this.btFrmFotos.TabIndex = 6;
            this.btFrmFotos.Text = "Fotos";
            this.btFrmFotos.UseVisualStyleBackColor = true;
            this.btFrmFotos.Click += new System.EventHandler(this.btFrmFotos_Click);
            // 
            // frmMenuJogoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 327);
            this.Controls.Add(this.btFrmFotos);
            this.Controls.Add(this.btFrmDados);
            this.Controls.Add(this.txtNomeJog2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeJog1);
            this.Controls.Add(this.lblNomeJog1);
            this.Name = "frmMenuJogoDados";
            this.Text = "frmMenuJogoDados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeJog1;
        private System.Windows.Forms.TextBox txtNomeJog1;
        private System.Windows.Forms.TextBox txtNomeJog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFrmDados;
        private System.Windows.Forms.Button btFrmFotos;
    }
}