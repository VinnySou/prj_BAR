using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia.Entidades
{
    public class Agendamento
    {
        int cod_agendamento, cod_func_agenda, cod_clie_agenda, cod_servico_agenda;
        DateTime data_agenda;
        decimal totalserv;
        string hora_Agenda;


        public int Cod_agendamento { get => cod_agendamento; set => cod_agendamento = value; }
        public DateTime Data_agenda { get => data_agenda; set => data_agenda = value; }
        public int Cod_func_agenda { get => cod_func_agenda; set => cod_func_agenda = value; }
        public int Cod_clie_agenda { get => cod_clie_agenda; set => cod_clie_agenda = value; }
        public decimal Totalserv { get => totalserv; set => totalserv = value; }
        public int Cod_servico_agenda { get => cod_servico_agenda; set => cod_servico_agenda = value; }
        public string Hora_Agenda { get => hora_Agenda; set => hora_Agenda = value; }
    }
}
