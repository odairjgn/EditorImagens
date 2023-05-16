namespace Editor_De_Imagens.Formularios.Ferramentas
{
    partial class frmRedimencionar
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudAltura = new System.Windows.Forms.NumericUpDown();
            this.nudLargura = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.rbExato = new System.Windows.Forms.RadioButton();
            this.rbPercentual = new System.Windows.Forms.RadioButton();
            this.nudPercentual = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbProporcao = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentual)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Altura: ";
            // 
            // nudAltura
            // 
            this.nudAltura.Location = new System.Drawing.Point(64, 35);
            this.nudAltura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAltura.Name = "nudAltura";
            this.nudAltura.Size = new System.Drawing.Size(102, 20);
            this.nudAltura.TabIndex = 2;
            this.nudAltura.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAltura.ValueChanged += new System.EventHandler(this.nudAltura_ValueChanged);
            // 
            // nudLargura
            // 
            this.nudLargura.Location = new System.Drawing.Point(64, 61);
            this.nudLargura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLargura.Name = "nudLargura";
            this.nudLargura.Size = new System.Drawing.Size(102, 20);
            this.nudLargura.TabIndex = 4;
            this.nudLargura.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLargura.ValueChanged += new System.EventHandler(this.nudLargura_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Largura: ";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(99, 184);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 10;
            this.btOk.Text = "&OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // rbExato
            // 
            this.rbExato.AutoSize = true;
            this.rbExato.Checked = true;
            this.rbExato.Location = new System.Drawing.Point(12, 12);
            this.rbExato.Name = "rbExato";
            this.rbExato.Size = new System.Drawing.Size(100, 17);
            this.rbExato.TabIndex = 0;
            this.rbExato.TabStop = true;
            this.rbExato.Text = "Tamanho Exato";
            this.rbExato.UseVisualStyleBackColor = true;
            // 
            // rbPercentual
            // 
            this.rbPercentual.AutoSize = true;
            this.rbPercentual.Location = new System.Drawing.Point(12, 124);
            this.rbPercentual.Name = "rbPercentual";
            this.rbPercentual.Size = new System.Drawing.Size(76, 17);
            this.rbPercentual.TabIndex = 6;
            this.rbPercentual.Text = "Percentual";
            this.rbPercentual.UseVisualStyleBackColor = true;
            this.rbPercentual.CheckedChanged += new System.EventHandler(this.rbPercentual_CheckedChanged);
            // 
            // nudPercentual
            // 
            this.nudPercentual.Enabled = false;
            this.nudPercentual.Location = new System.Drawing.Point(63, 147);
            this.nudPercentual.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPercentual.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPercentual.Name = "nudPercentual";
            this.nudPercentual.Size = new System.Drawing.Size(71, 20);
            this.nudPercentual.TabIndex = 8;
            this.nudPercentual.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPercentual.ValueChanged += new System.EventHandler(this.nudPercentual_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fator:";
            // 
            // ckbProporcao
            // 
            this.ckbProporcao.AutoSize = true;
            this.ckbProporcao.Location = new System.Drawing.Point(13, 87);
            this.ckbProporcao.Name = "ckbProporcao";
            this.ckbProporcao.Size = new System.Drawing.Size(111, 17);
            this.ckbProporcao.TabIndex = 5;
            this.ckbProporcao.Text = "Manter Proporção";
            this.ckbProporcao.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "%";
            // 
            // frmRedimencionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 219);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckbProporcao);
            this.Controls.Add(this.nudPercentual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbPercentual);
            this.Controls.Add(this.rbExato);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.nudLargura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudAltura);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRedimencionar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redimencionar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRedimencionar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercentual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAltura;
        private System.Windows.Forms.NumericUpDown nudLargura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.RadioButton rbExato;
        private System.Windows.Forms.RadioButton rbPercentual;
        private System.Windows.Forms.NumericUpDown nudPercentual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbProporcao;
        private System.Windows.Forms.Label label4;
    }
}