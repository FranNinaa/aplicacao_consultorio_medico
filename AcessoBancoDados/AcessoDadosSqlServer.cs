using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//name spaces que manipulam dados no banco de dados sql server
using System.Data;
using System.Data.SqlClient; 
using AcessoBancoDados.Properties;

namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        //cria conexão
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.StringConexao);

        }
        //parametros que vão para o banco
        private SqlParameterCollection parameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            parameterCollection.Clear();
        }
        public void AdicionaParametros(string NomeParametro, object ValorParametro)
        {
            parameterCollection.Add(new SqlParameter(NomeParametro, ValorParametro));
        }
        //persitencia inserir, alterar excluir
        public object ExecutarManipulacao(CommandType commandType, string nomeProcedureOuTextoSql)
        {
            try
            {
                //CRIAR A CONEXAO 
                SqlConnection connection = CriarConexao();

                //ABRIR CONEXAO
                connection.Open();

                //CRIAR UM COMANDO
                SqlCommand command = connection.CreateCommand();

                //COLOCANDO AS COISAS DENTRO DO COMANDO, DENTRO DA CAIXA QUE VAI TRAFEGAR
                command.CommandType = commandType;
                command.CommandText = nomeProcedureOuTextoSql;
                command.CommandTimeout = 7200;    //segundos=2h em execucao

                //ADICIONA OS PARAMETROS 
                foreach (SqlParameter sqlParameter in parameterCollection)
                {
                    command.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

                }
                //EXECUTAR O COMANDO OU SEJA MANDO O COMANDO IR NO BANCO DE DADOS
                return command.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }
        public DataTable ExecutaConsulta(CommandType commandType, string nomePocedureOuTextoSql)
        {
            //CONSULTAR REGISTRO NO BANCO DE DADOS
            try
            {
                SqlConnection connection = CriarConexao();
                connection.Open();
                SqlCommand sqlCommand = connection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomePocedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;

                //ADICIONAR PARAMETROS NO COMANDO
                foreach (SqlParameter sqlParameter in parameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

                }

                //CRIAR ADAPTADOR
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                //data table que é uma tabela de dados vazia - AONDE QUE VOU COLOCAR OS DADOS QUE VEM DO BANCO DE DADOS
                DataTable dataTable = new DataTable();

                //MANDA O COMANDO IR ATE O BANDO DE DADOS PARA PREENCHER ESSA TABELA VAZIA
                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

    }

}

