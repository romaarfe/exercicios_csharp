using Diversos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCreditoDebito
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void btnInserirCliente_Click(object sender, EventArgs e)
        {
            if (VerificarExisteCliente(txtInserirCliente.Text) == false)
            {
                Conecta obj = new Conecta();
                obj.strSQL = "INSERT INTO clientes (nomeCliente) VALUES ('" + txtInserirCliente.Text + "');";
                obj.BuscarDados();
                this.Close();
            }
            else
            {
                MessageBox.Show("O nome já existe! Favor inserir outro nome.");
            }
            
        }

        private void lstListarClientes_DoubleClick(object sender, EventArgs e)
        {
            CriarPseudoPainel();
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            Conecta obj = new Conecta();
            obj.strSQL = "UPDATE clientes SET nomeCliente = '" + txtAlterarCliente.Text + "' WHERE id = '" + lstListarClientes.SelectedValue + "';";

            var resultado = MessageBox.Show("Optou por trocar o nome: " + lstListarClientes.GetItemText(lstListarClientes.SelectedItem) + "\nPor: "
                + txtAlterarCliente.Text + "\n\nCONFIRMA?", "VERIFIQUE OS DADOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                obj.BuscarDados();
                this.Close();
            } 
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            if (VerificarExisteCliente(txtClienteEliminado.Text) == true)
            {
                Conecta obj = new Conecta();

                obj.strSQL = "SELECT COUNT(id) FROM movimentos M INNER JOIN clientes C ON C.id = M.id WHERE nomeCliente = '" + txtClienteEliminado.Text + "';";
                int qtMovimentos = Convert.ToInt32(obj.BuscarDados().Rows[0][0]);
                MessageBox.Show("Este cliente tem '" + qtMovimentos + "' movimentos.");
                this.Close();
            }
            else
            {
                MessageBox.Show("O nome não existe! Favor procurar outro nome.");
            }
        }
    }

}
