using SistemaBarbearia.DAO;
using SistemaBarbearia.Entidades;
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

namespace SistemaBarbearia.View
{
    public partial class frm_CadCategoria : Form
    {
        CategoriaModel categoriaModel = new CategoriaModel();
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        public frm_CadCategoria()
        {
            InitializeComponent();
            btn_Salvar.Visible = false;
            btn_Cancelar.Visible = false;
            Carrega_Dados();
            btn_Novo.Focus();
            DesabilitarCampos();
            btn_Editar.Visible = false;
            btn_Excluir.Visible = false;
        }

        public void LimparCampos()
        {
            txtB_NomeCateg.Text = "";
            txtB_CodCateg.Text = "";
        }

        public void HabilitarCampos()
        {
            txtB_CodCateg.Enabled = true;
            txtB_NomeCateg.Enabled = true;
        }
        public void DesabilitarCampos()
        {
            txtB_CodCateg.Enabled = false;
            txtB_NomeCateg.Enabled = false;
        }
        public void Carrega_Dados()
        {
            try
            {
                dGV_Categoria.DataSource = categoriaModel.ChamaListar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de conexão! " + ex.Message);
            }

        }
        public void Envia_dados(Categoria dados)
        {
            try
            {


                dados.Nomecateg = txtB_NomeCateg.Text;

                categoriaModel.Salvar(dados);
                MessageBox.Show("Cadastro da CATEGORIA salvo com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados!!" + ex.Message);
            }

        }
        public void Editar_dados(Categoria dados)
        {
            HabilitarCampos();
            try
            {
                dados.Codcateg = Convert.ToInt32(txtB_CodCateg.Text);
                dados.Nomecateg = txtB_NomeCateg.Text;

                categoriaModel.Editar(dados);
                MessageBox.Show("Dados da Categoria alterados com sucesso!");
                LimparCampos();
                DesabilitarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar os dados!!" + ex.Message);
            }
        }
        private void Excluir_dados(Categoria dados)
        {
            try
            {
                dados.Codcateg = Convert.ToInt32(txtB_CodCateg.Text);
                dados.Nomecateg = txtB_NomeCateg.Text;

                categoriaModel.Excluir(dados);
                MessageBox.Show("Dados da Categoria excluídos com sucesso!");
                LimparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir os dados!!" + ex.Message);
            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btn_Editar.Visible = false;
            btn_Excluir.Visible = false;
            btn_Cancelar.Visible = true;
            btn_Salvar.Visible = true;
            btn_Salvar.Enabled = true;
            btn_Novo.Visible = false;
            HabilitarCampos();

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            if (txtB_NomeCateg.Text == "")
            {

                MessageBox.Show("O campo nome não pode estar vazio");
                txtB_NomeCateg.Focus();
                return;

            }
            Categoria dados = new Categoria();
            Envia_dados(dados);
            Carrega_Dados();
            LimparCampos();
            btn_Novo.Visible = true;
            btn_Editar.Visible = false;
            btn_Excluir.Visible = false;
            btn_Cancelar.Visible = false;
            btn_Salvar.Visible = false;
            DesabilitarCampos();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            btn_Salvar.Visible = false;
            btn_Cancelar.Visible = false;
            btn_Editar.Visible = false;
            btn_Excluir.Visible = false;
            btn_Novo.Visible = true;
            LimparCampos();
            DesabilitarCampos();
        }

        private void frm_CadCategoria_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txtB_CodCateg.Text == "")
            {
                MessageBox.Show("Selecione um registro/linha abaixo, que deseja editar");
                return;

            }
            if (txtB_NomeCateg.Text == "")
            {
                MessageBox.Show("Existem campos vazios, que precisam ser preenchidos!");
                txtB_NomeCateg.Focus();
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA EDITAR O REGISTRO SELECIONADO?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                HabilitarCampos();
                Categoria dados = new Categoria();
                Editar_dados(dados);
                Carrega_Dados();
                LimparCampos();
                btn_Editar.Visible = false;
                btn_Excluir.Visible= false;
                btn_Novo.Visible = true;
                btn_Cancelar.Visible = false;
                DesabilitarCampos();
            }
            else
            {
                btn_Cancelar.Visible = false;
                btn_Editar.Visible = false;
                btn_Excluir.Visible = false;
                LimparCampos();
                btn_Novo.Visible = true;
                DesabilitarCampos();
            }
        }

        private void dGV_Categoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos();
            txtB_CodCateg.Text = dGV_Categoria.CurrentRow.Cells[0].Value.ToString();
            txtB_NomeCateg.Text = dGV_Categoria.CurrentRow.Cells[1].Value.ToString();
            btn_Novo.Visible = false;
            btn_Editar.Visible = true;
            btn_Excluir.Visible = true;
            btn_Cancelar.Visible = true; 
            
            
        }



        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            btn_Editar.Visible = false;
            btn_Novo.Visible = false;
            btn_Salvar.Visible = false;
            btn_Cancelar.Visible = true;


            if (txtB_CodCateg.Text == "")
            {
                MessageBox.Show("Selecione um registro/linha abaixo, que deseja ser excluída");
                return;

            }

            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR O REGISTRO SELECIONADO?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Carrega_Dados();
                Categoria dados = new Categoria();
                Excluir_dados(dados);
                Carrega_Dados();
                btn_Editar.Visible = false;
                btn_Excluir.Visible = false;
                btn_Novo.Visible = true;
                btn_Cancelar.Visible = false;
                DesabilitarCampos();
            }
            else
            {
                LimparCampos();
                btn_Editar.Visible = false;
                btn_Excluir.Visible = false;
                btn_Novo.Visible = true;
                btn_Cancelar.Visible = false;

                DesabilitarCampos();
            }
        }
    }
}
