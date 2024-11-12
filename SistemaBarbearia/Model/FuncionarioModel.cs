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
    internal class FuncionarioModel
    {
        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();



        public DataTable ChamaListar()

        {
            try
            {
                DataTable dt_listar = new DataTable();
                dt_listar = funcionarioDAO.Listar();
                return dt_listar;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Salvar(Funcionario dados)
        {
            try
            {
                funcionarioDAO.Salvar(dados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar \n " + ex.Message);
            }
        }
        public void Editar(Funcionario dados)
        {
            try
            {
                funcionarioDAO.Editar(dados);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Editar \n " + ex.Message);
            }
        }
      
        public void Excluir(Funcionario dados)
        {
            try
            {
                funcionarioDAO.Excluir(dados);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao Excluir \n " + ex.Message);
            }
        }
    }
}
