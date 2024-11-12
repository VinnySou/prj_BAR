using MySql.Data.MySqlClient;
using SistemaBarbearia.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia.DAO
{
    internal class ClientesDAO
    {
        MySqlCommand comandos_sql = null;


        Conexao conectar = new Conexao();

        public DataTable Listar()

        {

            try
            {

                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("SELECT * FROM tb_cliente", conectar.conexao);

                MySqlDataAdapter pesq_dados = new MySqlDataAdapter();

                pesq_dados.SelectCommand = comandos_sql;

                DataTable dados_tabela = new DataTable();

                pesq_dados.Fill(dados_tabela);


                return dados_tabela;

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
                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("INSERT INTO tb_cliente (nome, cpf, telefone, email, login, senha, sexo)" + " VALUES(@nome, @cpf, @telefone, @email, @login, @senha, @sexo)", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@nome", dados.Nome);
                comandos_sql.Parameters.AddWithValue("@cpf", dados.Cpf);
                comandos_sql.Parameters.AddWithValue("@telefone", dados.Telefone);
                comandos_sql.Parameters.AddWithValue("@email", dados.Email);
                comandos_sql.Parameters.AddWithValue("@login", dados.Login);
                comandos_sql.Parameters.AddWithValue("@senha", dados.Senha);
                comandos_sql.Parameters.AddWithValue("@sexo", dados.Sexo);
                comandos_sql.ExecuteNonQuery();
                conectar.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar" + ex.Message);
            }
        }

       
        public void Excluir(Clientes dados)
        {

            try
            {
                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("DELETE FROM tb_cliente Where codclie= @codclie", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@codclie", dados.Codclie);
                comandos_sql.ExecuteNonQuery();
                conectar.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar" + ex.Message);
            }
        }

        

        public void Editar(Clientes dados)
        {
          
            try
            {
                conectar.AbrirConexao(); 
                comandos_sql = new MySqlCommand("UPDATE tb_cliente SET nome = @nome, cpf = @cpf, telefone = @telefone, email = @email, login = @login, senha = @senha, sexo = @sexo WHERE codclie = @codclie", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@codclie", dados.Codclie);
                comandos_sql.Parameters.AddWithValue("@nome", dados.Nome);
                comandos_sql.Parameters.AddWithValue("@cpf", dados.Cpf);
                comandos_sql.Parameters.AddWithValue("@login", dados.Login);
                comandos_sql.Parameters.AddWithValue("@senha", dados.Senha);
                comandos_sql.Parameters.AddWithValue("@email", dados.Email);
                comandos_sql.Parameters.AddWithValue("@telefone", dados.Telefone);
                comandos_sql.Parameters.AddWithValue("@sexo", dados.Sexo);

                comandos_sql.ExecuteNonQuery();
                conectar.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar" + ex.Message);
            }
        }
        public DataTable Buscar(Clientes dados)
        {
            try
            {

                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("SELECT * FROM tb_cliente WHERE nome = @nome", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@nome", dados.Nome);

                MySqlDataAdapter pesq_venda = new MySqlDataAdapter();

                pesq_venda.SelectCommand = comandos_sql;

                DataTable dados_tabela = new DataTable();

                pesq_venda.Fill(dados_tabela);


                return dados_tabela;

            }

            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

