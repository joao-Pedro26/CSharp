﻿namespace ImagensDinamicas
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
            this.btFrmFotos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeJog1
            // 
            this.lblNomeJog1.AutoSize = true;
            this.lblNomeJog1.Cursor = System.Windows.Forms.Cursors.No;
            this.lblNomeJog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJog1.Location = new System.Drawing.Point(62, 243);
            this.lblNomeJog1.Name = "lblNomeJog1";
            this.lblNomeJog1.Size = new System.Drawing.Size(130, 20);
            this.lblNomeJog1.TabIndex = 0;
            this.lblNomeJog1.Text = "Nome Jogador 1:";
            // 
            // txtNomeJog1
            // 
            this.txtNomeJog1.Location = new System.Drawing.Point(66, 269);
            this.txtNomeJog1.Name = "txtNomeJog1";
            this.txtNomeJog1.Size = new System.Drawing.Size(160, 20);
            this.txtNomeJog1.TabIndex = 2;
            this.txtNomeJog1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeJog2
            // 
            this.txtNomeJog2.Location = new System.Drawing.Point(66, 202);
            this.txtNomeJog2.Name = "txtNomeJog2";
            this.txtNomeJog2.Size = new System.Drawing.Size(160, 20);
            this.txtNomeJog2.TabIndex = 4;
            this.txtNomeJog2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Jogador 2:";
            // 
            // btFrmFotos
            // 
            this.btFrmFotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFrmFotos.Location = new System.Drawing.Point(353, 12);
            this.btFrmFotos.Name = "btFrmFotos";
            this.btFrmFotos.Size = new System.Drawing.Size(170, 141);
            this.btFrmFotos.TabIndex = 6;
            this.btFrmFotos.Text = "Fotos";
            this.btFrmFotos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btFrmFotos.UseVisualStyleBackColor = true;
            this.btFrmFotos.Click += new System.EventHandler(this.btFrmFotos_Click);
            // 
            // frmMenuJogoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 327);
            this.Controls.Add(this.btFrmFotos);
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
        private System.Windows.Forms.Button btFrmFotos;
    }
}