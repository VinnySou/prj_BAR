using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBarbearia.Entidades;
using SistemaBarbearia.DAO;

namespace SistemaBarbearia.Model
{
    public class LoginModel
    {

        FuncionarioDAO   funcionario = new FuncionarioDAO();




        public bool Confirma_Login(Funcionario dadosUS)
        {
            try
            {
                bool bRetorno = funcionario.Dados_LoginFunc(dadosUS);

                return bRetorno;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao encontar o seus dados de login e senha", ex.Message);
                return false;
            }

        }
    }
}
