using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia.Entidades
{
    public class Categoria
    {
    int codcateg;
    string nomecateg;

        public string Nomecateg { get => nomecateg; set => nomecateg = value; }
        public int Codcateg { get => codcateg; set => codcateg = value; }
    }
}
