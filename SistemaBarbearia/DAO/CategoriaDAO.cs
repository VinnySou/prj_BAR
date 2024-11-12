using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SistemaBarbearia.Entidades;
using SistemaBarbearia.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaBarbearia.DAO
{
    public class CategoriaDAO
    {
        MySqlCommand comandos_sql = null;
        Conexao conectar = new Conexao();

        public DataTable Listar()

        {
            try
            {

                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("SELECT * FROM tb_categoria", conectar.conexao);

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

        public void Salvar(Categoria dados)
        {
            try
            {
                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("INSERT INTO tb_categoria (nomecateg)" + " VALUES(@nomecateg)", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@nomecateg", dados.Nomecateg);

                comandos_sql.ExecuteNonQuery();
                conectar.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar" + ex.Message);
            }
        }

        public void Excluir(Categoria dados)
        {
        
            try
            {
                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("DELETE FROM tb_categoria Where codcateg= @codcateg", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@codcateg", dados.Codcateg);
                comandos_sql.ExecuteNonQuery();
                conectar.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar" + ex.Message);
            }
        }


        public void Editar(Categoria dados)
        {
            
            try
            {
                conectar.AbrirConexao(); 
                comandos_sql = new MySqlCommand("UPDATE tb_categoria SET nomecateg = @nomecateg WHERE codcateg = @codcateg",
                 conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@nomecateg", dados.Nomecateg);
                comandos_sql.Parameters.AddWithValue("codcateg", dados.Codcateg);


                comandos_sql.ExecuteNonQuery();
                conectar.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar" + ex.Message);
            }
        }
    }
}
