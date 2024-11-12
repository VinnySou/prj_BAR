using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SistemaBarbearia.Model;
using MySql.Data.MySqlClient;
using SistemaBarbearia.Entidades;
using Org.BouncyCastle.Utilities.Collections;

namespace SistemaBarbearia.DAO
{
    public class ServicoDAO
    {
        MySqlCommand comandos_sql = null;


        Conexao conectar = new Conexao();

        
        public DataTable Listar()

        {

            try
            {

                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("select tb_servico.codservico as 'Código do Serviço', tb_servico.nomeserv  as 'Nome do Serviço', tb_servico.precoserv as 'Preço do Serviço', tb_categoria.nomecateg as 'Categoria do Serviço'" +
                    "from tb_servico inner join tb_categoria on tb_servico.tb_categoria_codcateg = tb_categoria.codcateg", conectar.conexao);

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
        public DataTable CarregarServ()

        {

            try
            {

                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("select * from tb_servico", conectar.conexao);

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

        public void Salvar(Servico dados)
        {
            try
            {
                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("INSERT INTO tb_servico (`nomeserv`, `precoserv`, `tb_categoria_codcateg`)" + "VALUES(@nomeserv, @precoserv, @tb_categoria_codcateg);", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@nomeserv", dados.Nomeserv);
                comandos_sql.Parameters.AddWithValue("@precoserv", dados.Preco_serv);
                comandos_sql.Parameters.AddWithValue("@tb_categoria_codcateg", dados.Cod_categ1);
                comandos_sql.ExecuteNonQuery();
                conectar.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar" + ex.Message);
            }
        }

        public void Excluir(Servico dados)
        {

            try
            {
                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("DELETE FROM tb_servico where codservico = @codservico", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@codservico", dados.Cod_servico1);
                comandos_sql.ExecuteNonQuery();
                conectar.FecharConexao();
                MessageBox.Show("Dados do Serviço excluídos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Excluir" + ex.Message);
            }
        }

        public DataTable BuscarServ(Servico dados)
        {

            try
            {

                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("SELECT precoserv FROM tb_servico where codservico = @codservico", conectar.conexao);
                
                comandos_sql.Parameters.AddWithValue("@codservico", dados.Cod_servico1);

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
        public DataTable BuscarServNome(Servico dados)
        {

            try
            {

                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("SELECT * FROM tb_servico where nomeserv = @nomeserv", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@nomeserv", dados.Nomeserv);

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

        public void Editar(Servico dados)
        {
          
            try
            {
                conectar.AbrirConexao(); 
                comandos_sql = new MySqlCommand("UPDATE tb_servico SET nomeserv = @nomeserv, precoserv = @precoserv, tb_categoria_codcateg = @tb_categoria_codcateg where codservico = @codservico", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@codservico", dados.Cod_servico1);
                comandos_sql.Parameters.AddWithValue("@nomeserv", dados.Nomeserv);
                comandos_sql.Parameters.AddWithValue("@precoserv", dados.Preco_serv);
                comandos_sql.Parameters.AddWithValue("@tb_categoria_codcateg", dados.Cod_categ1);
               // comandos_sql.Parameters.AddWithValue("@tb_itens_agenda_cod_itens_agenda", dados.Cod_itensAgenda);
                comandos_sql.ExecuteNonQuery();
                conectar.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar" + ex.Message);
            }

        }

        public DataTable Buscar(Servico dados)
        {
            try
            {

                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("SELECT * FROM tb_servico where tb_categoria_codcateg = @tb_categoria_codcateg", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@tb_categoria_codcateg", dados.Cod_categ1);
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
