namespace Editor_De_Imagens.Formularios.Tarefas
{
    partial class frmFragmentar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbWait = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFormato = new System.Windows.Forms.ComboBox();
            this.lbTamano = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.nudAltura = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudLargura = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargura)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbImg.BackgroundImage = global::Editor_De_Imagens.Properties.Resources.transparencia;
            this.pbImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImg.Location = new System.Drawing.Point(118, 0);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(624, 463);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 14;
            this.pbImg.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbWait);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbFormato);
            this.panel1.Controls.Add(this.lbTamano);
            this.panel1.Controls.Add(this.btOK);
            this.panel1.Controls.Add(this.nudAltura);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nudLargura);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 463);
            this.panel1.TabIndex = 13;
            // 
            // pbWait
            // 
            this.pbWait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbWait.Image = global::Editor_De_Imagens.Properties.Resources.loading;
            this.pbWait.Location = new System.Drawing.Point(9, 296);
            this.pbWait.Name = "pbWait";
            this.pbWait.Size = new System.Drawing.Size(100, 100);
            this.pbWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWait.TabIndex = 12;
            this.pbWait.TabStop = false;
            this.pbWait.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Formato";
            // 
            // cbFormato
            // 
            this.cbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormato.FormattingEnabled = true;
            this.cbFormato.Items.AddRange(new object[] {
            ".PNG",
            ".JPG",
            ".GIF",
            ".BMP"});
            this.cbFormato.Location = new System.Drawing.Point(7, 133);
            this.cbFormato.Name = "cbFormato";
            this.cbFormato.Size = new System.Drawing.Size(95, 21);
            this.cbFormato.TabIndex = 10;
            // 
            // lbTamano
            // 
            this.lbTamano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTamano.AutoSize = true;
            this.lbTamano.Location = new System.Drawing.Point(6, 413);
            this.lbTamano.Name = "lbTamano";
            this.lbTamano.Size = new System.Drawing.Size(16, 13);
            this.lbTamano.TabIndex = 8;
            this.lbTamano.Text = "...";
            // 
            // btOK
            // 
            this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btOK.Location = new System.Drawing.Point(6, 429);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(106, 23);
            this.btOK.TabIndex = 9;
            this.btOK.Text = "&OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // nudAltura
            // 
            this.nudAltura.Location = new System.Drawing.Point(7, 28);
            this.nudAltura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAltura.Name = "nudAltura";
            this.nudAltura.Size = new System.Drawing.Size(95, 20);
            this.nudAltura.TabIndex = 1;
            this.nudAltura.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAltura.ValueChanged += new System.EventHandler(this.nudAltura_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Altura";
            // 
            // nudLargura
            // 
            this.nudLargura.Location = new System.Drawing.Point(7, 76);
            this.nudLargura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLargura.Name = "nudLargura";
            this.nudLargura.Size = new System.Drawing.Size(95, 20);
            this.nudLargura.TabIndex = 3;
            this.nudLargura.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLargura.ValueChanged += new System.EventHandler(this.nudLargura_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Largura";
            // 
            // frmFragmentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 463);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFragmentar";
            this.Text = "Fragmentar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFragmentar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTamano;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.NumericUpDown nudAltura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudLargura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFormato;
        private System.Windows.Forms.PictureBox pbWait;
    }
}