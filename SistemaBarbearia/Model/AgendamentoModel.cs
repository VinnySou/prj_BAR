using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBarbearia.DAO;
using SistemaBarbearia.Entidades;
using SistemaBarbearia.View;
using System.Data;
using MySql.Data.MySqlClient;

namespace SistemaBarbearia.Model
{
    public class AgendamentoModel
    {

        AgendamentoDAO agendamentoDAO = new AgendamentoDAO();
        public void Salvar(Agendamento dados)
        {
            try
            {
                agendamentoDAO.Salvar(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar \n " + ex.Message);
            }
        }

        public object ChamaListar()
        {
            try
            {
                DataTable dt_listar = new DataTable();
                dt_listar = agendamentoDAO.Listar();
                return dt_listar;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Editar(Agendamento dados)
        {
            try
            {
                agendamentoDAO.Editar(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Editar \n " + ex.Message);
            }
        }

        public void Excluir(Agendamento dados)
        {
            try
            {
                agendamentoDAO.Excluir(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Excluir \n " + ex.Message);
            }
        }

        public object Buscar(Agendamento dados)
        {
            try
            {
                DataTable dt_listar = new DataTable();
                dt_listar = agendamentoDAO.Buscar(dados);
                return dt_listar;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public object BuscarTudo(Agendamento dados)
        {
            try
            {
                DataTable dt_listar = new DataTable();
                dt_listar = agendamentoDAO.BuscarTudo(dados);
                return dt_listar;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public object BuscarClie(Agendamento dados)
        {
            try
            {
                DataTable dt_listar = new DataTable();
                dt_listar = agendamentoDAO.BuscarClie(dados);
                return dt_listar;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public bool ConfirmaData(Agendamento dados)
        {
            try
            {
                bool bRetorno = agendamentoDAO.ValidacaoData(dados);
                return bRetorno;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show("Ocorreu um erro ao encontar VERIFICAR A DISPONIBILIDADE " + msg);
                return false;
            }

        }

    }
}
