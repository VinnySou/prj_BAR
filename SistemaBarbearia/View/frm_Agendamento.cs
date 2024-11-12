using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBarbearia.View;
using SistemaBarbearia.Model;
using SistemaBarbearia.DAO;
using SistemaBarbearia.Entidades;

namespace SistemaBarbearia.View
{
    public partial class frm_Agendamento : Form
    {

        Agendamento dados = new Agendamento();
        AgendamentoModel agendamentoModel = new AgendamentoModel();
        ServicoModel servicoModel = new ServicoModel();
        CategoriaModel categoriaModel = new CategoriaModel();
        ClientesModel clientesModel = new ClientesModel();
        FuncionarioModel funcionarioModel = new FuncionarioModel();

        public frm_Agendamento()
        {
            InitializeComponent();
            Carrega_Dados();
            LimparCampos();
            dTP_Agendamento.CustomFormat = ("dd/MM/yyyy");
            btn_Cancelar.Visible = false;
            btn_Editar.Visible = false;
            btn_Excluir.Visible = false;
            btn_Agendar.Visible = false;
            cmB_Valor.Enabled = false;
            DesabilitarCampos();

        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            frm_CadClientes tela_CadClientes = new frm_CadClientes();
            tela_CadClientes.Show();
        }

        private void frm_Agendamento_Load(object sender, EventArgs e)
        {
            cmB_Servico.ValueMember = null;
            cmB_Valor.Text = null;

            cmB_Cliente.DataSource = clientesModel.ChamaListar();
            cmB_Cliente.ValueMember = "codclie";
            cmB_Cliente.DisplayMember = "nome";

            
            cmB_Func.DataSource = funcionarioModel.ChamaListar();
            cmB_Func.ValueMember = "codmatri";
            cmB_Func.DisplayMember = "nome";

            cmB_Servico.DataSource = servicoModel.ChamarServ();
            cmB_Servico.ValueMember = "codservico";
            cmB_Servico.DisplayMember = "nomeserv";

            LimparCampos();
        }
        public void DesabilitarCampos()
        {
            cmB_Cliente.Enabled = false;
            cmB_Func.Enabled = false;
            cmB_Hora.Enabled = false;
            cmB_Servico.Enabled = false;
            dTP_Agendamento.Enabled = false;
            btn_Novo.Enabled = false;
            btn_Atualizar.Enabled = false;
        }
        public void HabilitarCampos()
        {
            cmB_Cliente.Enabled = true;
            cmB_Func.Enabled = true;
            cmB_Hora.Enabled = true;
            cmB_Servico.Enabled = true;
            dTP_Agendamento.Enabled = true;
            btn_Atualizar.Enabled = true;
            btn_Novo.Enabled = true;
        }

        public void LimparCampos()
        {
            txtB_Cod.Text = "";
            cmB_Cliente.Text = null;
            cmB_Func.Text = null;
            cmB_Hora.Text = null;
            cmB_Servico.Text = null;
            cmB_Valor.Text = null;
            dTP_Agendamento.Text = null;

        }


        public void BuscarValores(Servico dados)
        {
            try
            {
                dados.Cod_servico1 = Convert.ToInt32(cmB_Servico.SelectedValue);
                cmB_Valor.DataSource = servicoModel.BuscarPreco(dados);
                cmB_Valor.ValueMember = "precoserv";
                cmB_Valor.DisplayMember = "precoserv";

            }
            catch (Exception ex)
            {

                string msg = ex.Message;

            }
        }

        public void Editar_dados(Agendamento dados)
        {
            try
            {

                dados.Cod_agendamento = Convert.ToInt32(txtB_Cod.Text);
                dados.Cod_clie_agenda = Convert.ToInt32(cmB_Cliente.SelectedValue);
                dados.Cod_servico_agenda = Convert.ToInt32(cmB_Servico.SelectedValue);
                dados.Cod_func_agenda = Convert.ToInt32(cmB_Func.SelectedValue);
                dados.Data_agenda = Convert.ToDateTime(dTP_Agendamento.Text);
                dados.Totalserv = Convert.ToInt32(cmB_Valor.Text);
                dados.Hora_Agenda = cmB_Hora.SelectedItem.ToString();

                agendamentoModel.Editar(dados);
                MessageBox.Show("Dados do agendamento alterados com sucesso!");
                LimparCampos();
                btn_Cancelar.Visible = false;
                btn_Editar.Visible = false;
                btn_Excluir.Visible = false;
                btn_NovoAgen.Visible = true;
                DesabilitarCampos();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar os dados!!" + ex.Message);
            }

        }

        public void Excluir_dados(Agendamento dados)
        {
            try
            {

                dados.Cod_agendamento = Convert.ToInt32(txtB_Cod.Text);
                agendamentoModel.Excluir(dados);
                MessageBox.Show("Agendamento excluído com sucesso!");
                LimparCampos();
                btn_Cancelar.Visible = false;
                btn_Editar.Visible = false;
                btn_Excluir.Visible = false;
                btn_NovoAgen.Visible = true;
                DesabilitarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir os dados!!" + ex.Message);
            }

        }



        public void Carrega_Dados()
        {
            try
            {
                dGV_Agendamentos.DataSource = agendamentoModel.ChamaListar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de conexão! " + ex.Message);
            }

        }
        public void Envia_dados(Agendamento dados)
        {
            try
            {

                dados.Cod_clie_agenda = Convert.ToInt32(cmB_Cliente.SelectedValue);
                dados.Cod_servico_agenda = Convert.ToInt32(cmB_Servico.SelectedValue);
                dados.Cod_func_agenda = Convert.ToInt32(cmB_Func.SelectedValue);
                dados.Data_agenda = Convert.ToDateTime(dTP_Agendamento.Text);
                dados.Totalserv = Convert.ToInt32(cmB_Valor.Text);
                dados.Hora_Agenda = cmB_Hora.SelectedItem.ToString();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar os dados!!" + ex.Message);
            }

        }


        public void btn_Agendar_Click(object sender, EventArgs e)
        {
            if (cmB_Cliente.SelectedValue == null
           || cmB_Func.SelectedValue == null
           || cmB_Servico.SelectedValue == null
           || cmB_Valor.Text == null
           || dTP_Agendamento.Text == null
           || cmB_Hora.Text == null)
            {
                MessageBox.Show("Existem campos vazios, verifique!");
            }
            else
            {
                Agendamento dados = new Agendamento();
                Envia_dados(dados);
                bool temagenda = agendamentoModel.ConfirmaData(dados);


                if (!temagenda)
                {

                    
                    Carrega_Dados();
                    MessageBox.Show("O horário está disponivel! Agendamento salvo com sucesso!");
                    LimparCampos();
                    btn_NovoAgen.Visible = true;
                    btn_Agendar.Visible = false;
                    btn_Cancelar.Visible = false;
                    agendamentoModel.Salvar(dados);
                    Carrega_Dados();
                    DesabilitarCampos();
                }
                else
                {
                    MessageBox.Show("Horário Indisponível!");
                    Carrega_Dados();

                }
            }
        }
        private void cmB_Servico_SelectedValueChanged(object sender, EventArgs e)
        {
            Servico dados = new Servico();
            BuscarValores(dados);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            btn_Cancelar.Visible = true;
            if (txtB_Cod.Text == "")
            {
                MessageBox.Show("Selecione um registro/linha abaixo, que deseja editar");
                return;

            }
            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA EDITAR O REGISTRO SELECIONADO?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Agendamento dados = new Agendamento();
                Editar_dados(dados);
                Carrega_Dados();
                btn_Cancelar.Visible = false;

            }
            else
            {
                Carrega_Dados();
                LimparCampos();
                btn_Editar.Visible = false;
                btn_Excluir.Visible = false;
                btn_NovoAgen.Visible = true;
                btn_Cancelar.Visible = false;
                DesabilitarCampos();
            }
        }

        private void dGV_Agendamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos();
            try
            {
                txtB_Cod.Text = dGV_Agendamentos.CurrentRow.Cells[0].Value.ToString();
                cmB_Cliente.Text = dGV_Agendamentos.CurrentRow.Cells[4].Value.ToString();
                cmB_Func.Text = dGV_Agendamentos.CurrentRow.Cells[5].Value.ToString();
                cmB_Valor.Text = dGV_Agendamentos.CurrentRow.Cells[3].Value.ToString();
                dTP_Agendamento.Text = dGV_Agendamentos.CurrentRow.Cells[1].Value.ToString();
                cmB_Hora.Text = dGV_Agendamentos.CurrentRow.Cells[2].Value.ToString();
                cmB_Servico.Text = dGV_Agendamentos.CurrentRow.Cells[6].Value.ToString();
                btn_Editar.Visible = true;
                btn_Excluir.Visible = true;
                btn_NovoAgen.Visible = false;
                btn_Cancelar.Visible = true;
                btn_Agendar.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione uma linha válida!");
                DesabilitarCampos();
            }
        }



        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btn_Agendar.Visible = false;
            btn_NovoAgen.Visible = true;
            btn_Editar.Visible = false;
            btn_Excluir.Visible = false;
            btn_Cancelar.Visible = false;
            DesabilitarCampos();
            

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (txtB_Cod.Text == "")
            {
                MessageBox.Show("Selecione um registro/linha abaixo, que deseja ser excluída");
                return;

            }

            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA QUE DESEJA EXCLUIR O REGISTRO SELECIONADO?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                HabilitarCampos();
                Agendamento dados = new Agendamento();
                Excluir_dados(dados);
                Carrega_Dados();
                btn_Editar.Visible = false;
                btn_Excluir.Visible = false;
                btn_NovoAgen.Visible = true;
                btn_Cancelar.Visible = false;
                DesabilitarCampos();
            }
            else
            {
                Carrega_Dados();
                LimparCampos();
                btn_Editar.Visible = false;
                btn_Excluir.Visible = false;
                btn_NovoAgen.Visible = true;
                btn_Cancelar.Visible = false;
                DesabilitarCampos();
            }
        }

        private void btn_NovoAgen_Click(object sender, EventArgs e)
        {
            btn_NovoAgen.Visible = false;
            btn_Agendar.Visible = true;
            btn_Editar.Visible = false;
            btn_Excluir.Visible = false;
            btn_Cancelar.Visible = true;
            HabilitarCampos();
            LimparCampos();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            cmB_Cliente.DataSource = clientesModel.ChamaListar();
            cmB_Cliente.ValueMember = "codclie";
            cmB_Cliente.DisplayMember = "nome";

          
            cmB_Func.DataSource = funcionarioModel.ChamaListar();
            cmB_Func.ValueMember = "codmatri";
            cmB_Func.DisplayMember = "nome";

            cmB_Servico.DataSource = servicoModel.ChamaListar();
            cmB_Servico.ValueMember = "codservico";
            cmB_Servico.DisplayMember = "nomeserv";
            LimparCampos();
        }
        private void cmB_Servico_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void lbl_CliqueGrid_Click(object sender, EventArgs e)
        {

        }
    }
}
