using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBarbearia.Entidades;
using System.Data;
using MySql.Data.MySqlClient;
using SistemaBarbearia.Model;
using System.Reflection;


namespace SistemaBarbearia.DAO
{
    public class AgendamentoDAO
    {
        MySqlCommand comandos_sql = null;


        Conexao conectar = new Conexao();

        public DataTable Listar()

        {

            try
            {

                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("SELECT tb_agendamento.codagendamento AS  'Código do Agendamento', tb_agendamento.dataagenda AS 'Data Agendada', tb_agendamento.hora AS 'Horário', tb_agendamento.totalserv AS 'Preço', tb_cliente.nome AS  'Nome Cliente', tb_funcionario.nome AS 'Nome Funcionário', tb_servico.nomeserv AS 'Nome Serviço' " +
                    "FROM(((tb_agendamento " +
                    "INNER JOIN tb_cliente ON tb_agendamento.tb_cliente_codclie = tb_cliente.codclie)" +
                    "INNER JOIN tb_servico ON tb_agendamento.tb_servico_codservico = tb_servico.codservico)" +
                    "INNER JOIN tb_funcionario ON tb_agendamento.tb_funcionario_codmatri = tb_funcionario.codmatri)", conectar.conexao);
               // comandos_sql = new MySqlCommand("SELECT codagendamento 'Codigo Agendamento', hora 'Horario Agendado', dataagenda 'Data Agendada', totalserv 'Valor do Servico'," +
               // " tb_funcionario_codmatri 'Codigo do Funcionario', tb_cliente_codclie 'Codigo do Cliente', tb_servico_codservico 'Codigo do Servico' FROM tb_agendamento", conectar.conexao);
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

        public void Salvar(Agendamento dados)
        {
            try
            {
                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("INSERT INTO tb_agendamento(hora, dataagenda, totalserv, tb_funcionario_codmatri, tb_cliente_codclie, tb_servico_codservico) VALUES(@horaagenda, @dataagenda, @totalserv, @tb_funcionario_codmatri, @tb_cliente_codclie, @tb_servico_codservico)", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("horaagenda", dados.Hora_Agenda);
                comandos_sql.Parameters.AddWithValue("@dataagenda", dados.Data_agenda);
                comandos_sql.Parameters.AddWithValue("@tb_cliente_codclie", dados.Cod_clie_agenda);
                comandos_sql.Parameters.AddWithValue("@tb_funcionario_codmatri", dados.Cod_func_agenda);
                comandos_sql.Parameters.AddWithValue("tb_servico_codservico", dados.Cod_servico_agenda);
                comandos_sql.Parameters.AddWithValue("@totalserv", dados.Totalserv);
                comandos_sql.ExecuteNonQuery();
                conectar.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Salvar" + ex.Message);
            }
        }


        public void Excluir(Agendamento dados)
        {

            try
            {
                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("DELETE FROM tb_agendamento Where codagendamento= @codagendamento", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@codagendamento", dados.Cod_agendamento);
                comandos_sql.ExecuteNonQuery();
                conectar.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar" + ex.Message);
            }
        }
        public void Editar(Agendamento dados)
        {
            
            try
            {
                conectar.AbrirConexao(); 
                comandos_sql = new MySqlCommand("UPDATE tb_agendamento SET hora = @horaagenda, dataagenda = @dataagenda, totalserv = @totalserv, tb_funcionario_codmatri =@tb_funcionario_codmatri, tb_cliente_codclie = @codclie, tb_servico_codservico = @codserv where codagendamento = @codagendamento", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@codagendamento", dados.Cod_agendamento);
                comandos_sql.Parameters.AddWithValue("@dataagenda", dados.Data_agenda);
                comandos_sql.Parameters.AddWithValue("horaagenda", dados.Hora_Agenda);
                comandos_sql.Parameters.AddWithValue("@totalserv", dados.Totalserv);
                comandos_sql.Parameters.AddWithValue("@tb_funcionario_codmatri", dados.Cod_func_agenda);
                comandos_sql.Parameters.AddWithValue("@codclie", dados.Cod_clie_agenda);
                comandos_sql.Parameters.AddWithValue("@codserv", dados.Cod_servico_agenda);
                comandos_sql.ExecuteNonQuery();
                conectar.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Editar" + ex.Message);
            }

        }
        public bool ValidacaoData(Agendamento dados)
        {
            try
            {
                bool taocupado = false;
                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("SELECT codagendamento " +
                    "FROM tb_agendamento where dataagenda = @dataagenda AND hora = @horaagenda", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@dataagenda", dados.Data_agenda);
                comandos_sql.Parameters.AddWithValue("@horaagenda", dados.Hora_Agenda);
                MySqlDataReader leitor = comandos_sql.ExecuteReader();
                if (leitor.Read())
                {
                    int id = Convert.ToInt32(leitor["codagendamento"]);
                    conectar.FecharConexao();

                    taocupado = id > 0;

                    return taocupado;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Métodos de buscas
        public DataTable Buscar(Agendamento dados)
        {
            try
            {

                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("select* FROM tb_agendamento WHERE  hora = @horaagenda AND dataagenda = @dataagenda", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@dataagenda", dados.Data_agenda);
                comandos_sql.Parameters.AddWithValue("@horaagenda", dados.Hora_Agenda);
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
        public DataTable BuscarClie(Agendamento dados)
        {
            try
            {

                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("select * FROM tb_agendamento WHERE tb_cliente_codclie=@codclie", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@codclie", dados.Cod_clie_agenda);
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


        public DataTable BuscarTudo(Agendamento dados)
        {
            try
            {

                conectar.AbrirConexao();
                comandos_sql = new MySqlCommand("select * FROM tb_agendamento WHERE hora=@horaagenda AND dataagenda=@dataagenda and tb_funcionario_codmatri=@codfunc AND tb_cliente_codclie=@codclie and tb_servico_codservico=@codserv", conectar.conexao);
                // comandos_sql = new MySqlCommand("select * FROM tb_agendamento WHERE hora=@horaagenda AND dataagenda=@dataagenda AND totalserv=@totalserv and tb_funcionario_codmatri=@codfunc AND tb_cliente_codclie=@codclie and tb_servico_codservico=@codserv", conectar.conexao);
                comandos_sql.Parameters.AddWithValue("@dataagenda", dados.Data_agenda);
                comandos_sql.Parameters.AddWithValue("@horaagenda", dados.Hora_Agenda);
                //comandos_sql.Parameters.AddWithValue("@totalserv", dados.Totalserv);
                comandos_sql.Parameters.AddWithValue("codfunc", dados.Cod_func_agenda);
                comandos_sql.Parameters.AddWithValue("codclie", dados.Cod_clie_agenda);
                comandos_sql.Parameters.AddWithValue("codserv", dados.Cod_servico_agenda);
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
