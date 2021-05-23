namespace CasaDeCambioForms
{
    partial class EditorDeConversão
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorDeConversão));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nome_da_moedaLabel;
            System.Windows.Forms.Label rEALLabel;
            System.Windows.Forms.Label dOLARLabel;
            System.Windows.Forms.Label eUROLabel;
            this.dataSet_ConversãoInfo = new CasaDeCambioForms.DataSet_ConversãoInfo();
            this.conversaoMoedasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conversaoMoedasTableAdapter = new CasaDeCambioForms.DataSet_ConversãoInfoTableAdapters.ConversaoMoedasTableAdapter();
            this.tableAdapterManager = new CasaDeCambioForms.DataSet_ConversãoInfoTableAdapters.TableAdapterManager();
            this.conversaoMoedasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.conversaoMoedasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nome_da_moedaTextBox = new System.Windows.Forms.TextBox();
            this.rEALTextBox = new System.Windows.Forms.TextBox();
            this.dOLARTextBox = new System.Windows.Forms.TextBox();
            this.eUROTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            nome_da_moedaLabel = new System.Windows.Forms.Label();
            rEALLabel = new System.Windows.Forms.Label();
            dOLARLabel = new System.Windows.Forms.Label();
            eUROLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ConversãoInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversaoMoedasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversaoMoedasBindingNavigator)).BeginInit();
            this.conversaoMoedasBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSet_ConversãoInfo
            // 
            this.dataSet_ConversãoInfo.DataSetName = "DataSet_ConversãoInfo";
            this.dataSet_ConversãoInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conversaoMoedasBindingSource
            // 
            this.conversaoMoedasBindingSource.DataMember = "ConversaoMoedas";
            this.conversaoMoedasBindingSource.DataSource = this.dataSet_ConversãoInfo;
            // 
            // conversaoMoedasTableAdapter
            // 
            this.conversaoMoedasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConversaoMoedasTableAdapter = this.conversaoMoedasTableAdapter;
            this.tableAdapterManager.UpdateOrder = CasaDeCambioForms.DataSet_ConversãoInfoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // conversaoMoedasBindingNavigator
            // 
            this.conversaoMoedasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.conversaoMoedasBindingNavigator.BindingSource = this.conversaoMoedasBindingSource;
            this.conversaoMoedasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.conversaoMoedasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.conversaoMoedasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.conversaoMoedasBindingNavigatorSaveItem});
            this.conversaoMoedasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.conversaoMoedasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.conversaoMoedasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.conversaoMoedasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.conversaoMoedasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.conversaoMoedasBindingNavigator.Name = "conversaoMoedasBindingNavigator";
            this.conversaoMoedasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.conversaoMoedasBindingNavigator.Size = new System.Drawing.Size(340, 25);
            this.conversaoMoedasBindingNavigator.TabIndex = 0;
            this.conversaoMoedasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // conversaoMoedasBindingNavigatorSaveItem
            // 
            this.conversaoMoedasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.conversaoMoedasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("conversaoMoedasBindingNavigatorSaveItem.Image")));
            this.conversaoMoedasBindingNavigatorSaveItem.Name = "conversaoMoedasBindingNavigatorSaveItem";
            this.conversaoMoedasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.conversaoMoedasBindingNavigatorSaveItem.Text = "Save Data";
            this.conversaoMoedasBindingNavigatorSaveItem.Click += new System.EventHandler(this.conversaoMoedasBindingNavigatorSaveItem_Click);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(42, 54);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conversaoMoedasBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(136, 51);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // nome_da_moedaLabel
            // 
            nome_da_moedaLabel.AutoSize = true;
            nome_da_moedaLabel.Location = new System.Drawing.Point(42, 80);
            nome_da_moedaLabel.Name = "nome_da_moedaLabel";
            nome_da_moedaLabel.Size = new System.Drawing.Size(88, 13);
            nome_da_moedaLabel.TabIndex = 3;
            nome_da_moedaLabel.Text = "Nome da moeda:";
            // 
            // nome_da_moedaTextBox
            // 
            this.nome_da_moedaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conversaoMoedasBindingSource, "Nome da moeda", true));
            this.nome_da_moedaTextBox.Location = new System.Drawing.Point(136, 77);
            this.nome_da_moedaTextBox.Name = "nome_da_moedaTextBox";
            this.nome_da_moedaTextBox.Size = new System.Drawing.Size(100, 20);
            this.nome_da_moedaTextBox.TabIndex = 4;
            // 
            // rEALLabel
            // 
            rEALLabel.AutoSize = true;
            rEALLabel.Location = new System.Drawing.Point(42, 106);
            rEALLabel.Name = "rEALLabel";
            rEALLabel.Size = new System.Drawing.Size(38, 13);
            rEALLabel.TabIndex = 5;
            rEALLabel.Text = "REAL:";
            // 
            // rEALTextBox
            // 
            this.rEALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conversaoMoedasBindingSource, "REAL", true));
            this.rEALTextBox.Location = new System.Drawing.Point(136, 103);
            this.rEALTextBox.Name = "rEALTextBox";
            this.rEALTextBox.Size = new System.Drawing.Size(100, 20);
            this.rEALTextBox.TabIndex = 6;
            // 
            // dOLARLabel
            // 
            dOLARLabel.AutoSize = true;
            dOLARLabel.Location = new System.Drawing.Point(42, 132);
            dOLARLabel.Name = "dOLARLabel";
            dOLARLabel.Size = new System.Drawing.Size(47, 13);
            dOLARLabel.TabIndex = 7;
            dOLARLabel.Text = "DOLAR:";
            // 
            // dOLARTextBox
            // 
            this.dOLARTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conversaoMoedasBindingSource, "DOLAR", true));
            this.dOLARTextBox.Location = new System.Drawing.Point(136, 129);
            this.dOLARTextBox.Name = "dOLARTextBox";
            this.dOLARTextBox.Size = new System.Drawing.Size(100, 20);
            this.dOLARTextBox.TabIndex = 8;
            // 
            // eUROLabel
            // 
            eUROLabel.AutoSize = true;
            eUROLabel.Location = new System.Drawing.Point(42, 158);
            eUROLabel.Name = "eUROLabel";
            eUROLabel.Size = new System.Drawing.Size(41, 13);
            eUROLabel.TabIndex = 9;
            eUROLabel.Text = "EURO:";
            // 
            // eUROTextBox
            // 
            this.eUROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conversaoMoedasBindingSource, "EURO", true));
            this.eUROTextBox.Location = new System.Drawing.Point(136, 155);
            this.eUROTextBox.Name = "eUROTextBox";
            this.eUROTextBox.Size = new System.Drawing.Size(100, 20);
            this.eUROTextBox.TabIndex = 10;
            // 
            // EditorDeConversão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 214);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nome_da_moedaLabel);
            this.Controls.Add(this.nome_da_moedaTextBox);
            this.Controls.Add(rEALLabel);
            this.Controls.Add(this.rEALTextBox);
            this.Controls.Add(dOLARLabel);
            this.Controls.Add(this.dOLARTextBox);
            this.Controls.Add(eUROLabel);
            this.Controls.Add(this.eUROTextBox);
            this.Controls.Add(this.conversaoMoedasBindingNavigator);
            this.MinimumSize = new System.Drawing.Size(356, 200);
            this.Name = "EditorDeConversão";
            this.Text = "EditorDeConversão";
            this.Load += new System.EventHandler(this.EditorDeConversão_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_ConversãoInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversaoMoedasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversaoMoedasBindingNavigator)).EndInit();
            this.conversaoMoedasBindingNavigator.ResumeLayout(false);
            this.conversaoMoedasBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet_ConversãoInfo dataSet_ConversãoInfo;
        private System.Windows.Forms.BindingSource conversaoMoedasBindingSource;
        private DataSet_ConversãoInfoTableAdapters.ConversaoMoedasTableAdapter conversaoMoedasTableAdapter;
        private DataSet_ConversãoInfoTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator conversaoMoedasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton conversaoMoedasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nome_da_moedaTextBox;
        private System.Windows.Forms.TextBox rEALTextBox;
        private System.Windows.Forms.TextBox dOLARTextBox;
        private System.Windows.Forms.TextBox eUROTextBox;
    }
}