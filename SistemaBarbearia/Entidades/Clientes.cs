using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia.Entidades
{
    public class Clientes
    {
        string senha, login, telefone, nome, email, sexo, cpf;
        int codclie;
       

        public string Senha { get => senha; set => senha = value; }
        public string Login { get => login; set => login = value; }
         public string Telefone { get => telefone; set => telefone = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Codclie { get => codclie; set => codclie = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}
