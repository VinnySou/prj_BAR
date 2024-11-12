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

namespace SistemaBarbearia
{
    public partial class frm_TelaInicial : Form
    {
        Funcionario dados = new Funcionario();
        LoginModel loginModel = new LoginModel();
        public frm_TelaInicial()
        {
            
            InitializeComponent();
            TelaLogin();
            txtB_Senha.UseSystemPasswordChar = true;
            btn_Ocultar.Visible = false;
            btn_Menu.Visible = false;
        }

      
        public void TelaLogin()
        {
            lbl_User.Visible = true;
            lbl_Senha.Visible = true;
            txtB_Login.Visible = true;
            txtB_Senha.Visible = true;
            btn_Entrar.Visible = true;
            btn_Visivel.Visible = true;
            btn_Ocultar.Visible = true;
        }

        public void TelaLogado()
        {
            btn_Ocultar.Visible = false;
            btn_Visivel.Visible = false;
            lbl_User.Visible = false;
            lbl_Senha.Visible = false;
            txtB_Login.Visible = false;
            txtB_Senha.Visible = false;
            btn_Entrar.Visible = false;

        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            TelaLogin();
            
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {

            dados.Login = txtB_Login.Text;
            dados.Senha = txtB_Senha.Text;

            bool conectou = loginModel.Confirma_Login(dados);


            if (conectou == true)
            {
                
                frm_TelaPrincipal telaPrincipal = new frm_TelaPrincipal();
                telaPrincipal.ShowDialog();
                TelaLogado();
                btn_Menu.Visible = true;



            }
            else
            {
                MessageBox.Show("Login ou senha incorretos, tente novamente");
            }
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
            btn_Visivel.Visible = false;
            btn_Ocultar.Visible = true;
        }
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            frm_TelaPrincipal telaPrincipal = new frm_TelaPrincipal();
            telaPrincipal.ShowDialog();
        }
    }
}
