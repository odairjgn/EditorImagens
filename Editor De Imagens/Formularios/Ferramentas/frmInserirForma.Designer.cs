namespace Editor_De_Imagens.Formularios.Ferramentas
{
    partial class frmInserirForma
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbElipseSolida = new System.Windows.Forms.RadioButton();
            this.rbRetanguloPreenchido = new System.Windows.Forms.RadioButton();
            this.rbElipse = new System.Windows.Forms.RadioButton();
            this.rbRetangulo = new System.Windows.Forms.RadioButton();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btInserir = new System.Windows.Forms.Button();
            this.nudAltura = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLargura = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargura)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbElipseSolida);
            this.groupBox1.Controls.Add(this.rbRetanguloPreenchido);
            this.groupBox1.Controls.Add(this.rbElipse);
            this.groupBox1.Controls.Add(this.rbRetangulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma";
            // 
            // rbElipseSolida
            // 
            this.rbElipseSolida.AutoSize = true;
            this.rbElipseSolida.Location = new System.Drawing.Point(16, 95);
            this.rbElipseSolida.Name = "rbElipseSolida";
            this.rbElipseSolida.Size = new System.Drawing.Size(85, 17);
            this.rbElipseSolida.TabIndex = 3;
            this.rbElipseSolida.Text = "Elipse Sólida";
            this.rbElipseSolida.UseVisualStyleBackColor = true;
            this.rbElipseSolida.CheckedChanged += new System.EventHandler(this.rbElipseSolida_CheckedChanged);
            // 
            // rbRetanguloPreenchido
            // 
            this.rbRetanguloPreenchido.AutoSize = true;
            this.rbRetanguloPreenchido.Location = new System.Drawing.Point(16, 72);
            this.rbRetanguloPreenchido.Name = "rbRetanguloPreenchido";
            this.rbRetanguloPreenchido.Size = new System.Drawing.Size(106, 17);
            this.rbRetanguloPreenchido.TabIndex = 2;
            this.rbRetanguloPreenchido.Text = "Retângulo Sólido";
            this.rbRetanguloPreenchido.UseVisualStyleBackColor = true;
            this.rbRetanguloPreenchido.CheckedChanged += new System.EventHandler(this.rbRetanguloPreenchido_CheckedChanged);
            // 
            // rbElipse
            // 
            this.rbElipse.AutoSize = true;
            this.rbElipse.Location = new System.Drawing.Point(16, 49);
            this.rbElipse.Name = "rbElipse";
            this.rbElipse.Size = new System.Drawing.Size(53, 17);
            this.rbElipse.TabIndex = 1;
            this.rbElipse.Text = "Elipse";
            this.rbElipse.UseVisualStyleBackColor = true;
            this.rbElipse.CheckedChanged += new System.EventHandler(this.rbElipse_CheckedChanged);
            // 
            // rbRetangulo
            // 
            this.rbRetangulo.AutoSize = true;
            this.rbRetangulo.Checked = true;
            this.rbRetangulo.Location = new System.Drawing.Point(16, 26);
            this.rbRetangulo.Name = "rbRetangulo";
            this.rbRetangulo.Size = new System.Drawing.Size(74, 17);
            this.rbRetangulo.TabIndex = 0;
            this.rbRetangulo.TabStop = true;
            this.rbRetangulo.Text = "Retângulo";
            this.rbRetangulo.UseVisualStyleBackColor = true;
            this.rbRetangulo.CheckedChanged += new System.EventHandler(this.rbRetangulo_CheckedChanged);
            // 
            // pbImg
            // 
            this.pbImg.BackgroundImage = global::Editor_De_Imagens.Properties.Resources.transparencia;
            this.pbImg.Location = new System.Drawing.Point(147, 12);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(479, 413);
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
            this.nudY.ValueChanged += new System.EventHandler(this.nudY_ValueChanged);
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
            this.nudX.ValueChanged += new System.EventHandler(this.nudX_ValueChanged);
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
            this.btInserir.Location = new System.Drawing.Point(12, 402);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(126, 23);
            this.btInserir.TabIndex = 11;
            this.btInserir.Text = "&Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // nudAltura
            // 
            this.nudAltura.Location = new System.Drawing.Point(66, 227);
            this.nudAltura.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAltura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAltura.Name = "nudAltura";
            this.nudAltura.Size = new System.Drawing.Size(75, 20);
            this.nudAltura.TabIndex = 8;
            this.nudAltura.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAltura.ValueChanged += new System.EventHandler(this.nudAltura_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Altura";
            // 
            // nudLargura
            // 
            this.nudLargura.Location = new System.Drawing.Point(66, 201);
            this.nudLargura.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudLargura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLargura.Name = "nudLargura";
            this.nudLargura.Size = new System.Drawing.Size(75, 20);
            this.nudLargura.TabIndex = 6;
            this.nudLargura.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudLargura.ValueChanged += new System.EventHandler(this.nudLargura_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Largura";
            // 
            // cbCor
            // 
            this.cbCor.FormattingEnabled = true;
            this.cbCor.Location = new System.Drawing.Point(12, 277);
            this.cbCor.Name = "cbCor";
            this.cbCor.Size = new System.Drawing.Size(126, 21);
            this.cbCor.TabIndex = 10;
            this.cbCor.SelectedIndexChanged += new System.EventHandler(this.cbCor_SelectedIndexChanged);
            this.cbCor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cor";
            // 
            // frmInserirForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 437);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCor);
            this.Controls.Add(this.nudAltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudLargura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInserirForma";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Forma";
            this.Load += new System.EventHandler(this.frmInserirForma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbElipse;
        private System.Windows.Forms.RadioButton rbRetangulo;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbElipseSolida;
        private System.Windows.Forms.RadioButton rbRetanguloPreenchido;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.NumericUpDown nudAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLargura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCor;
        private System.Windows.Forms.Label label5;
    }
}