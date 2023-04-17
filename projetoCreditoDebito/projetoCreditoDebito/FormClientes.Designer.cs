using Diversos;
using System;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace projetoCreditoDebito
{
    partial class FormClientes
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
            
            this.SuspendLayout();
            
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 254);
            
            this.Name = "FormClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public bool VerificarExisteCliente(string nomeCliente)
        {
            Conecta conecta = new Conecta();
            conecta.strSQL = "SELECT nomeCliente FROM clientes WHERE nomeCliente LIKE '" + nomeCliente + "';";

            try
            {
                if (nomeCliente == Convert.ToString(conecta.BuscarDados().Rows[0][0]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception)
            {
                return false;
                
            }
                
        }

        public void ConfigurarInserirCliente()
        {
            this.btnInserirCliente = new System.Windows.Forms.Button();
            this.txtInserirCliente = new System.Windows.Forms.TextBox();
            this.lblNovoCliente = new System.Windows.Forms.Label();

            this.Text = "INSERIR CLIENTES";
            //
            // btnInserirCliente
            // 
            this.btnInserirCliente.Location = new System.Drawing.Point(136, 135);
            this.btnInserirCliente.Name = "btnInserirCliente";
            this.btnInserirCliente.Size = new System.Drawing.Size(94, 42);
            this.btnInserirCliente.TabIndex = 0;
            this.btnInserirCliente.Text = "INSERIR";
            this.btnInserirCliente.UseVisualStyleBackColor = true;
            this.btnInserirCliente.Click += new System.EventHandler(this.btnInserirCliente_Click);
            // 
            // txtInserirCliente
            // 
            this.txtInserirCliente.Location = new System.Drawing.Point(59, 90);
            this.txtInserirCliente.Name = "txtInserirCliente";
            this.txtInserirCliente.Size = new System.Drawing.Size(263, 20);
            this.txtInserirCliente.TabIndex = 1;
            // 
            // lblNovoCliente
            // 
            this.lblNovoCliente.AutoSize = true;
            this.lblNovoCliente.Location = new System.Drawing.Point(144, 59);
            this.lblNovoCliente.Name = "lblNovoCliente";
            this.lblNovoCliente.Size = new System.Drawing.Size(86, 13);
            this.lblNovoCliente.TabIndex = 2;
            this.lblNovoCliente.Text = "NOVO CLIENTE";
            //
            //
            this.Controls.Add(this.lblNovoCliente);
            this.Controls.Add(this.txtInserirCliente);
            this.Controls.Add(this.btnInserirCliente);
        }

        public void ConfigurarListarCliente()
        {
            this.lstListarClientes = new System.Windows.Forms.ListBox();

            this.Text = "LISTAR CLIENTES";
            //
            // lstListarClientes
            // 
            this.lstListarClientes.Location = new System.Drawing.Point(12, 12);
            this.lstListarClientes.Name = "lstListarClientes";
            this.lstListarClientes.Size = new System.Drawing.Size(358, 212);
            this.lstListarClientes.TabIndex = 0;

            Conecta obj = new Conecta();

            lstListarClientes.DisplayMember = "nomeCliente";
            lstListarClientes.ValueMember = "id";

            obj.strSQL = "SELECT id, nomeCliente FROM clientes;";
            lstListarClientes.DataSource = obj.BuscarDados();

            this.Controls.Add(this.lstListarClientes);
        }

        public void ConfigurarAlterarCliente()
        {
            ConfigurarListarCliente();
            this.Text = "ALTERAR CLIENTES";
            this.lstListarClientes.Size = new System.Drawing.Size(250, 212);
            this.lstListarClientes.DoubleClick += new System.EventHandler(this.lstListarClientes_DoubleClick);  
        }

        public void ConfigurarEliminarCliente() 
        {
            this.lblClienteEliminado = new System.Windows.Forms.Label();
            this.txtClienteEliminado = new System.Windows.Forms.TextBox();
            this.lblEliminarCliente = new System.Windows.Forms.Label();
            this.btnProcurar = new System.Windows.Forms.Button();

            // 
            // lblClienteEliminado
            // 
            this.lblClienteEliminado.AutoSize = true;
            this.lblClienteEliminado.Location = new System.Drawing.Point(38, 93);
            this.lblClienteEliminado.Name = "lblClienteEliminado";
            this.lblClienteEliminado.Size = new System.Drawing.Size(112, 13);
            this.lblClienteEliminado.TabIndex = 0;
            this.lblClienteEliminado.Text = "Cliente a ser eliminado";
            // 
            // txtClienteEliminado
            // 
            this.txtClienteEliminado.Location = new System.Drawing.Point(182, 86);
            this.txtClienteEliminado.Name = "txtClienteEliminado";
            this.txtClienteEliminado.Size = new System.Drawing.Size(100, 20);
            this.txtClienteEliminado.TabIndex = 1;
            // 
            // lblEliminarCliente
            // 
            this.lblEliminarCliente.AutoSize = true;
            this.lblEliminarCliente.Location = new System.Drawing.Point(115, 41);
            this.lblEliminarCliente.Name = "lblEliminarCliente";
            this.lblEliminarCliente.Size = new System.Drawing.Size(106, 13);
            this.lblEliminarCliente.TabIndex = 2;
            this.lblEliminarCliente.Text = "ELIMINAR CLIENTE";
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(129, 146);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 3;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.lblEliminarCliente);
            this.Controls.Add(this.txtClienteEliminado);
            this.Controls.Add(this.lblClienteEliminado);
        }

        public void CriarPseudoPainel()
        {
            this.lblAlterarCliente = new System.Windows.Forms.Label();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.txtAlterarCliente = new System.Windows.Forms.TextBox();
            // 
            // lblAlterarCliente
            // 
            this.lblAlterarCliente.AutoSize = true;
            this.lblAlterarCliente.Location = new System.Drawing.Point(270, 15);
            this.lblAlterarCliente.Name = "lblAlterarCliente";
            this.lblAlterarCliente.Size = new System.Drawing.Size(37, 13);
            this.lblAlterarCliente.TabIndex = 0;
            this.lblAlterarCliente.Text = "A SER ALTERADO";
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Location = new System.Drawing.Point(270, 60);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCliente.TabIndex = 1;
            this.btnAlterarCliente.Text = "GRAVAR";
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            this.btnAlterarCliente.Click += new System.EventHandler(this.btnAlterarCliente_Click);
            // 
            // txtAlterarCliente
            // 
            this.txtAlterarCliente.Location = new System.Drawing.Point(270, 35);
            this.txtAlterarCliente.Name = "txtAlterarCliente";
            this.txtAlterarCliente.Size = new System.Drawing.Size(100, 20);
            this.txtAlterarCliente.TabIndex = 2;
            // 

            this.Controls.Add(this.txtAlterarCliente);
            this.Controls.Add(this.btnAlterarCliente);
            this.Controls.Add(this.lblAlterarCliente);
        }

        
        #endregion

        private System.Windows.Forms.Button btnInserirCliente;
        private System.Windows.Forms.TextBox txtInserirCliente;
        private System.Windows.Forms.Label lblNovoCliente;
        private System.Windows.Forms.ListBox lstListarClientes;
        private System.Windows.Forms.Label lblAlterarCliente;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.TextBox txtAlterarCliente;
        private Label lblClienteEliminado;
        private TextBox txtClienteEliminado;
        private Label lblEliminarCliente;
        private Button btnProcurar;
    }
}