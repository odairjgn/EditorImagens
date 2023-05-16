namespace Editor_De_Imagens.Formularios.Ferramentas
{
    partial class frmBrilho
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
            this.lbValor = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.trbValor = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trbValor)).BeginInit();
            this.SuspendLayout();
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(24, 68);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(13, 13);
            this.lbValor.TabIndex = 5;
            this.lbValor.Text = "0";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(527, 63);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "&OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // trbValor
            // 
            this.trbValor.Location = new System.Drawing.Point(12, 12);
            this.trbValor.Maximum = 255;
            this.trbValor.Minimum = -255;
            this.trbValor.Name = "trbValor";
            this.trbValor.Size = new System.Drawing.Size(590, 45);
            this.trbValor.TabIndex = 3;
            this.trbValor.Scroll += new System.EventHandler(this.trbValor_Scroll);
            // 
            // frmBrilho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 98);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.trbValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBrilho";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brilho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBrilho_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trbValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TrackBar trbValor;
    }
}