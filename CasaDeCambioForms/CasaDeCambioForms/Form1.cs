using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

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
            for (int i = 0; i < moedas.Count; i++)
            {
                MoedaOrigemCbx.Items.Add(moedas[i]);
                MoedaDestinoCbx.Items.Add(moedas[i]);
            }
            MoedaOrigemCbx.SelectedIndex = 0;
            MoedaDestinoCbx.SelectedIndex = 1;

            //GetInfoFromDataBase();
        }

        public void GetInfoFromDataBase()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-4IGK14V\\SQLEXPRESS;Initial Catalog=CasaDeCambio;Integrated Security=True");
            con.Open();

            //get valor de rows na tabela
            SqlCommand getrowcount = new SqlCommand("SELECT COUNT(*) FROM ConversaoMoedas", con);
            Int32 count = (Int32)getrowcount.ExecuteScalar();

            con.Close();
            //NOME DAS MOEDAS
            string allMoedaNomes = "";
            for (int i = 1; i < count+1; i--)
            {
                con.Open();
                SqlCommand getCollumn = new SqlCommand("SELECT nome_moeda from ConversaoMoedas where ID =@ID", con);
                getCollumn.Parameters.AddWithValue("@NOME", i);
                getCollumn.Parameters.AddWithValue("@ID", i);

                SqlDataReader nameReader = getCollumn.ExecuteReader();
                while (nameReader.Read())
                {
                    //testtxb.Text = nameReader.GetString(0);
                    //Console.WriteLine("this is the current name of nome_moeda"+ nameReader.GetString(0));
                    //string.Concat(allMoedaNomes, ", ", nameReader.GetString(i));
                }
                con.Close();
            }
            //testtxb.Text = allMoedaNomes;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT REAL from ConversaoMoedas where ID =@ID", con);
            cmd.Parameters.AddWithValue("@ID", 0);
            SqlDataReader idReader = cmd.ExecuteReader();
            //while(idReader.Read())
            //{
            //    //VALOR DA CONVERSAO
            //    //testtxb.Text = (idReader.GetDouble(0)).ToString();
            //    for (int i = 0; i<count;i++)
            //    {

            //    }
            //}
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //ABRIR TABELA DE CONVERSOES
        private void adicionarModificarValroDeConversãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorDeConversão form2 = new EditorDeConversão();
            form2.Show();
        }

        float valor = 0;
        float taxa = 0.10f;
        string moedaOrigem;
        string moedaDestino;

        //EXECUTAR CAMBIO DE MOEDA
        private void ConfirmarConversao(object sender, EventArgs e)
        {
            Converter();
            salvarRelatorio();
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

            if (!String.IsNullOrEmpty(ValorOriginalTxb.Text)) { ConfirmarBt.Enabled = true; }

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
                ConfirmarBt.Enabled = false;
            } else {
                nameNotEmpty = true;
                if (nameNotEmpty) { ValorOriginalTxb.ReadOnly = false; if (!String.IsNullOrEmpty(ValorOriginalTxb.Text)) { ConfirmarBt.Enabled = true; } }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataOpTxb.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void conversaoMoedasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ShowRelatorios(object sender, EventArgs e)
        {

        }

        //SALVAR
        public string relatorio_txt = "";
        public async Task salvarRelatorio()
        {
            string _nome = NomeClienteTxb.Text;
            string _datahora = DataOpTxb.Text;
            string _valorConverter = ValorTaxadoTxb.Text;
            string _valorTaxa = TaxaCobradaTxb.Text;
            string _valorConvertido = ValorConvertidoTxb.Text;

            string insert = "\r\nnome: " + _nome + ", data: " + _datahora + " valor+taxa: " + _valorConverter + " (taxa = " + _valorTaxa + "), valor convertido: " + _valorConvertido + "\r\n";
            
            relatorio_txt += insert;
            relatorios relatorioJanela = new relatorios();
            relatorioJanela.Show();
            relatorioJanela.relatorioTx.Text = relatorio_txt;

            //nao ta funcionando :^(
            StreamWriter file = new StreamWriter("RelatoriodeCambio.txt", true);
            await Task.Run(() => file.WriteLineAsync(relatorio_txt));
        }
    }
}
