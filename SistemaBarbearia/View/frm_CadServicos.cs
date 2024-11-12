using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBarbearia.Model;
using SistemaBarbearia.Entidades;

namespace SistemaBarbearia.View
{
    public partial class frm_CadServicos : Form
    {
        ServicoModel servicoModel = new ServicoModel();
        CategoriaModel categoriaModel = new CategoriaModel();

        public frm_CadServicos()
        {
            InitializeComponent();
            Carrega_Dados();
            CancelarAcao();
            btn_Salvar.Visible = false;
            btn_Cancelar.Visible = false;
            LimparCampos();
            DesabilitarCampos();
        }

        public void HabilitarCampos()
        {
            txtB_Cod.Enabled = true;
            txtB_Nome.Enabled = true;
            txtB_Preco.Enabled = true;
            cmB_CategSer.Enabled = true;
        }
        public void DesabilitarCampos()
        {
            txtB_Cod.Enabled = false;
            txtB_Nome.Enabled = false;
            txtB_Preco.Enabled = false;
            cmB_CategSer.Enabled = false;
        }
        public void LimparCampos()
        {
            txtB_Cod.Text = "";
            txtB_Nome.Text = "";
            txtB_Preco.Text = "";
            cmB_CategSer.Text = null;
        }
        public void Carrega_Dados()
        {
            try
            {
                dGV_Servicos.DataSource = servicoModel.ChamaListar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de conexão! " + ex.Message);
            }

        }
        public void Envia_dados(Servico dados)
        {
            try
            {


                dados.Nomeserv = txtB_Nome.Text;
                dados.Preco_serv = Convert.ToInt32(txtB_Preco.Text);
                dados.Cod_categ1 = Convert.ToInt32(cmB_CategSer.SelectedValue);

                servicoModel.Salvar(dados);
                MessageBox.Show("Cadastro do Serviço salvo com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados!!" + ex.Message);
            }

        }
        public void CancelarAcao()
        {
            btn_Editar.Visible = false;
            btn_Excluir.Visible = false;
            btn_Novo.Visible = true;
            btn_Salvar.Visible = false;
            btn_Cancelar.Visible = false;
            DesabilitarCampos();
            LimparCampos();
        }

        public void Editar_dados(Servico dados)
        {

            try
            {
                dados.Cod_servico1 = Convert.ToInt32(txtB_Cod.Text);
                dados.Nomeserv = txtB_Nome.Text;
                dados.Preco_serv = Convert.ToDecimal(txtB_Preco.Text);
                if (cmB_CategSer.SelectedValue != null)
                {
                    dados.Cod_categ1 = Convert.ToInt32(cmB_CategSer.SelectedValue);
                }
                else
                {
                    dados.Cod_categ1 = Convert.ToInt32(cmB_CategSer.Text);
                }

                servicoModel.Editar(dados);
                MessageBox.Show("Dados do Serviço alterados com sucesso!");
                LimparCampos();
                DesabilitarCampos();
                CancelarAcao();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar os dados!!" + ex.Message);
            }
        }
        private void Excluir_dados(Servico dados)
        {
            try
            {

                dados.Cod_servico1 = Convert.ToInt32(txtB_Cod.Text);
                dados.Nomeserv = txtB_Nome.Text;

                servicoModel.Excluir(dados);
                LimparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir os dados!!" + ex.Message);
            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            btn_Novo.Visible = false;
            btn_Excluir.Visible = false;
            btn_Editar.Visible = false;
            btn_Salvar.Visible = true;
            btn_Cancelar.Visible = true;
            txtB_Nome.Focus();

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (txtB_Nome.Text == ""
              || txtB_Preco.Text == ""
              || cmB_CategSer.Text == null)
            {
                MessageBox.Show("Existem campos vazios! Verifique!");
            }
            else
            {
                Servico dados = new Servico();
                Envia_dados(dados);
                Carrega_Dados();
                LimparCampos();
                DesabilitarCampos();
                CancelarAcao();
            }
        }

        private void frm_CadServicos_Load(object sender, EventArgs e)
        {
            cmB_CategSer.DataSource = categoriaModel.ChamaListar();
            cmB_CategSer.ValueMember = "codcateg";
            cmB_CategSer.DisplayMember = "nomecateg";
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (txtB_Cod.Text == "")
            {
                MessageBox.Show("Selecione um registro/linha abaixo, que deseja editar");
                return;

            }
            if (txtB_Nome.Text == ""
               || txtB_Preco.Text == ""
               || cmB_CategSer.Text == null)
            {

                MessageBox.Show("Existem campos vazios, que precisam ser preenchidos!");
                txtB_Nome.Focus();
                return;

            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA EDITAR O REGISTRO SELECIONADO?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    Servico dados = new Servico();
                    Editar_dados(dados);
                    Carrega_Dados();
                    CancelarAcao();
                }
                else
                {
                    CancelarAcao();
                    Carrega_Dados();
                    LimparCampos();
                    return;
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            CancelarAcao();
            LimparCampos();
        }

        private void dGV_Servicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                HabilitarCampos();
                txtB_Cod.Text = dGV_Servicos.CurrentRow.Cells[0].Value.ToString();
                txtB_Nome.Text = dGV_Servicos.CurrentRow.Cells[1].Value.ToString();
                txtB_Preco.Text = dGV_Servicos.CurrentRow.Cells[2].Value.ToString();
                cmB_CategSer.Text = dGV_Servicos.CurrentRow.Cells[3].Value.ToString();
                btn_Editar.Visible = true;
                btn_Excluir.Visible = true;
                btn_Novo.Visible = false;
                btn_Cancelar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione uma linha válida!" + ex );
                DesabilitarCampos();
            }

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (txtB_Cod.Text == "")
            {
                MessageBox.Show("Selecione um registro/linha abaixo, que deseja ser exclída");
                return;

            }

            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR O REGISTRO SELECIONADO?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                HabilitarCampos();
                Servico dados = new Servico();
                Excluir_dados(dados);
                Carrega_Dados();

                CancelarAcao();
                LimparCampos();
                
            }
            else
            {
                Carrega_Dados();
                CancelarAcao();
                LimparCampos();
            }
        }
    }
}
