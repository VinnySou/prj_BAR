using MySqlX.XDevAPI;
using SistemaBarbearia.DAO;
using SistemaBarbearia.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia.Model
{
    internal class ClientesModel
    {
        ClientesDAO clientesDAO = new ClientesDAO();

        public DataTable ChamaListar()

        {
            try
            {
                DataTable dt_listar = new DataTable();
                dt_listar = clientesDAO.Listar();
                return dt_listar;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Salvar(Clientes dados)
        {
            try
            {
                clientesDAO.Salvar(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar \n " + ex.Message);
            }
        }


        public void Editar(Clientes dados)
        {
            try
            {
                clientesDAO.Editar(dados);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Editar \n " + ex.Message);
            }
        }

        public void Excluir(Clientes dados)
        {
            try
            {
                clientesDAO.Excluir(dados);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Excluir \n " + ex.Message);
            }
        }
        public DataTable Buscar(Clientes dados)
        {
            try
            {
                DataTable dt_ListarClie = new DataTable();

                dt_ListarClie = clientesDAO.Buscar(dados);
                return dt_ListarClie;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

    }
}
