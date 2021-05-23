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
    public partial class Form1 : Form
    {
        SortedDictionary<int, string> moedas = new SortedDictionary<int, string>
        {
            {0, "REAL"},
            {1, "DOLAR"},
            {2, "EURO"}
        };

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < moedas.Count;i++)
            {
                MoedaOrigemCbx.Items.Add(moedas[i]);
                MoedaDestinoCbx.Items.Add(moedas[i]);
            }
            MoedaOrigemCbx.SelectedIndex = 0;
            MoedaDestinoCbx.SelectedIndex = 1;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adicionarModificarValroDeConversãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        float valor = 0;
        float taxa = 0.10f;
        string moedaOrigem;
        string moedaDestino;

        //CONVERTER MOEDA
        private void ConfirmarConversao(object sender, EventArgs e)
        {
            Converter();
        }

        public void Converter()
        {
            string valorInicial = "";
            string valorConvertido = "";
            switch (moedaOrigem)
            {
                case "REAL":
                    valorInicial = string.Format("{0:0.00}", (valor + valor * taxa) + " BRL");
                    switch (moedaDestino)
                    {
                        //REAL -> DOLAR
                        case "DOLAR":
                            valorConvertido = string.Format("{0:0.00}", valor * 0.19f) + " USD";
                            break;
                        //REAL -> EURO
                        case "EURO":
                            valorConvertido = string.Format("{0:0.00}", valor * 0.15f) + " EUR";
                            break;
                    }
                    break;
                case "DOLAR":
                    valorInicial = string.Format("{0:0.00}", valor) + " USD";
                    switch (moedaDestino)
                    {
                        //DOLAR -> REAL
                        case "REAL":
                            valorConvertido = string.Format("{0:0.00}", valor * 5.37f) + " BRL";
                            break;
                        //DOLAR -> EURO
                        case "EURO":
                            valorConvertido = string.Format("{0:0.00}", valor * 0.82f) + " EUR";
                            break;
                    }
                    break;
                case "EURO":
                    valorInicial = string.Format("{0:0.00}", valor) + " EUR";
                    switch (moedaDestino)
                    {
                        //EURO -> DOLAR
                        case "DOLAR":
                            valorConvertido = string.Format("{0:0.00}", valor * 1.22f) + " USD";
                            break;
                        //EURO -> REAL
                        case "REAL":
                            valorConvertido = string.Format("{0:0.00}", valor * 6.54f) + " BRL";
                            break;
                    }
                    break;

            }
            string[] valoresInicialFinal = { valorInicial, valorConvertido };
            TaxaCobradaTxb.Text = string.Format("{0:0.00}", valor * taxa);
            ValorTaxadoTxb.Text = valorInicial;
            ValorConvertidoTxb.Text = valorConvertido;
        }

        private void UpdateValor(object sender, EventArgs e)
        {
            float _x = 0;
            bool confirm = float.TryParse(ValorOriginalTxb.Text, out _x);
            if (confirm)
            {
                valor = _x;
            }
            if (ValorOriginalTxb.Text == null) { ValorOriginalTxb.Text = "0"; }
            if (valor > 1000000) { valor = 1000000; MessageBox.Show("Valor máximo de câmbio: 9.999.999"); }

            Converter();
        }

        private void UpdateMoedaO(object sender, EventArgs e)
        {
            moedaOrigem = moedas[MoedaOrigemCbx.SelectedIndex];
        }

        private void UpdateMoedaD(object sender, EventArgs e)
        {
            moedaDestino = moedas[MoedaDestinoCbx.SelectedIndex];
        }

        bool nameNotEmpty = false;
        bool dateNotEmpty = false;
        private void UpdateDataOp(object sender, EventArgs e)
        {

        }

        private void UpdateNomeOp(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NomeClienteTxb.Text))
            {
                nameNotEmpty = false;
                ValorOriginalTxb.ReadOnly = true;
            } else {
                nameNotEmpty = true;
                if (nameNotEmpty) { ValorOriginalTxb.ReadOnly = false; }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataOpTxb.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
