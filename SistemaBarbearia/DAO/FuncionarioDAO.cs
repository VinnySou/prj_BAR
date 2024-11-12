using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using SistemaBarbearia.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaBarbearia.DAO
{
    internal class FuncionarioDAO
    {
        MySqlCommand comandos_sql = null;


        Conexao conectar = new Conexao();

        public DataTable Listar()

        {

            try
            {

                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("SELECT * FROM tb_funcionario", conectar.conexao);

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

        public void Salvar(Funcionario dados)
        {
            try
            {
                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("INSERT INTO tb_funcionario (nome, cpf, telefone, email, rua, bairro, uf, cidade, cep, login, senha, sexo)" + " VALUES(@nome, @cpf, @telefone, @email, @rua, @bairro, @uf, @cidade, @cep, @login, @senha, @sexo)", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@nome", dados.Nome);
                comandos_sql.Parameters.AddWithValue("@cpf", dados.Cpf);
                comandos_sql.Parameters.AddWithValue("@telefone", dados.Telefone);
                comandos_sql.Parameters.AddWithValue("@email", dados.Email);
                comandos_sql.Parameters.AddWithValue("@rua", dados.Rua);
                comandos_sql.Parameters.AddWithValue("@bairro", dados.Bairro);
                comandos_sql.Parameters.AddWithValue("@uf", dados.Uf);
                comandos_sql.Parameters.AddWithValue("@cidade", dados.Cidade);
                comandos_sql.Parameters.AddWithValue("@cep", dados.Cep);
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

        //ciração do metodo para exluir
        public void Excluir(Funcionario dados)
        {
            
            try
            {
                conectar.AbrirConexao();
               
                comandos_sql = new MySqlCommand("DELETE FROM tb_funcionario Where codmatri= @codmatri", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@codmatri", dados.Codmatri);
                comandos_sql.ExecuteNonQuery();
                //fechando conexao
                conectar.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar" + ex.Message);
            }
        }

       

        public void Editar(Funcionario dados)
        {
            
            try
            {
                conectar.AbrirConexao(); 
                comandos_sql = new MySqlCommand("UPDATE tb_funcionario SET nome = @nome, cpf = @cpf, telefone = @telefone, email = @email, rua = @rua, bairro = @bairro, uf = @uf, cidade = @cidade, cep = @cep, login = @login, senha = @senha, sexo = @sexo WHERE codmatri = @codmatri",conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@codmatri", dados.Codmatri);
                comandos_sql.Parameters.AddWithValue("@nome", dados.Nome);
                comandos_sql.Parameters.AddWithValue("@cpf", dados.Cpf);
                comandos_sql.Parameters.AddWithValue("@login", dados.Login);
                comandos_sql.Parameters.AddWithValue("@senha", dados.Senha);
                comandos_sql.Parameters.AddWithValue("@bairro", dados.Bairro);
                comandos_sql.Parameters.AddWithValue("@cidade", dados.Cidade);
                comandos_sql.Parameters.AddWithValue("@uf", dados.Uf);
                comandos_sql.Parameters.AddWithValue("@cep", dados.Cep);
                comandos_sql.Parameters.AddWithValue("@rua", dados.Rua);
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



        public bool Dados_LoginFunc(Funcionario dadosUS)
        {
            try
            {
                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("SELECT codmatri, login, senha FROM tb_funcionario where login = @login AND senha = @senha",
                conectar.conexao);

                comandos_sql.Parameters.AddWithValue("@login", dadosUS.Login);
                comandos_sql.Parameters.AddWithValue("@senha", dadosUS.Senha);

                MySqlDataReader leitor = comandos_sql.ExecuteReader();


                if (leitor.Read())
                {
                    int id = Convert.ToInt32(leitor["codmatri"]);
                    conectar.FecharConexao();
                    return id > 0;
                }

                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
    }
}
