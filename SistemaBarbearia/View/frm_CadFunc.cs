using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBarbearia.DAO;
using SistemaBarbearia.Entidades;
using SistemaBarbearia.Model;

namespace SistemaBarbearia.View
{
    public partial class frm_CadFunc : Form
    {
        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
        FuncionarioModel funcionarioModel = new FuncionarioModel();

        public frm_CadFunc()
        {
            InitializeComponent();
            btn_Novo.Enabled = true;
            btn_Excluir.Visible = false;
            btn_Editar.Visible = false;
            btn_Cancelar.Visible = false;
            btn_Salvar.Visible = false;
            btn_Ocultar.Visible = false;
            Carrega_Dados();
        }
        private void frm_CadFunc_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            btn_Ocultar.Visible = false;
            txtB_Nome.Focus();
        }
        public void HabilitarCampos()
        {
            txtB_Cod.Enabled = true;
            txtB_Nome.Enabled = true;
            txtB_Email.Enabled = true;
            txtB_Telefone.Enabled = true;
            txtB_CPF.Enabled = true;
            txtB_Rua.Enabled = true;
            txtB_Bairro.Enabled = true;
            txtB_CEP.Enabled = true;
            cmB_Cidade.Enabled = true;
            cmB_Uf.Enabled = true;
            txtB_Senha.Enabled = true;
            txtB_Login.Enabled = true;
            cmB_Sexo.Enabled = true;
        }

        public void DesabilitarCampos()
        {
            txtB_Cod.Enabled = false;
            txtB_Nome.Enabled = false;
            txtB_Email.Enabled = false;
            txtB_Telefone.Enabled = false;
            txtB_CPF.Enabled = false;
            txtB_Rua.Enabled = false;
            txtB_Bairro.Enabled = false;
            txtB_CEP.Enabled = false;
            cmB_Cidade.Enabled = false;
            cmB_Uf.Enabled = false;
            txtB_Senha.Enabled = false;
            txtB_Login.Enabled = false;
            cmB_Sexo.Enabled = false;
        }

        public void LimparCampos()
        {
            txtB_Cod.Text = "";
            txtB_Nome.Text = "";
            txtB_Telefone.Text = "";
            txtB_CPF.Text = "";
            txtB_Rua.Text = "";
            txtB_Bairro.Text = "";
            txtB_CEP.Text = "";
            cmB_Cidade.Text = "";
            cmB_Uf.Text = "";
            cmB_Sexo.Text = "";
            txtB_Senha.Text = "";
            txtB_Login.Text = "";
            txtB_Email.Text = "";
        }

        private void Excluir_dados(Funcionario dados)
        {
            try
            {

                dados.Codmatri = Convert.ToInt32(txtB_Cod.Text);
                dados.Nome = txtB_Nome.Text;
                dados.Email = txtB_Email.Text;
                dados.Cpf = txtB_CPF.Text;
                dados.Sexo = cmB_Sexo.Text;
                dados.Telefone = txtB_Telefone.Text;
                dados.Login = txtB_Login.Text;
                dados.Senha = txtB_Senha.Text;
                dados.Rua = txtB_Rua.Text;
                dados.Cep = txtB_CEP.Text;
                dados.Cidade = cmB_Cidade.Text;
                dados.Uf = cmB_Uf.Text;

                funcionarioModel.Excluir(dados);
                MessageBox.Show("Dados do funcionário excluídos com sucesso!");
                LimparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir os dados!!" + ex.Message);
            }
        }

        public void Editar_dados(Funcionario dados)
        {
            try
            {
                dados.Codmatri = Convert.ToInt32(txtB_Cod.Text);
                dados.Nome = txtB_Nome.Text;
                dados.Email = txtB_Email.Text;
                dados.Cpf = txtB_CPF.Text;
                dados.Sexo = cmB_Sexo.Text;
                dados.Telefone = txtB_Telefone.Text;
                dados.Login = txtB_Login.Text;
                dados.Senha = txtB_Senha.Text;
                dados.Rua = txtB_Rua.Text;
                dados.Cep = txtB_CEP.Text;
                dados.Cidade = cmB_Cidade.Text;
                dados.Bairro = txtB_Bairro.Text;
                dados.Uf = cmB_Uf.Text;

                funcionarioModel.Editar(dados);
                MessageBox.Show("Dados do funcionário alterados com sucesso!");
                LimparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar os dados!!" + ex.Message);
            }

        }

        public void PosicaoInicial()
        {
            btn_Editar.Visible = false;
            btn_Excluir.Visible = false;
            btn_Novo.Visible = true;
            btn_Cancelar.Visible = false;
            btn_Salvar.Visible = false;
            btn_Cancelar.Location = new Point(570, 218);
            btn_Salvar.Location = new Point(570, 247);
        }



        public void Envia_dados(Funcionario dados)
        {
            try
            {

                dados.Nome = txtB_Nome.Text;
                dados.Email = txtB_Email.Text;
                dados.Cpf = txtB_CPF.Text;
                dados.Sexo = cmB_Sexo.Text;
                dados.Telefone = txtB_Telefone.Text;
                dados.Login = txtB_Login.Text;
                dados.Senha = txtB_Senha.Text;
                dados.Rua = txtB_Rua.Text;
                dados.Cep = txtB_CEP.Text;
                dados.Cidade = cmB_Cidade.Text;
                dados.Bairro = txtB_Bairro.Text;
                dados.Uf = cmB_Uf.Text;
                funcionarioModel.Salvar(dados);
                MessageBox.Show("Cadastro dos funcionário salvo com sucesso!");

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
                dGV_Funcionario.DataSource = funcionarioModel.ChamaListar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro de conexão! " + ex.Message);
            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            btn_Editar.Visible = false;
            btn_Excluir.Visible = false;
            btn_Salvar.Visible = true;
            btn_Cancelar.Visible = true;
            btn_Cancelar.Location = new Point(570, 160);
            btn_Salvar.Location = new Point(570, 189);
            btn_Novo.Visible = false;
            btn_Salvar.Visible = true;
            btn_Novo.Visible = false;
            txtB_Nome.Focus();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            if (txtB_Nome.Text == ""
               || txtB_CPF.Text == ""
               || txtB_Login.Text == ""
               || txtB_Senha.Text == ""
               || txtB_Telefone.Text == ""
               || cmB_Sexo.Text == null
               || txtB_Rua.Text == ""
               || txtB_Bairro.Text == ""
               || txtB_CEP.Text == ""
               || cmB_Cidade.Text == null
               || cmB_Uf.Text == null)
            {

                MessageBox.Show("Existem campos vazios, verifique!");
                txtB_Nome.Focus();

            }
            else
            {
                Funcionario dados = new Funcionario();
                Envia_dados(dados);
                Carrega_Dados();
                PosicaoInicial();
                LimparCampos();
                DesabilitarCampos();
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            btn_Novo.Visible = true;
            btn_Excluir.Visible = true;
            btn_Editar.Visible = true;
            btn_Salvar.Visible = false;
            PosicaoInicial();
            DesabilitarCampos();
            LimparCampos();
            btn_Cancelar.Visible = false;
            Carrega_Dados();

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            if (txtB_Cod.Text == "")
            {
                MessageBox.Show("Selecione um registro/linha abaixo, que deseja editar");
                return;

            }
            if (txtB_Nome.Text == ""
              || txtB_CEP.Text == ""
              || txtB_Bairro.Text == ""
              || txtB_CPF.Text == ""
              || txtB_Login.Text == ""
              || txtB_Rua.Text == ""
              || txtB_Senha.Text == ""
              || txtB_Telefone.Text == ""
              || cmB_Uf.Text == null
              || cmB_Sexo.Text == null
              || cmB_Cidade.Text == null)
            {

                MessageBox.Show("Existem campos vazios, que precisam ser preenchidos!!!");
                txtB_Nome.Focus();

            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA EDITAR O REGISTRO SELECIONADO?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    
                    Funcionario dados = new Funcionario();
                    Editar_dados(dados);
                    PosicaoInicial();
                    btn_Novo.Visible = true;
                    btn_Excluir.Visible = false;
                    btn_Editar.Visible = false;
                    btn_Cancelar.Visible = false;
                    Carrega_Dados();
                    LimparCampos();
                    DesabilitarCampos();
                }
                else
                {
                    PosicaoInicial();
                    btn_Novo.Visible = true;
                    btn_Excluir.Visible = false;
                    btn_Editar.Visible = false;
                    btn_Cancelar.Visible = false;
                    Carrega_Dados();
                    LimparCampos();
                    DesabilitarCampos();
                }
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

            btn_Cancelar.Visible = true;
            HabilitarCampos();
            if (txtB_Cod.Text == "")
            {
                MessageBox.Show("Selecione um registro/linha abaixo, que deseja ser exclída");
                return;

            }

            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR O REGISTRO SELECIONADO?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {

                Funcionario dados = new Funcionario();
                Excluir_dados(dados);
                btn_Excluir.Visible = false;
                btn_Editar.Visible = false;
                btn_Novo.Enabled = true;
                LimparCampos();
                PosicaoInicial();
                Carrega_Dados();
                DesabilitarCampos();
            }
            else
            {
                PosicaoInicial();
                btn_Novo.Visible = true;
                btn_Excluir.Visible = false;
                btn_Editar.Visible = false;
                btn_Cancelar.Visible = false;
                Carrega_Dados();
                LimparCampos();
                DesabilitarCampos();
            }
        }

        private void dGV_Funcionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtB_Cod.Text = dGV_Funcionario.CurrentRow.Cells[0].Value.ToString();
            txtB_Nome.Text = dGV_Funcionario.CurrentRow.Cells[1].Value.ToString();
            txtB_Telefone.Text = dGV_Funcionario.CurrentRow.Cells[3].Value.ToString();
            txtB_CPF.Text = dGV_Funcionario.CurrentRow.Cells[2].Value.ToString();
            txtB_Rua.Text = dGV_Funcionario.CurrentRow.Cells[5].Value.ToString();
            txtB_Bairro.Text = dGV_Funcionario.CurrentRow.Cells[6].Value.ToString();
            txtB_CEP.Text = dGV_Funcionario.CurrentRow.Cells[9].Value.ToString();
            cmB_Cidade.Text = dGV_Funcionario.CurrentRow.Cells[8].Value.ToString();
            cmB_Uf.Text = dGV_Funcionario.CurrentRow.Cells[7].Value.ToString();
            cmB_Sexo.Text = dGV_Funcionario.CurrentRow.Cells[12].Value.ToString();
            txtB_Senha.Text = dGV_Funcionario.CurrentRow.Cells[11].Value.ToString();
            txtB_Login.Text = dGV_Funcionario.CurrentRow.Cells[10].Value.ToString();
            txtB_Email.Text = dGV_Funcionario.CurrentRow.Cells[4].Value.ToString();
            HabilitarCampos();
            btn_Editar.Visible = true;
            btn_Excluir.Visible = true;
            btn_Cancelar.Visible = true;
            btn_Novo.Visible = false;
            btn_Salvar.Visible = false;
            btn_Cancelar.Location = new Point(570, 215);
        }

        private void btn_Ocultar_Click(object sender, EventArgs e)
        {
            txtB_Senha.UseSystemPasswordChar = true;
            btn_Ocultar.Visible = false;
            btn_Visivel.Visible = true;
        }

        private void btn_Visivel_Click(object sender, EventArgs e)
        {
            txtB_Senha.UseSystemPasswordChar = false;
            btn_Ocultar.Visible = true;
            btn_Visivel.Visible = false;
        }
    }
}
