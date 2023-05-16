namespace Editor_De_Imagens.Formularios.Ferramentas
{
    partial class frmGaleriaFiltros
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
            this.pnFiltros = new System.Windows.Forms.FlowLayoutPanel();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // pnFiltros
            // 
            this.pnFiltros.AutoScroll = true;
            this.pnFiltros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFiltros.Location = new System.Drawing.Point(0, 0);
            this.pnFiltros.Name = "pnFiltros";
            this.pnFiltros.Size = new System.Drawing.Size(761, 449);
            this.pnFiltros.TabIndex = 0;
            // 
            // tt
            // 
            this.tt.IsBalloon = true;
            this.tt.ShowAlways = true;
            // 
            // frmGaleriaFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 449);
            this.Controls.Add(this.pnFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGaleriaFiltros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtros";
            this.Load += new System.EventHandler(this.frmGaleriaFiltros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnFiltros;
        private System.Windows.Forms.ToolTip tt;
    }
}