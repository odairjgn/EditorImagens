namespace Editor_De_Imagens.Formularios.Ferramentas
{
    partial class frmGamma
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
            this.trbR = new System.Windows.Forms.TrackBar();
            this.lbR = new System.Windows.Forms.Label();
            this.lbG = new System.Windows.Forms.Label();
            this.trbG = new System.Windows.Forms.TrackBar();
            this.lbB = new System.Windows.Forms.Label();
            this.trbB = new System.Windows.Forms.TrackBar();
            this.btOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbB)).BeginInit();
            this.SuspendLayout();
            // 
            // trbR
            // 
            this.trbR.Location = new System.Drawing.Point(12, 12);
            this.trbR.Maximum = 256;
            this.trbR.Minimum = 1;
            this.trbR.Name = "trbR";
            this.trbR.Size = new System.Drawing.Size(434, 45);
            this.trbR.TabIndex = 0;
            this.trbR.Value = 1;
            this.trbR.Scroll += new System.EventHandler(this.trbR_Scroll);
            // 
            // lbR
            // 
            this.lbR.AutoSize = true;
            this.lbR.ForeColor = System.Drawing.Color.Red;
            this.lbR.Location = new System.Drawing.Point(452, 12);
            this.lbR.Name = "lbR";
            this.lbR.Size = new System.Drawing.Size(27, 13);
            this.lbR.TabIndex = 1;
            this.lbR.Text = "R: 0";
            // 
            // lbG
            // 
            this.lbG.AutoSize = true;
            this.lbG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbG.Location = new System.Drawing.Point(452, 63);
            this.lbG.Name = "lbG";
            this.lbG.Size = new System.Drawing.Size(27, 13);
            this.lbG.TabIndex = 3;
            this.lbG.Text = "G: 0";
            // 
            // trbG
            // 
            this.trbG.Location = new System.Drawing.Point(12, 63);
            this.trbG.Maximum = 256;
            this.trbG.Minimum = 1;
            this.trbG.Name = "trbG";
            this.trbG.Size = new System.Drawing.Size(434, 45);
            this.trbG.TabIndex = 2;
            this.trbG.Value = 1;
            this.trbG.Scroll += new System.EventHandler(this.trbG_Scroll);
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.ForeColor = System.Drawing.Color.Blue;
            this.lbB.Location = new System.Drawing.Point(452, 114);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(26, 13);
            this.lbB.TabIndex = 5;
            this.lbB.Text = "B: 0";
            // 
            // trbB
            // 
            this.trbB.Location = new System.Drawing.Point(12, 114);
            this.trbB.Maximum = 256;
            this.trbB.Minimum = 1;
            this.trbB.Name = "trbB";
            this.trbB.Size = new System.Drawing.Size(434, 45);
            this.trbB.TabIndex = 4;
            this.trbB.Value = 1;
            this.trbB.Scroll += new System.EventHandler(this.trbB_Scroll);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(422, 179);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 6;
            this.btOK.Text = "&OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // frmGamma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 214);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.trbB);
            this.Controls.Add(this.lbG);
            this.Controls.Add(this.trbG);
            this.Controls.Add(this.lbR);
            this.Controls.Add(this.trbR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGamma";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gamma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGamma_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbR;
        private System.Windows.Forms.Label lbR;
        private System.Windows.Forms.Label lbG;
        private System.Windows.Forms.TrackBar trbG;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TrackBar trbB;
        private System.Windows.Forms.Button btOK;
    }
}