using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SistemaBarbearia.DAO;
using SistemaBarbearia.Entidades;
using MySql.Data.MySqlClient;
using SistemaBarbearia.View;

namespace SistemaBarbearia.Model
{
    public class ServicoModel
    {

        ServicoDAO servicoDAO = new ServicoDAO();
        CategoriaDAO categoriaDAO = new CategoriaDAO();
        public void Salvar(Servico dados)
        {
            try
            {
                servicoDAO.Salvar(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar \n " + ex.Message);
            }
        }

        public object ChamaListarCateg()
        {
            try
            {
                DataTable dt_listar = new DataTable();
                dt_listar = categoriaDAO.Listar();
                return dt_listar;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public object ChamaListar()
        {
            try
            {
                DataTable dt_listar = new DataTable();
                dt_listar = servicoDAO.Listar();
                return dt_listar;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public object ChamarServ()
        {
            try
            {
                DataTable dt_listar = new DataTable();
                dt_listar = servicoDAO.CarregarServ();
                return dt_listar;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Editar(Servico dados)
        {
            try
            {
                servicoDAO.Editar(dados);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Editar \n " + ex.Message);
            }
        }

        public void Excluir(Servico dados)
        {
            try
            {
                servicoDAO.Excluir(dados);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Excluir \n " + ex.Message);
            }
        }

        public object Buscar(Servico dados)
        {
            try
            {
                DataTable dt_listar = new DataTable();
                dt_listar = servicoDAO.Buscar(dados);
                return dt_listar;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public object BuscarNome(Servico dados)
        {
            try
            {
                DataTable dt_listar = new DataTable();
                dt_listar = servicoDAO.BuscarServNome(dados);
                return dt_listar;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public object BuscarPreco(Servico dados)
        {
            try
            {
                DataTable dt_listar = new DataTable();
                dt_listar = servicoDAO.BuscarServ(dados);
                return dt_listar;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
