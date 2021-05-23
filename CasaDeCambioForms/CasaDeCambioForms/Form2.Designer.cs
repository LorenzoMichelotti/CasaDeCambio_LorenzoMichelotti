namespace CasaDeCambioForms
{
    partial class relatorios
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
            this.relatorioTx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // relatorioTx
            // 
            this.relatorioTx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relatorioTx.Location = new System.Drawing.Point(0, 0);
            this.relatorioTx.Multiline = true;
            this.relatorioTx.Name = "relatorioTx";
            this.relatorioTx.ReadOnly = true;
            this.relatorioTx.Size = new System.Drawing.Size(800, 450);
            this.relatorioTx.TabIndex = 0;
            // 
            // relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.relatorioTx);
            this.Name = "relatorios";
            this.Text = "Relatórios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox relatorioTx;
    }
}