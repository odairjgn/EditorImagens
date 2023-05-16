namespace Editor_De_Imagens.Formularios.Ferramentas
{
    partial class frmInserirTexto
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
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btInserir = new System.Windows.Forms.Button();
            this.cbCor1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCor2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbFonte = new System.Windows.Forms.ComboBox();
            this.nudTamanho = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstilo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanho)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImg
            // 
            this.pbImg.BackgroundImage = global::Editor_De_Imagens.Properties.Resources.transparencia;
            this.pbImg.Location = new System.Drawing.Point(147, 12);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(479, 417);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 8;
            this.pbImg.TabStop = false;
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(66, 175);
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(75, 20);
            this.nudY.TabIndex = 4;
            this.nudY.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y";
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(66, 149);
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(75, 20);
            this.nudX.TabIndex = 2;
            this.nudX.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(12, 406);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(126, 23);
            this.btInserir.TabIndex = 11;
            this.btInserir.Text = "&Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // cbCor1
            // 
            this.cbCor1.FormattingEnabled = true;
            this.cbCor1.Location = new System.Drawing.Point(12, 222);
            this.cbCor1.Name = "cbCor1";
            this.cbCor1.Size = new System.Drawing.Size(126, 21);
            this.cbCor1.TabIndex = 10;
            this.cbCor1.SelectedIndexChanged += new System.EventHandler(this.cbCor_SelectedIndexChanged);
            this.cbCor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cor 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Texto";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(12, 25);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(126, 118);
            this.txtTexto.TabIndex = 13;
            this.txtTexto.Text = "Texto";
            this.txtTexto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cor 2";
            // 
            // cbCor2
            // 
            this.cbCor2.FormattingEnabled = true;
            this.cbCor2.Location = new System.Drawing.Point(12, 265);
            this.cbCor2.Name = "cbCor2";
            this.cbCor2.Size = new System.Drawing.Size(126, 21);
            this.cbCor2.TabIndex = 15;
            this.cbCor2.SelectedIndexChanged += new System.EventHandler(this.cbCor_SelectedIndexChanged);
            this.cbCor2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fonte";
            // 
            // cbFonte
            // 
            this.cbFonte.FormattingEnabled = true;
            this.cbFonte.Location = new System.Drawing.Point(12, 305);
            this.cbFonte.Name = "cbFonte";
            this.cbFonte.Size = new System.Drawing.Size(126, 21);
            this.cbFonte.TabIndex = 17;
            this.cbFonte.SelectedIndexChanged += new System.EventHandler(this.cbCor_SelectedIndexChanged);
            this.cbFonte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // nudTamanho
            // 
            this.nudTamanho.Location = new System.Drawing.Point(63, 332);
            this.nudTamanho.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudTamanho.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudTamanho.Name = "nudTamanho";
            this.nudTamanho.Size = new System.Drawing.Size(75, 20);
            this.nudTamanho.TabIndex = 19;
            this.nudTamanho.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudTamanho.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tamanho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Estilo";
            // 
            // cbEstilo
            // 
            this.cbEstilo.FormattingEnabled = true;
            this.cbEstilo.Location = new System.Drawing.Point(12, 373);
            this.cbEstilo.Name = "cbEstilo";
            this.cbEstilo.Size = new System.Drawing.Size(126, 21);
            this.cbEstilo.TabIndex = 21;
            this.cbEstilo.SelectedIndexChanged += new System.EventHandler(this.cbCor_SelectedIndexChanged);
            this.cbEstilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // frmInserirTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEstilo);
            this.Controls.Add(this.nudTamanho);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbFonte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCor2);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCor1);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInserirTexto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Texto";
            this.Load += new System.EventHandler(this.frmInserirForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTamanho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.ComboBox cbCor1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCor2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbFonte;
        private System.Windows.Forms.NumericUpDown nudTamanho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstilo;
    }
}