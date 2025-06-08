namespace ImagensDinamicas
{
    partial class frmJogoDados
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
            this.components = new System.ComponentModel.Container();
            this.pcJogador1 = new System.Windows.Forms.PictureBox();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.lblPlacar1 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.pcJogador2 = new System.Windows.Forms.PictureBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblPlacar2 = new System.Windows.Forms.Label();
            this.timerDado = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcJogador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcJogador2)).BeginInit();
            this.SuspendLayout();
            // 
            // pcJogador1
            // 
            this.pcJogador1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcJogador1.Location = new System.Drawing.Point(64, 48);
            this.pcJogador1.Name = "pcJogador1";
            this.pcJogador1.Size = new System.Drawing.Size(180, 180);
            this.pcJogador1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcJogador1.TabIndex = 0;
            this.pcJogador1.TabStop = false;
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador1.Location = new System.Drawing.Point(103, 9);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(108, 25);
            this.lblJogador1.TabIndex = 1;
            this.lblJogador1.Text = "Jogador 1";
            // 
            // lblPlacar1
            // 
            this.lblPlacar1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPlacar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlacar1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar1.Location = new System.Drawing.Point(108, 259);
            this.lblPlacar1.Name = "lblPlacar1";
            this.lblPlacar1.Size = new System.Drawing.Size(80, 73);
            this.lblPlacar1.TabIndex = 2;
            this.lblPlacar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblJogador2.Location = new System.Drawing.Point(589, 9);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(108, 25);
            this.lblJogador2.TabIndex = 4;
            this.lblJogador2.Text = "Jogador 2";
            // 
            // pcJogador2
            // 
            this.pcJogador2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcJogador2.Location = new System.Drawing.Point(544, 48);
            this.pcJogador2.Name = "pcJogador2";
            this.pcJogador2.Size = new System.Drawing.Size(180, 180);
            this.pcJogador2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcJogador2.TabIndex = 3;
            this.pcJogador2.TabStop = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(164, 368);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(144, 58);
            this.btnReiniciar.TabIndex = 6;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnJogar.Location = new System.Drawing.Point(326, 368);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(144, 58);
            this.btnJogar.TabIndex = 7;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(484, 368);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(144, 58);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblPlacar2
            // 
            this.lblPlacar2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPlacar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlacar2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar2.Location = new System.Drawing.Point(594, 259);
            this.lblPlacar2.Name = "lblPlacar2";
            this.lblPlacar2.Size = new System.Drawing.Size(79, 73);
            this.lblPlacar2.TabIndex = 9;
            this.lblPlacar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerDado
            // 
            this.timerDado.Interval = 200;
            this.timerDado.Tick += new System.EventHandler(this.timerDado_Tick);
            // 
            // frmJogoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlacar2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblJogador2);
            this.Controls.Add(this.pcJogador2);
            this.Controls.Add(this.lblPlacar1);
            this.Controls.Add(this.lblJogador1);
            this.Controls.Add(this.pcJogador1);
            this.Name = "frmJogoDados";
            this.Text = "Jogo de Dados";
            this.Load += new System.EventHandler(this.frmJogoDados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcJogador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcJogador2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcJogador1;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label lblPlacar1;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.PictureBox pcJogador2;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblPlacar2;
        private System.Windows.Forms.Timer timerDado;
    }
}