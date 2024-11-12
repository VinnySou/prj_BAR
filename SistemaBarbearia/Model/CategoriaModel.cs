using SistemaBarbearia.DAO;
using SistemaBarbearia.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBarbearia.DAO;
using SistemaBarbearia.Entidades;
using SistemaBarbearia.View;

namespace SistemaBarbearia.Model
{
    internal class CategoriaModel
    {
        CategoriaDAO categoriaDAO = new CategoriaDAO();

        public DataTable ChamaListar()

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

        public void Salvar(Categoria dados)
        {
            try
            {
                categoriaDAO.Salvar(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar \n " + ex.Message);
            }
        }
        public void Editar(Categoria dados)
        {
            try
            {
                categoriaDAO.Editar(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Editar \n " + ex.Message);
            }
        }
        public void Excluir(Categoria dados)
        {
            try
            {
                categoriaDAO.Excluir(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Excluir \n " + ex.Message);
            }
        }
    }
}
