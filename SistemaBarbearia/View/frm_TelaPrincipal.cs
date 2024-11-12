using SistemaBarbearia.View;
using System.DirectoryServices;


namespace SistemaBarbearia
{
    public partial class frm_TelaPrincipal : Form
    {
        public frm_TelaPrincipal()
        {
            InitializeComponent();
            
        }

       
        private void pROToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cADASTRARCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadClientes tela_clientes = new frm_CadClientes();
            tela_clientes.Show();
        }

        private void cADASTRARFUNCIONÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadFunc tela_Funcionario = new frm_CadFunc();
            tela_Funcionario.Show();
        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadServicos tela_Servicos = new frm_CadServicos();
            tela_Servicos.Show();
        }

        private void cADASTRARCATEGORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadCategoria tela_Categoria =  new frm_CadCategoria(); 
            tela_Categoria.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aGENDARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Agendamento tela_Agendamentos = new frm_Agendamento();
            tela_Agendamentos.Show();
        }

        private void pORDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_BuscaAgendamentos telaBusca = new frm_BuscaAgendamentos();
            telaBusca.BuscaData();
        }

        private void pORCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Buscas tela_Busca = new frm_Buscas();
            tela_Busca.BuscarClieform();
            tela_Busca.Carrega_DadosClie();
            tela_Busca.Show();
        }

        private void pESQUISAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_Buscas tela_Busca = new frm_Buscas();
            tela_Busca.BuscarServform();
            tela_Busca.Carrega_DadosServ();
            tela_Busca.Show();
        }

        private void aGENDAMENTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void vISUALIZARAGENDAMENTOSPORDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_BuscaAgendamentos tela_BuscaAgenda = new frm_BuscaAgendamentos();
            tela_BuscaAgenda.OcultarTudo();
            tela_BuscaAgenda.BuscaData();
            tela_BuscaAgenda.Show();
        }

        private void pORCLIENTEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_BuscaAgendamentos tela_BuscaAgenda = new frm_BuscaAgendamentos();
            tela_BuscaAgenda.OcultarTudo();
            tela_BuscaAgenda.BuscarClie();
            tela_BuscaAgenda.Show();
        }

        private void pORDATAEHORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_BuscaAgendamentos tela_BuscaAgenda = new frm_BuscaAgendamentos();
            tela_BuscaAgenda.OcultarTudo();
            tela_BuscaAgenda.BuscaData();
            tela_BuscaAgenda.Show();
        }

       
    }
}