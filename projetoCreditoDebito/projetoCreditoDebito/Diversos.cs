using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Diversos

{
    public class Conecta
    {
        public static string strConn = "Data Source = 62.28.39.135,62444; Initial Catalog = zRodrigoCD;" +
                                       "User Id = EFARodrigo; Password = 123.Abc;";

        public string strSQL;

        public DataTable BuscarDados()
        {
            //criar uma conexão:
            SqlConnection C = new SqlConnection(strConn);
            C.Open();
            //criar comando SQL para extrair os dados pretendidos:
            SqlCommand command = C.CreateCommand();
            command.CommandText = strSQL;

            //trazer os dados da tabela especificada para uma "tabela" em memória:
            SqlDataAdapter da = new SqlDataAdapter(command);
            var dt = new DataTable();
            da.Fill(dt);

            //desligar a conexão:
            C.Close();
            return dt;
        }
    }

    public class FormatarGrid 
    {
        public void GridFormatar(DataGridView dgvDevedores)
        {

            dgvDevedores.AllowUserToAddRows = false;
            dgvDevedores.ColumnHeadersVisible = true;
            dgvDevedores.RowHeadersVisible = false;

            //id:
            dgvDevedores.Columns[0].Name = "id";
            dgvDevedores.Columns[0].HeaderText = "PK";
            dgvDevedores.Columns["id"].Visible = false;
            dgvDevedores.Columns["id"].Width = 30;

            //data
            dgvDevedores.Columns[1].Name = "data"; dgvDevedores.Columns[1].HeaderText = "Data";
            dgvDevedores.Columns["data"].Visible = true; dgvDevedores.Columns["data"].Width = 80;
            dgvDevedores.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //descricao:

            dgvDevedores.Columns[2].Name = "descricao"; dgvDevedores.Columns[2].HeaderText = "Descrição";
            dgvDevedores.Columns["descricao"].Visible = true; dgvDevedores.Columns["descricao"].Width = 300;
            for (int i = 0; i < dgvDevedores.RowCount; i++)
            { dgvDevedores.Rows[i].Cells[2].Style.Font = new Font("Arial", 8, FontStyle.Bold); }


            //debito:
            dgvDevedores.Columns[3].Name = "debito"; dgvDevedores.Columns[3].HeaderText = "Valor Débito";
            dgvDevedores.Columns["debito"].Visible = true; dgvDevedores.Columns["debito"].Width = 80;
            dgvDevedores.Columns[3].DefaultCellStyle.Format = "c2";
            // for (int i = 0; i < dgvDevedores.RowCount; i++) { dgvDevedores.Rows[i].Cells[3].Style.Format = "0.00"; }//funciona
            dgvDevedores.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //valorCredito
            dgvDevedores.Columns[4].Name = "credito"; dgvDevedores.Columns[4].HeaderText = "Valor Crédito";
            dgvDevedores.Columns["credito"].Visible = true; dgvDevedores.Columns["credito"].Width = 80;
            dgvDevedores.Columns[4].DefaultCellStyle.Format = "c2";
            //for (int i = 0; i < dgvDevedores.RowCount; i++) {dgvDevedores.Rows[i].Cells[4].Style.Format = "0.00";} funciona
            dgvDevedores.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //idCliente
            //dgvDevedores.Columns[5].Name = "idCliente"; dgvDevedores.Columns[5].HeaderText = "Id Cliente";
            //dgvDevedores.Columns["idCliente"].Visible = false; dgvDevedores.Columns["idCliente"].Width = 40;

            //saldo
            dgvDevedores.Columns[5].Name = "saldo"; dgvDevedores.Columns[5].HeaderText = "Saldo";
            dgvDevedores.Columns["saldo"].Visible = true; dgvDevedores.Columns["saldo"].Width = 100;
            //dgvDevedores.Columns[6].DefaultCellStyle.Format = "# ##0.00";//funciona
            dgvDevedores.Columns[5].DefaultCellStyle.Format = "c2";
            dgvDevedores.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDevedores.Columns["saldo"].ReadOnly = true;//proteger contra alteração pelo utilizador
            dgvDevedores.Columns["saldo"].DefaultCellStyle.ForeColor = Color.Navy;
            dgvDevedores.Columns["saldo"].DefaultCellStyle.BackColor = Color.Lavender;


            dgvDevedores.Sort(dgvDevedores.Columns["data"], ListSortDirection.Ascending);

            try
            {//mostrar sempre os últimos registos da grid:
                dgvDevedores.FirstDisplayedScrollingRowIndex = dgvDevedores.RowCount - 1;
            }
            catch (Exception)
            {
                ;

            }
        }
    }
    
}
