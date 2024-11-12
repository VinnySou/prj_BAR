using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBarbearia
{
    public class Conexao
    {

        
        String conexao_bd = "dataSource=localHost; username=root; password=123456; database=db_SisBarbearia";
        public MySqlConnection conexao = null;

        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conexao_bd);
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("OCORREU UM ERRO NA ABERTURA DO BANCO!! \n" + ex.Message);
            }
        }

        public void FecharConexao()
        {
            try
            {
                conexao = new MySqlConnection(conexao_bd);
                conexao.Close();

            }
            catch (Exception ex)
            {

            }
        }
       
    }
}
