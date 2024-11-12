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
using SistemaBarbearia.DAO;
using SistemaBarbearia.Entidades;
using SistemaBarbearia.Model;

namespace SistemaBarbearia.View
{
    public partial class frm_BuscaAgendamentos : Form
    {
        FuncionarioModel funcionarioModel = new FuncionarioModel();
        ServicoModel servicoModel = new ServicoModel();
        ClientesModel clientesModel = new ClientesModel();
        AgendamentoDAO agendamentoDAO = new AgendamentoDAO();
        AgendamentoModel agendamentoModel = new AgendamentoModel();
        public frm_BuscaAgendamentos()
        {
            InitializeComponent();
            LimparCampos();

        }
        private void frm_Busca_Load(object sender, EventArgs e)
        {
            
            Carrega_Dados();
            cmB_Cliente.DataSource = clientesModel.ChamaListar();
            cmB_Cliente.ValueMember = "codclie";
            cmB_Cliente.DisplayMember = "nome";


            cmB_Serv.DataSource = servicoModel.ChamaListar();
            cmB_Serv.DisplayMember = "nomeserv";

            cmB_Func.DataSource = funcionarioModel.ChamaListar();
            cmB_Func.ValueMember = "codmatri";
            cmB_Func.DisplayMember = "nome";
            LimparCampos();
        }
        public void LimparCampos()
        {
            cmB_Cliente.Text = "";
            cmB_Func.Text = "";
            cmB_Horario.Text = "";
            cmB_Serv.Text = "";
        }
        public void Carrega_Dados()
        {
            try
            {
                dGV_BuscarAgenda.DataSource = agendamentoModel.ChamaListar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de conexão! " + ex.Message);
            }
        }
        public void OcultarTudo()
        {
            btn_Completa.Visible = false;
            btn_BuscarClie.Visible = false;
            lbl_Cliente.Visible = false;
            lbl_Serv.Visible = false;
            lbl_Hora.Visible = false;
            lbl_Func.Visible = false;
            lbl_Data.Visible = false;
            cmB_Cliente.Visible = false;
            cmB_Func.Visible = false;
            cmB_Horario.Visible = false;
            cmB_Serv.Visible = false;
            dTP_Buscar.Visible = false;
            btn_Cancelar.Visible = false;
        }
        public void BuscaData()
        {
            OcultarTudo();
            btn_Cancelar.Visible = true;
            btn_BuscarDt.Visible = true;
            cmB_Horario.Visible = true;
            lbl_Hora.Visible=true;
            lbl_Data.Visible=true;
            dTP_Buscar.Visible=true;
            dGV_BuscarAgenda.Visible = true;

        }
        public void BuscarClie()
        {
            OcultarTudo();
            lbl_Cliente.Visible = true;
            cmB_Cliente.Visible = true;
            btn_BuscarClie.Visible = true;
            btn_Completa.Visible=false;
            btn_BuscarDt.Visible = false;
            btn_Cancelar.Visible = true;
        }
        public void BuscarTudo()
        {   
            btn_BuscarDt.Visible = false;
            btn_BuscarClie.Visible =false;
            btn_Completa.Visible=true;
            dGV_BuscarAgenda.Visible = true;
            btn_BuscarClie.Visible = false;
            lbl_Cliente.Visible = true;
            lbl_Serv.Visible = true;
            lbl_Hora.Visible = true;
            lbl_Func.Visible = true;
            lbl_Data.Visible = true;
            cmB_Cliente.Visible = true;
            cmB_Func.Visible = true;
            cmB_Horario.Visible = true;
            cmB_Serv.Visible = true;
            dTP_Buscar.Visible = true;
            btn_Cancelar.Visible = true;
        }

        public void BuscarData(Agendamento dados)
        {
          
            try
            {
                dados.Data_agenda = Convert.ToDateTime(dTP_Buscar.Text);
                dados.Hora_Agenda = Convert.ToString(cmB_Horario.Text);

                dGV_BuscarAgenda.DataSource = agendamentoModel.Buscar(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os dados!!" + ex.Message);

            }
        }
        public void BuscaCompleta(Agendamento dados)
        {
            try
            {
                dados.Data_agenda = Convert.ToDateTime(dTP_Buscar.Text);
                dados.Hora_Agenda = Convert.ToString(cmB_Horario.Text);
                dados.Cod_clie_agenda = Convert.ToInt32(cmB_Cliente.SelectedValue);
                dados.Cod_func_agenda = Convert.ToInt32(cmB_Func.SelectedValue);
                dados.Cod_servico_agenda = Convert.ToInt32(cmB_Serv.SelectedValue);
                dGV_BuscarAgenda.DataSource = agendamentoModel.BuscarTudo(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os dados!!" + ex.Message);

            }
        }
        public void BuscaClie(Agendamento dados)
        {
            try
            {

                dados.Cod_clie_agenda = Convert.ToInt32(cmB_Cliente.SelectedValue);
                dGV_BuscarAgenda.DataSource = agendamentoModel.BuscarClie(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os dados!!" + ex.Message);

            }
        }
        private void btn_BuscarComp_Click(object sender, EventArgs e)
        {
            if (cmB_Horario.Text != "")
            {
                Agendamento dados = new Agendamento();
                BuscarData(dados);
            }
            else
            {
                MessageBox.Show("Selecione o horário que deseja buscar!");
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Carrega_Dados();
        }

        private void btn_Completa_Click(object sender, EventArgs e)
        {
            OcultarTudo();

            Agendamento dados = new Agendamento();
            BuscaCompleta(dados);
            BuscarTudo();
        }

        private void btn_BuscarClie_Click(object sender, EventArgs e)
        {
            if (cmB_Cliente.Text != "")
            {
                Agendamento dados = new Agendamento();
                BuscaClie(dados);
            }
            else
            {
                MessageBox.Show("Selecione o Cliente que deseja buscar!");
            }
            
        }
    }
}
