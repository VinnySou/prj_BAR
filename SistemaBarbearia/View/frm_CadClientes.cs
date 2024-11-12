using SistemaBarbearia.DAO;
using SistemaBarbearia.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBarbearia.Entidades;

namespace SistemaBarbearia.View
{
    public partial class frm_CadClientes : Form
    {
        ClientesDAO clientesDAO = new ClientesDAO();
        ClientesModel clientesModel = new ClientesModel();
        public frm_CadClientes()
        {
            InitializeComponent();
            btn_Excluir.Visible = false;
            btn_Alterar.Visible = false;
            btn_Salvar.Visible = false;
            btn_Cancelar.Visible = false;
            btn_Ocultar.Visible = false;
            btn_Visivel.Visible = false;
            Carrega_Dados();
            LimparCampos();

        }
        public void LimparCampos()
        {
            txtB_Cod.Text = "";
            txtB_NomeClie.Text = "";
            txtB_Email.Text = "";
            txtB_Telefone.Text = "";
            txtB_CPF.Text = "";
            cmB_Sexo.Text = null;
            txtB_Senha.Text = "";
            txtB_Login.Text = "";
        }

        public void HabilitarCampos()
        {
            txtB_NomeClie.Enabled = true;
            txtB_Email.Enabled = true;
            txtB_Telefone.Enabled = true;
            txtB_CPF.Enabled = true;
            cmB_Sexo.Enabled = true;
            txtB_Senha.Enabled = true;
            txtB_Login.Enabled = true;
            btn_Visivel.Visible = true;
        }

        public void DesabilitarCampos()
        {
            txtB_Cod.Enabled = false;
            txtB_NomeClie.Enabled = false;
            txtB_Email.Enabled = false;
            txtB_Telefone.Enabled = false;
            txtB_CPF.Enabled = false;
            cmB_Sexo.Enabled = false;
            txtB_Senha.Enabled = false;
            txtB_Login.Enabled = false;
        }

        private void frm_CadClientes_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            btn_Ocultar.Visible = false;

        }

        private void btn_Visivel_Click(object sender, EventArgs e)
        {
            txtB_Senha.UseSystemPasswordChar = false;
            btn_Ocultar.Visible = true;
            btn_Visivel.Visible = false;
        }

        private void btn_Ocultar_Click(object sender, EventArgs e)
        {
            txtB_Senha.UseSystemPasswordChar = true;
            btn_Visivel.Visible = true;
            btn_Ocultar.Visible = false;
        }
        private void Excluir_dados(Clientes dados)
        {
            try
            {

                dados.Codclie = Convert.ToInt32(txtB_Cod.Text);
                dados.Nome = txtB_NomeClie.Text;
                dados.Email = txtB_Email.Text;
                dados.Cpf = txtB_CPF.Text;
                dados.Sexo = (cmB_Sexo.SelectedText);
                dados.Telefone = txtB_Telefone.Text;
                dados.Login = txtB_Login.Text;
                dados.Senha = txtB_Senha.Text;



                clientesModel.Excluir(dados);
                MessageBox.Show("Dados do Cliente excluídos com sucesso!");
                LimparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir os dados!!" + ex.Message);
            }
        }
        public void Editar_dados(Clientes dados)
        {
            btn_Cancelar.Visible = true;
            try
            {
                dados.Codclie = Convert.ToInt32(txtB_Cod.Text);
                dados.Nome = txtB_NomeClie.Text;
                dados.Email = txtB_Email.Text;
                dados.Cpf = txtB_CPF.Text;
                dados.Sexo = cmB_Sexo.Text;
                dados.Telefone = txtB_Telefone.Text;
                dados.Login = txtB_Login.Text;
                dados.Senha = txtB_Senha.Text;


                clientesModel.Editar(dados);
                MessageBox.Show("Dados do cliente alterados com sucesso!");
                LimparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar os dados!!" + ex.Message);
            }

        }

        public void Envia_dados(Clientes dados)
        {
            try
            {

                dados.Nome = txtB_NomeClie.Text;
                dados.Email = txtB_Email.Text;
                dados.Cpf = txtB_CPF.Text;
                dados.Sexo = cmB_Sexo.Text;
                dados.Telefone = txtB_Telefone.Text;
                dados.Login = txtB_Login.Text;
                dados.Senha = txtB_Senha.Text;

                clientesModel.Salvar(dados);
                MessageBox.Show("Dados do Cliente salvos com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados!!" + ex.Message);
            }

        }

        public void Carrega_Dados()
        {

            try
            {
                dGV_Clie.DataSource = clientesModel.ChamaListar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro de conexão! " + ex.Message);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txtB_NomeClie.Text == ""
               || txtB_CPF.Text == ""
               || txtB_Login.Text == ""
               || txtB_Senha.Text == ""
               || txtB_Telefone.Text == ""
               || cmB_Sexo.Text == null)
            {

                MessageBox.Show("Existem campos vazios, que precisam ser preenchidos!");
                txtB_NomeClie.Focus();
                return;

            }
            else
            {
                Clientes dados = new Clientes();
                Envia_dados(dados);
                Carrega_Dados();
                btn_Novo.Visible = true;
                btn_Cancelar.Visible = false;
                btn_Excluir.Visible = false;
                btn_Alterar.Visible = false;
                btn_Salvar.Visible = false;
                LimparCampos();
                DesabilitarCampos();
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            btn_Novo.Visible = true;
            btn_Alterar.Visible = false;
            btn_Excluir.Visible = false;
            btn_Cancelar.Visible = false;
            btn_Salvar.Visible = false;
            btn_Visivel.Visible = false;
            LimparCampos();
            DesabilitarCampos();
            
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            btn_Salvar.Visible = true;
            btn_Excluir.Visible = false;
            btn_Alterar.Visible = false;
            txtB_NomeClie.Focus();
            btn_Cancelar.Visible = true;
            btn_Salvar.Visible = true;
            btn_Novo.Visible = false;
            btn_Visivel.Visible = true;
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            btn_Visivel.Visible = true;
            btn_Cancelar.Visible = true;
            HabilitarCampos();
            if (txtB_Cod.Text == "")
            {
                MessageBox.Show("Selecione um registro/linha abaixo, que deseja ser alterada");
                return;

            }
            if (txtB_NomeClie.Text == ""
               || txtB_CPF.Text == ""
               || txtB_Login.Text == ""
               || txtB_Senha.Text == ""
               || txtB_Telefone.Text == ""
               || cmB_Sexo.Text == null)
            {

                MessageBox.Show("Existem campos vazios, que precisam ser preenchidos!");
                txtB_NomeClie.Focus();

            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA EDITAR O REGISTRO SELECIONADO?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {

                    Clientes dados = new Clientes();
                    Editar_dados(dados);
                    btn_Alterar.Visible = false;
                    btn_Excluir.Visible = false;
                    btn_Cancelar.Visible = false;
                    btn_Novo.Visible = true;
                    DesabilitarCampos();
                    Carrega_Dados();
                    LimparCampos();
                }
                else
                {
                    btn_Alterar.Visible = false;
                    btn_Excluir.Visible = false;
                    btn_Cancelar.Visible = false;
                    btn_Novo.Visible = true;
                    LimparCampos();
                    DesabilitarCampos();
                    Carrega_Dados();
                }
            }
        }

        private void dGV_Clie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtB_Cod.Text = dGV_Clie.CurrentRow.Cells[0].Value.ToString();
            txtB_NomeClie.Text = dGV_Clie.CurrentRow.Cells[1].Value.ToString();
            txtB_Telefone.Text = dGV_Clie.CurrentRow.Cells[3].Value.ToString();
            txtB_CPF.Text = dGV_Clie.CurrentRow.Cells[2].Value.ToString();
            cmB_Sexo.Text = dGV_Clie.CurrentRow.Cells[7].Value.ToString();
            txtB_Senha.Text = dGV_Clie.CurrentRow.Cells[6].Value.ToString();
            txtB_Login.Text = dGV_Clie.CurrentRow.Cells[5].Value.ToString();
            txtB_Email.Text = dGV_Clie.CurrentRow.Cells[4].Value.ToString();
            HabilitarCampos();
            btn_Salvar.Visible = false;
            btn_Novo.Visible = false;
            btn_Excluir.Visible = true;
            btn_Alterar.Visible = true;
            btn_Visivel.Visible = true;
            btn_Cancelar.Visible = true;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btn_Cancelar.Visible= true;
            if (txtB_Cod.Text == "")
            {
                MessageBox.Show("Selecione um registro/linha abaixo, que deseja ser exclída");
                return;

            }

            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR O REGISTRO SELECIONADO?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Carrega_Dados();
                Clientes dados = new Clientes();
                Excluir_dados(dados);
                btn_Alterar.Visible = false;
                btn_Excluir.Visible = false;
                btn_Cancelar.Visible = false;
                btn_Novo.Visible = true;
                DesabilitarCampos();
                LimparCampos();
                Carrega_Dados();
            }
            else
            {
                btn_Cancelar.Visible = false;
                btn_Alterar.Visible = false;
                btn_Excluir.Visible = false;
                btn_Cancelar.Visible = false;
                btn_Novo.Visible = true;
                DesabilitarCampos();
                LimparCampos();
                Carrega_Dados();
            }

        }

        private void lbl_CliqueGrid_Click(object sender, EventArgs e)
        {

        }
    }
}
