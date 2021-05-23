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
            this.MoedaOrigemCbx = new System.Windows.Forms.ComboBox();
            this.mo_label = new System.Windows.Forms.Label();
            this.md_label = new System.Windows.Forms.Label();
            this.MoedaDestinoCbx = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.NomeClienteTxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataOpTxb = new System.Windows.Forms.TextBox();
            this.ValorOriginalTxb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ValorConvertidoTxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TaxaCobradaTxb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ValorTaxadoTxb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ConfirmarBt = new System.Windows.Forms.Button();
            this.CancelarBt = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarModificarValroDeConversãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.moeda_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.real = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.euro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MoedaOrigemCbx
            // 
            this.MoedaOrigemCbx.FormattingEnabled = true;
            this.MoedaOrigemCbx.Location = new System.Drawing.Point(44, 196);
            this.MoedaOrigemCbx.Name = "MoedaOrigemCbx";
            this.MoedaOrigemCbx.Size = new System.Drawing.Size(121, 21);
            this.MoedaOrigemCbx.TabIndex = 0;
            this.MoedaOrigemCbx.SelectedIndexChanged += new System.EventHandler(this.UpdateMoedaO);
            // 
            // mo_label
            // 
            this.mo_label.AutoSize = true;
            this.mo_label.Location = new System.Drawing.Point(41, 180);
            this.mo_label.Name = "mo_label";
            this.mo_label.Size = new System.Drawing.Size(89, 13);
            this.mo_label.TabIndex = 1;
            this.mo_label.Text = "Moeda de origem";
            // 
            // md_label
            // 
            this.md_label.AutoSize = true;
            this.md_label.Location = new System.Drawing.Point(196, 180);
            this.md_label.Name = "md_label";
            this.md_label.Size = new System.Drawing.Size(92, 13);
            this.md_label.TabIndex = 3;
            this.md_label.Text = "Moeda de destino";
            // 
            // MoedaDestinoCbx
            // 
            this.MoedaDestinoCbx.FormattingEnabled = true;
            this.MoedaDestinoCbx.Location = new System.Drawing.Point(199, 196);
            this.MoedaDestinoCbx.Name = "MoedaDestinoCbx";
            this.MoedaDestinoCbx.Size = new System.Drawing.Size(121, 21);
            this.MoedaDestinoCbx.TabIndex = 2;
            this.MoedaDestinoCbx.SelectedIndexChanged += new System.EventHandler(this.UpdateMoedaD);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome Do Cliente";
            // 
            // NomeClienteTxb
            // 
            this.NomeClienteTxb.Location = new System.Drawing.Point(44, 65);
            this.NomeClienteTxb.Name = "NomeClienteTxb";
            this.NomeClienteTxb.Size = new System.Drawing.Size(276, 20);
            this.NomeClienteTxb.TabIndex = 5;
            this.NomeClienteTxb.TextChanged += new System.EventHandler(this.UpdateNomeOp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data da operação";
            // 
            // DataOpTxb
            // 
            this.DataOpTxb.Location = new System.Drawing.Point(44, 110);
            this.DataOpTxb.MaxLength = 100;
            this.DataOpTxb.Name = "DataOpTxb";
            this.DataOpTxb.ReadOnly = true;
            this.DataOpTxb.Size = new System.Drawing.Size(121, 20);
            this.DataOpTxb.TabIndex = 7;
            this.DataOpTxb.TextChanged += new System.EventHandler(this.UpdateDataOp);
            // 
            // ValorOriginalTxb
            // 
            this.ValorOriginalTxb.Location = new System.Drawing.Point(44, 240);
            this.ValorOriginalTxb.Name = "ValorOriginalTxb";
            this.ValorOriginalTxb.ReadOnly = true;
            this.ValorOriginalTxb.Size = new System.Drawing.Size(121, 20);
            this.ValorOriginalTxb.TabIndex = 8;
            this.ValorOriginalTxb.TextChanged += new System.EventHandler(this.UpdateValor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valor a ser convertido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor Convertido";
            // 
            // ValorConvertidoTxb
            // 
            this.ValorConvertidoTxb.Location = new System.Drawing.Point(199, 285);
            this.ValorConvertidoTxb.Name = "ValorConvertidoTxb";
            this.ValorConvertidoTxb.ReadOnly = true;
            this.ValorConvertidoTxb.Size = new System.Drawing.Size(121, 20);
            this.ValorConvertidoTxb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Taxa cobrada (10%)";
            // 
            // TaxaCobradaTxb
            // 
            this.TaxaCobradaTxb.Location = new System.Drawing.Point(199, 240);
            this.TaxaCobradaTxb.Name = "TaxaCobradaTxb";
            this.TaxaCobradaTxb.ReadOnly = true;
            this.TaxaCobradaTxb.Size = new System.Drawing.Size(121, 20);
            this.TaxaCobradaTxb.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "+";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Valor original";
            // 
            // ValorTaxadoTxb
            // 
            this.ValorTaxadoTxb.Location = new System.Drawing.Point(44, 285);
            this.ValorTaxadoTxb.Name = "ValorTaxadoTxb";
            this.ValorTaxadoTxb.ReadOnly = true;
            this.ValorTaxadoTxb.Size = new System.Drawing.Size(121, 20);
            this.ValorTaxadoTxb.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "->";
            // 
            // ConfirmarBt
            // 
            this.ConfirmarBt.Location = new System.Drawing.Point(194, 335);
            this.ConfirmarBt.Name = "ConfirmarBt";
            this.ConfirmarBt.Size = new System.Drawing.Size(75, 23);
            this.ConfirmarBt.TabIndex = 18;
            this.ConfirmarBt.Text = "Confirmar";
            this.ConfirmarBt.UseVisualStyleBackColor = true;
            this.ConfirmarBt.Click += new System.EventHandler(this.ConfirmarConversao);
            // 
            // CancelarBt
            // 
            this.CancelarBt.Location = new System.Drawing.Point(90, 335);
            this.CancelarBt.Name = "CancelarBt";
            this.CancelarBt.Size = new System.Drawing.Size(75, 23);
            this.CancelarBt.TabIndex = 19;
            this.CancelarBt.Text = "Cancelar";
            this.CancelarBt.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.NomeClienteTxb);
            this.splitContainer1.Panel1.Controls.Add(this.CancelarBt);
            this.splitContainer1.Panel1.Controls.Add(this.MoedaOrigemCbx);
            this.splitContainer1.Panel1.Controls.Add(this.ConfirmarBt);
            this.splitContainer1.Panel1.Controls.Add(this.mo_label);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.MoedaDestinoCbx);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.md_label);
            this.splitContainer1.Panel1.Controls.Add(this.ValorTaxadoTxb);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.TaxaCobradaTxb);
            this.splitContainer1.Panel1.Controls.Add(this.DataOpTxb);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.ValorOriginalTxb);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.ValorConvertidoTxb);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(987, 383);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Gerenciador de Operações";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarModificarValroDeConversãoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // adicionarModificarValroDeConversãoToolStripMenuItem
            // 
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moeda_nome,
            this.real,
            this.dolar,
            this.euro});
            this.dataGridView1.Location = new System.Drawing.Point(31, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 162);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // moeda_nome
            // 
            this.moeda_nome.HeaderText = "Nome da Moeda";
            this.moeda_nome.Name = "moeda_nome";
            // 
            // real
            // 
            this.real.HeaderText = "Real";
            this.real.Name = "real";
            // 
            // dolar
            // 
            this.dolar.HeaderText = "Dolar";
            this.dolar.Name = "dolar";
            // 
            // euro
            // 
            this.euro.HeaderText = "Euro";
            this.euro.Name = "euro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 407);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MoedaOrigemCbx;
        private System.Windows.Forms.Label mo_label;
        private System.Windows.Forms.Label md_label;
        private System.Windows.Forms.ComboBox MoedaDestinoCbx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeClienteTxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DataOpTxb;
        private System.Windows.Forms.TextBox ValorOriginalTxb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ValorConvertidoTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TaxaCobradaTxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ValorTaxadoTxb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ConfirmarBt;
        private System.Windows.Forms.Button CancelarBt;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarModificarValroDeConversãoToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn moeda_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn real;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn euro;
    }
}

