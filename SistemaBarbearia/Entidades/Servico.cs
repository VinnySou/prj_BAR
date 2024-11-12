using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia.Entidades
{
    public class Servico
    {
        string nomeserv;
        decimal preco_serv;
        int Cod_categ, Cod_servico, cod_itensAgenda;

        public string Nomeserv { get => nomeserv; set => nomeserv = value; }
        public decimal Preco_serv { get => preco_serv; set => preco_serv = value; }
        public int Cod_categ1 { get => Cod_categ; set => Cod_categ = value; }
        public int Cod_servico1 { get => Cod_servico; set => Cod_servico = value; }
        public int Cod_itensAgenda { get => cod_itensAgenda; set => cod_itensAgenda = value; }
    }
}
