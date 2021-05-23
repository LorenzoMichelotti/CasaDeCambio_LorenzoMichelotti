using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaDeCambioForms
{
    public partial class EditorDeConversão : Form
    {
        public EditorDeConversão()
        {
            InitializeComponent();
        }

        private void conversaoMoedasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.conversaoMoedasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_ConversãoInfo);

        }

        private void EditorDeConversão_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_ConversãoInfo.ConversaoMoedas' table. You can move, or remove it, as needed.
            this.conversaoMoedasTableAdapter.Fill(this.dataSet_ConversãoInfo.ConversaoMoedas);

        }
    }
}
