namespace CasaDeCambioForms
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarModificarValroDeConversãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ValorConvertidoTxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ValorOriginalTxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DataOpTxb = new System.Windows.Forms.TextBox();
            this.TaxaCobradaTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValorTaxadoTxb = new System.Windows.Forms.TextBox();
            this.md_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MoedaDestinoCbx = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mo_label = new System.Windows.Forms.Label();
            this.ConfirmarBt = new System.Windows.Forms.Button();
            this.MoedaOrigemCbx = new System.Windows.Forms.ComboBox();
            this.CancelarBt = new System.Windows.Forms.Button();
            this.NomeClienteTxb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarModificarValroDeConversãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // adicionarModificarValroDeConversãoToolStripMenuItem
            // 
            this.adicionarModificarValroDeConversãoToolStripMenuItem.Enabled = false;
            this.adicionarModificarValroDeConversãoToolStripMenuItem.Name = "adicionarModificarValroDeConversãoToolStripMenuItem";
            this.adicionarModificarValroDeConversãoToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.adicionarModificarValroDeConversãoToolStripMenuItem.Text = "Adicionar/Modificar Valor de conversão";
            this.adicionarModificarValroDeConversãoToolStripMenuItem.Click += new System.EventHandler(this.adicionarModificarValroDeConversãoToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ValorConvertidoTxb
            // 
            this.ValorConvertidoTxb.Location = new System.Drawing.Point(181, 307);
            this.ValorConvertidoTxb.Name = "ValorConvertidoTxb";
            this.ValorConvertidoTxb.ReadOnly = true;
            this.ValorConvertidoTxb.Size = new System.Drawing.Size(121, 20);
            this.ValorConvertidoTxb.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor a ser convertido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor Convertido";
            // 
            // ValorOriginalTxb
            // 
            this.ValorOriginalTxb.Location = new System.Drawing.Point(26, 262);
            this.ValorOriginalTxb.Name = "ValorOriginalTxb";
            this.ValorOriginalTxb.ReadOnly = true;
            this.ValorOriginalTxb.Size = new System.Drawing.Size(121, 20);
            this.ValorOriginalTxb.TabIndex = 8;
            this.ValorOriginalTxb.TextChanged += new System.EventHandler(this.UpdateValor);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Taxa cobrada (10%)";
            // 
            // DataOpTxb
            // 
            this.DataOpTxb.Location = new System.Drawing.Point(26, 132);
            this.DataOpTxb.MaxLength = 100;
            this.DataOpTxb.Name = "DataOpTxb";
            this.DataOpTxb.ReadOnly = true;
            this.DataOpTxb.Size = new System.Drawing.Size(121, 20);
            this.DataOpTxb.TabIndex = 7;
            this.DataOpTxb.TextChanged += new System.EventHandler(this.UpdateDataOp);
            // 
            // TaxaCobradaTxb
            // 
            this.TaxaCobradaTxb.Location = new System.Drawing.Point(181, 262);
            this.TaxaCobradaTxb.Name = "TaxaCobradaTxb";
            this.TaxaCobradaTxb.ReadOnly = true;
            this.TaxaCobradaTxb.Size = new System.Drawing.Size(121, 20);
            this.TaxaCobradaTxb.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data da operação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome Do Cliente";
            // 
            // ValorTaxadoTxb
            // 
            this.ValorTaxadoTxb.Location = new System.Drawing.Point(26, 307);
            this.ValorTaxadoTxb.Name = "ValorTaxadoTxb";
            this.ValorTaxadoTxb.ReadOnly = true;
            this.ValorTaxadoTxb.Size = new System.Drawing.Size(121, 20);
            this.ValorTaxadoTxb.TabIndex = 15;
            // 
            // md_label
            // 
            this.md_label.AutoSize = true;
            this.md_label.Location = new System.Drawing.Point(178, 202);
            this.md_label.Name = "md_label";
            this.md_label.Size = new System.Drawing.Size(92, 13);
            this.md_label.TabIndex = 3;
            this.md_label.Text = "Moeda de destino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Valor original";
            // 
            // MoedaDestinoCbx
            // 
            this.MoedaDestinoCbx.FormattingEnabled = true;
            this.MoedaDestinoCbx.Location = new System.Drawing.Point(181, 218);
            this.MoedaDestinoCbx.Name = "MoedaDestinoCbx";
            this.MoedaDestinoCbx.Size = new System.Drawing.Size(121, 21);
            this.MoedaDestinoCbx.TabIndex = 2;
            this.MoedaDestinoCbx.SelectedIndexChanged += new System.EventHandler(this.UpdateMoedaD);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "->";
            // 
            // mo_label
            // 
            this.mo_label.AutoSize = true;
            this.mo_label.Location = new System.Drawing.Point(23, 202);
            this.mo_label.Name = "mo_label";
            this.mo_label.Size = new System.Drawing.Size(89, 13);
            this.mo_label.TabIndex = 1;
            this.mo_label.Text = "Moeda de origem";
            // 
            // ConfirmarBt
            // 
            this.ConfirmarBt.Enabled = false;
            this.ConfirmarBt.Location = new System.Drawing.Point(176, 357);
            this.ConfirmarBt.Name = "ConfirmarBt";
            this.ConfirmarBt.Size = new System.Drawing.Size(75, 23);
            this.ConfirmarBt.TabIndex = 18;
            this.ConfirmarBt.Text = "Confirmar";
            this.ConfirmarBt.UseVisualStyleBackColor = true;
            this.ConfirmarBt.Click += new System.EventHandler(this.ConfirmarConversao);
            // 
            // MoedaOrigemCbx
            // 
            this.MoedaOrigemCbx.FormattingEnabled = true;
            this.MoedaOrigemCbx.Location = new System.Drawing.Point(26, 218);
            this.MoedaOrigemCbx.Name = "MoedaOrigemCbx";
            this.MoedaOrigemCbx.Size = new System.Drawing.Size(121, 21);
            this.MoedaOrigemCbx.TabIndex = 0;
            this.MoedaOrigemCbx.SelectedIndexChanged += new System.EventHandler(this.UpdateMoedaO);
            // 
            // CancelarBt
            // 
            this.CancelarBt.Location = new System.Drawing.Point(72, 357);
            this.CancelarBt.Name = "CancelarBt";
            this.CancelarBt.Size = new System.Drawing.Size(75, 23);
            this.CancelarBt.TabIndex = 19;
            this.CancelarBt.Text = "Cancelar";
            this.CancelarBt.UseVisualStyleBackColor = true;
            // 
            // NomeClienteTxb
            // 
            this.NomeClienteTxb.Location = new System.Drawing.Point(26, 87);
            this.NomeClienteTxb.Name = "NomeClienteTxb";
            this.NomeClienteTxb.Size = new System.Drawing.Size(276, 20);
            this.NomeClienteTxb.TabIndex = 5;
            this.NomeClienteTxb.TextChanged += new System.EventHandler(this.UpdateNomeOp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Gerenciador de Operações";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.ShowRelatorios);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 407);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NomeClienteTxb);
            this.Controls.Add(this.CancelarBt);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MoedaOrigemCbx);
            this.Controls.Add(this.ValorConvertidoTxb);
            this.Controls.Add(this.ConfirmarBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mo_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ValorOriginalTxb);
            this.Controls.Add(this.MoedaDestinoCbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DataOpTxb);
            this.Controls.Add(this.md_label);
            this.Controls.Add(this.TaxaCobradaTxb);
            this.Controls.Add(this.ValorTaxadoTxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(356, 446);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarModificarValroDeConversãoToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NomeClienteTxb;
        private System.Windows.Forms.Button CancelarBt;
        private System.Windows.Forms.ComboBox MoedaOrigemCbx;
        private System.Windows.Forms.TextBox ValorConvertidoTxb;
        private System.Windows.Forms.Button ConfirmarBt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mo_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ValorOriginalTxb;
        private System.Windows.Forms.ComboBox MoedaDestinoCbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DataOpTxb;
        private System.Windows.Forms.Label md_label;
        private System.Windows.Forms.TextBox TaxaCobradaTxb;
        private System.Windows.Forms.TextBox ValorTaxadoTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
    }
}

