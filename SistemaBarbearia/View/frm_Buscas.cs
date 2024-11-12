using MySqlX.XDevAPI;
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
    public partial class frm_Buscas : Form
    {
        CategoriaModel categoriaModel = new CategoriaModel();
        ServicoModel servicoModel = new ServicoModel();
        ClientesModel clientesModel = new ClientesModel();
        public frm_Buscas()
        {
            InitializeComponent();

        }
       
        public void Carrega_DadosServ()
        {
            try
            {
                dGV_Busca.DataSource = servicoModel.ChamaListar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de conexão! " + ex.Message);
            }

        }
        public void BuscarClieform()
        {
            lbl_NomeServ.Visible = false;
            lbl_ServCateg.Visible = false;
            txtB_NomeServ.Visible = false;
            cmB_CategServ.Visible = false;
            btn_BuscarServ.Visible = false;
            btn_PorNome.Visible = false;
            btn_MostarServ.Visible = false;
            btn_MostrarClie.Visible = true;
            lbl_Cliente.Visible = true;
            txtB_NomeClie.Visible = true;
        }
        public void Carrega_DadosClie()
        {
            try
            {
                dGV_Busca.DataSource = clientesModel.ChamaListar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro de conexão! " + ex.Message);
            }

        }

        public void BuscarServform()
        {
            lbl_NomeServ.Visible = true;
            lbl_ServCateg.Visible = true;
            txtB_NomeServ.Visible = true;
            cmB_CategServ.Visible = true;
            btn_BuscarServ.Visible = true;
            lbl_Cliente.Visible = false;
            txtB_NomeClie.Visible = false;
            btn_BuscarClie.Visible = false;
            btn_PorNome.Visible = true;
            btn_MostarServ.Visible = true;
            btn_MostrarClie.Visible = false;
        }

        public void BuscarClie(Clientes dados)
        {
            try
            {
                dados.Nome = txtB_NomeClie.Text;

                dGV_Busca.DataSource = clientesModel.Buscar(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os dados!!" + ex.Message);

            }
        }
        public void BuscarServNome(Servico dados)
        {
            try
            {
                dados.Nomeserv = txtB_NomeServ.Text;
                dados.Cod_categ1 = Convert.ToInt32(cmB_CategServ.SelectedValue);

                dGV_Busca.DataSource = servicoModel.BuscarNome(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os dados!!" + ex.Message);

            }
        }

        public void BuscarServ(Servico dados)
        {
            try
            {
                dados.Cod_categ1 = Convert.ToInt32(cmB_CategServ.SelectedValue);

                dGV_Busca.DataSource = servicoModel.Buscar(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os dados!!" + ex.Message);

            }
        }

        private void btn_BuscarClie_Click(object sender, EventArgs e)
        {
            if (txtB_NomeClie.Text != "")
            {
                Clientes dados = new Clientes();
                BuscarClie(dados);
            }
            else
            {
                MessageBox.Show("Digite o Nome do Cliente que deseja buscar");
            }
        }

        private void btn_BuscarServ_Click(object sender, EventArgs e)
        {
            if (cmB_CategServ.Text != null)
            {
                Servico dados = new Servico();
                BuscarServ(dados);
            }
            else
            {
                MessageBox.Show("Selecione a Categoria que Deseja Buscar!");
            }
        }

        private void frm_Buscas_Load(object sender, EventArgs e)
        {
            cmB_CategServ.DataSource = categoriaModel.ChamaListar();
            cmB_CategServ.ValueMember = "codcateg";
            cmB_CategServ.DisplayMember = "nomecateg";
        }

        private void btn_PorNome_Click(object sender, EventArgs e)
        {
            if (txtB_NomeServ.Text != "")
            {
                Servico dados = new Servico();
                BuscarServNome(dados);
            }
            else
            {
                MessageBox.Show("Digite o Nome do Serviço que deseja buscar!");
            }
        }

        private void btn_MostrarClie_Click(object sender, EventArgs e)
        {
            txtB_NomeClie.Text = "";
            Carrega_DadosClie();
        }

        private void btn_MostarServ_Click(object sender, EventArgs e)
        {
            cmB_CategServ.Text = "";
            txtB_NomeServ.Text = "";
            Carrega_DadosServ();
        }
    }
}
