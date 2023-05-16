namespace Editor_De_Imagens.Formularios.Ferramentas
{
    partial class frmRecorte
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTamano = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.nudAbaixo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAcima = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDireita = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudEsquerda = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbaixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAcima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDireita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEsquerda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTamano);
            this.panel1.Controls.Add(this.btOK);
            this.panel1.Controls.Add(this.nudAbaixo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nudAcima);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nudDireita);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nudEsquerda);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 325);
            this.panel1.TabIndex = 0;
            // 
            // lbTamano
            // 
            this.lbTamano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTamano.AutoSize = true;
            this.lbTamano.Location = new System.Drawing.Point(6, 275);
            this.lbTamano.Name = "lbTamano";
            this.lbTamano.Size = new System.Drawing.Size(30, 13);
            this.lbTamano.TabIndex = 8;
            this.lbTamano.Text = "0 x 0";
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btOK.Location = new System.Drawing.Point(6, 291);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(106, 23);
            this.btOK.TabIndex = 9;
            this.btOK.Text = "&OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // nudAbaixo
            // 
            this.nudAbaixo.Location = new System.Drawing.Point(6, 174);
            this.nudAbaixo.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudAbaixo.Name = "nudAbaixo";
            this.nudAbaixo.Size = new System.Drawing.Size(95, 20);
            this.nudAbaixo.TabIndex = 7;
            this.nudAbaixo.ValueChanged += new System.EventHandler(this.nudAbaixo_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pixels Abaixo: ";
            // 
            // nudAcima
            // 
            this.nudAcima.Location = new System.Drawing.Point(7, 28);
            this.nudAcima.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudAcima.Name = "nudAcima";
            this.nudAcima.Size = new System.Drawing.Size(95, 20);
            this.nudAcima.TabIndex = 1;
            this.nudAcima.ValueChanged += new System.EventHandler(this.nudAcima_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pixels Acima: ";
            // 
            // nudDireita
            // 
            this.nudDireita.Location = new System.Drawing.Point(7, 124);
            this.nudDireita.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudDireita.Name = "nudDireita";
            this.nudDireita.Size = new System.Drawing.Size(95, 20);
            this.nudDireita.TabIndex = 5;
            this.nudDireita.ValueChanged += new System.EventHandler(this.nudDireita_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pixels a Direita: ";
            // 
            // nudEsquerda
            // 
            this.nudEsquerda.Location = new System.Drawing.Point(7, 76);
            this.nudEsquerda.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudEsquerda.Name = "nudEsquerda";
            this.nudEsquerda.Size = new System.Drawing.Size(95, 20);
            this.nudEsquerda.TabIndex = 3;
            this.nudEsquerda.ValueChanged += new System.EventHandler(this.nudEsquerda_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pixels a Esquerda: ";
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbImg.BackgroundImage = global::Editor_De_Imagens.Properties.Resources.transparencia;
            this.pbImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImg.Location = new System.Drawing.Point(118, 0);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(444, 325);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 12;
            this.pbImg.TabStop = false;
            // 
            // frmRecorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 325);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmRecorte";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recortar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAbaixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAcima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDireita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEsquerda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTamano;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.NumericUpDown nudAbaixo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAcima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDireita;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudEsquerda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImg;
    }
}