namespace Editor_De_Imagens.Formularios.Ferramentas
{
    partial class frmInserirImagem
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
            this.btBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.btInserir = new System.Windows.Forms.Button();
            this.ofdAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(12, 64);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(85, 23);
            this.btBuscar.TabIndex = 4;
            this.btBuscar.Text = "&Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "X";
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(27, 12);
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(70, 20);
            this.nudX.TabIndex = 1;
            this.nudX.ValueChanged += new System.EventHandler(this.nudX_ValueChanged);
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(27, 38);
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(70, 20);
            this.nudY.TabIndex = 3;
            this.nudY.ValueChanged += new System.EventHandler(this.nudY_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // pbImg
            // 
            this.pbImg.BackgroundImage = global::Editor_De_Imagens.Properties.Resources.transparencia;
            this.pbImg.Location = new System.Drawing.Point(112, 12);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(344, 222);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 7;
            this.pbImg.TabStop = false;
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(12, 211);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(85, 23);
            this.btInserir.TabIndex = 5;
            this.btInserir.Text = "&Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // ofdAbrir
            // 
            this.ofdAbrir.Filter = "Imagens|*.jpg;*.gif;*.png;*.bmp";
            // 
            // frmInserirImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 246);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.pbImg);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInserirImagem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Inserir Imagem";
            this.Load += new System.EventHandler(this.frmInserirImagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.OpenFileDialog ofdAbrir;
    }
}