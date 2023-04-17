using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diversos;

namespace projetoCreditoDebito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbxCreditoDebito.SelectedIndex = 0;

            AtualizarLista();
            LimparGrid();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void AtualizarLista()
        {
            Conecta conecta = new Conecta();

            lstClientes.DisplayMember = "nomeCliente";
            lstClientes.ValueMember = "id";

            conecta.strSQL = "SELECT id, nomeCliente FROM clientes;";
            lstClientes.DataSource = conecta.BuscarDados();
        }

        public void LimparGrid()
        {
            dgvDevedores.DataSource = null;
            dgvDevedores.Columns.Clear();
            dgvDevedores.Rows.Clear();
            txtTotalCred.Text = null;
            txtTotalDeb.Text = null;
        }

        public void CalcularSaldo()
        {

            if (!dgvDevedores.Columns.Contains("saldo"))
            {
                dgvDevedores.Columns.Add("saldo", "saldo");
            }
            FormatarGrid formatador = new FormatarGrid();
            formatador.GridFormatar(dgvDevedores);

            double saldo = 0;
            double credito;
            double debito;
            double totalDeb = 0;
            double totalCred = 0;

            for (int i = 0; i < dgvDevedores.Rows.Count; i++)
            {
                bool bDeb = double.TryParse(Convert.ToString(dgvDevedores.Rows[i].Cells[3].Value), out debito);
                if (!bDeb) { debito = 0; }

                bool bCred = double.TryParse(Convert.ToString(dgvDevedores.Rows[i].Cells[4].Value), out credito);
                if (!bCred) { credito = 0; }

                saldo = (saldo + credito) - debito;
                dgvDevedores.Rows[i].Cells[5].Value = saldo;

                totalDeb += debito;
                totalCred += credito;
            }

            txtTotalDeb.Text = "-" + Convert.ToString(totalDeb) + " €";
            txtTotalCred.Text = "+" + Convert.ToString(totalCred) + " €";
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            Conecta conecta = new Conecta();

            LimparGrid();

            conecta.strSQL = "SELECT id, data, descricao, debito, credito " +
                "FROM movimentos WHERE clienteId = '" + lstClientes.SelectedValue + "'";

            dgvDevedores.DataSource = conecta.BuscarDados();

            CalcularSaldo();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            Conecta conecta = new Conecta();

            lstClientes.DisplayMember = "nomeCliente";
            lstClientes.ValueMember = "id";

            if (txtPesquisa.Text == "")
            {
                conecta.strSQL = "SELECT id, nomeCliente FROM clientes;";
            }
            else
            {
                conecta.strSQL = "SELECT id, nomeCliente FROM clientes WHERE nomeCliente LIKE '" + txtPesquisa.Text + "%';";
            }

            lstClientes.DataSource = conecta.BuscarDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Conecta conecta = new Conecta();
            string opcao = "";
            string opcao1 = "";

            if (cbxCreditoDebito.SelectedIndex == 0)
            {
                opcao = "credito";
                opcao1 = "crédito: ";
            }

            if (cbxCreditoDebito.SelectedIndex == 1)
            {
                opcao = "debito";
                opcao1 = "débito: ";
            }

            conecta.strSQL = "INSERT INTO movimentos (data, descricao, " + opcao + ", clienteId) " +
                "VALUES ('" + Convert.ToDateTime(dtpData.Value) + "', '" + txtDescricao.Text + "', " + Convert.ToInt32(txtValor.Text) + ", " +
                Convert.ToInt32(lstClientes.SelectedValue) + ");";

            var resultado = MessageBox.Show(Convert.ToString(dtpData.Value) + "\nCliente: " + lstClientes.GetItemText(lstClientes.SelectedItem) + "\nDescrição: "
                + txtDescricao.Text + "\nValor " + opcao1 + txtValor.Text + "\n\nCONFIRMA?", "VERIFIQUE OS DADOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                conecta.BuscarDados();
                AtualizarGrid();
            }
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes formcliente = new FormClientes();
            formcliente.ConfigurarInserirCliente();
            formcliente.ShowDialog();
            AtualizarLista();
            LimparGrid();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes formcliente = new FormClientes();
            formcliente.ConfigurarListarCliente();
            formcliente.ShowDialog();
            
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes formcliente = new FormClientes();
            formcliente.ConfigurarAlterarCliente();
            formcliente.ShowDialog();
            AtualizarLista();
            LimparGrid();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes formcliente = new FormClientes();
            formcliente.ConfigurarEliminarCliente();
            formcliente.ShowDialog();
            AtualizarLista();
            LimparGrid();
        }

       
    }
}
