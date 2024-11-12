using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia.Entidades
{
    public class Funcionario
    {
        string senha, login, cidade, bairro, rua, telefone, nome, cep, uf, email, sexo, cpf;
        int codmatri; 
        

        public string Senha { get => senha; set => senha = value; }
        public string Login { get => login; set => login = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Email { get => email; set => email = value; }
        public int Codmatri { get => codmatri; set => codmatri = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}
