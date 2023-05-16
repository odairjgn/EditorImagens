namespace Editor_De_Imagens.Formularios.Ferramentas
{
    partial class frmPixelizar
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
            this.nudFator = new System.Windows.Forms.NumericUpDown();
            this.btOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFator)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fator:";
            // 
            // nudFator
            // 
            this.nudFator.Location = new System.Drawing.Point(55, 10);
            this.nudFator.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFator.Name = "nudFator";
            this.nudFator.Size = new System.Drawing.Size(64, 20);
            this.nudFator.TabIndex = 1;
            this.nudFator.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(126, 9);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // frmPixelizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 41);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.nudFator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPixelizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixelizar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPixelizar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudFator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFator;
        private System.Windows.Forms.Button btOk;
    }
}