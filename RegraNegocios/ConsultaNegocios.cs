using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AcessoBancoDados;

namespace RegraNegocios
{
    public  class ConsultaNegocios
    {
        //INSTANCIAR = CRIAR UM NOVO OBJETO BASEADO EM UM MODELO
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Consultas consultas)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionaParametros("@idPaciente", consultas.idPacienteConsulta);
                acessoDadosSqlServer.AdicionaParametros("@idMedico", consultas.idMedicoConsulta);
                acessoDadosSqlServer.AdicionaParametros("@NomeMedico", consultas.NomeMedico);
                acessoDadosSqlServer.AdicionaParametros("@NomePaciente", consultas.NomePaciente);
                acessoDadosSqlServer.AdicionaParametros("@Retorno", consultas.Retorno);
                acessoDadosSqlServer.AdicionaParametros("@Data", consultas.Data);
                acessoDadosSqlServer.AdicionaParametros("@Horario", consultas.Horario);
                string IDconsultas = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "usConsultaInserir").ToString();

                return IDconsultas;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
           
        }
       public string Alterar(Consultas consultas)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionaParametros("@IDconsulta", consultas.IDconsultaConsulta);
                acessoDadosSqlServer.AdicionaParametros("@idPaciente", consultas.idPacienteConsulta);
                acessoDadosSqlServer.AdicionaParametros("@idMedico", consultas.idMedicoConsulta);
                acessoDadosSqlServer.AdicionaParametros("@NomeMedico", consultas.NomeMedico);
                acessoDadosSqlServer.AdicionaParametros("@NomePaciente", consultas.NomePaciente);
                acessoDadosSqlServer.AdicionaParametros("@Retorno", consultas.Retorno );
                acessoDadosSqlServer.AdicionaParametros("@Data", consultas.Data);
                acessoDadosSqlServer.AdicionaParametros("@Horario", consultas.Horario);

                string IDconsulta = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "usConsultaAlterar").ToString();
                return IDconsulta;


            }
            catch (Exception exeption)
            {

                return exeption.Message;
            }
        }
        public string Excluir(Consultas consultas)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionaParametros("@IDconsulta", consultas.IDconsultaConsulta);
                
                string IDconsulta = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "usConsultaExcluir").ToString();



                return IDconsulta;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public ConsultaColecao ConsultarPorNomePaciente( string NomePaciente)
        {
            try
            {
                //CRIAR UMA COLEÇÃO NOVA DE CLIENTES
                ConsultaColecao consultaColecao = new ConsultaColecao();


                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionaParametros("@NomePaciente", NomePaciente);
               

                DataTable dataTableConsulta = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "usConsultaConsultarPorNomePaciente");

                //PERCORRER O DATA TABLE  E TRANSFORMAR EM COLEÇÃO
                //CADA LINHA DO DataTable É UM CLIENTE
                //DATA = DADOS / ROW = LINHAS / FOREACH = PARA CADA

                foreach (DataRow linha in dataTableConsulta.Rows)
                {
                    //CRIAR UM CLIENTE VAZIO - COLOCAR OS DADOS NA LINHA DELE - ADICIONA NA COLEÇÃO
                    Consultas  consultas  = new Consultas();

                    consultas.IDconsultaConsulta = Convert.ToInt32(linha["IDconsulta"]);
                    consultas.idMedicoConsulta = Convert.ToInt32(linha["idMedico"]);
                    consultas.idPacienteConsulta = Convert.ToInt32(linha["idPaciente"]);
                    consultas.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    consultas.NomeMedico = Convert.ToString(linha["NomeMedico"]);
                    consultas.Horario = Convert.ToString(linha["Horario"]);
                    consultas.Data = Convert.ToString(linha["Data"]);
                    consultas.Retorno = Convert.ToString(linha["Retorno"]);
               
                    consultaColecao.Add(consultas);

                }

                return consultaColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel consultar o paciente pelo nome --> " + ex.Message);
            }
        }
        public ConsultaColecao consultarConsultasID(int idConsultas)
        {
            try
            {
                ConsultaColecao consultaColecao = new ConsultaColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionaParametros("@IDconsulta", idConsultas);
                DataTable dataTableConsulta= acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "usConsultaConsultarPorID");

                foreach (DataRow row in dataTableConsulta.Rows)
                {

                    Consultas consultas  = new Consultas();
                    consultaColecao.Add(consultas);

                    consultas.IDconsultaConsulta = Convert.ToInt32(row["IDconsulta"]);
                    consultas.idPacienteConsulta = Convert.ToInt32(row["idPaciente"]);
                    consultas.idMedicoConsulta = Convert.ToInt32(row["idMedico"]);
                    consultas.NomeMedico = Convert.ToString(row["NomeMedico"]);
                    consultas.NomePaciente = Convert.ToString(row["NomePaciente"]);
                    consultas.Data = Convert.ToString(row["Data"]);
                    consultas.Horario = Convert.ToString(row["Horario"]);
                    consultas.Retorno = Convert.ToString(row["Retorno"]);
                    consultaColecao.Add(consultas);

                }
                return consultaColecao;
            }
            catch (Exception ex)
            {

                throw new Exception(" Não foi possivel consultar essa Informação: Detalhes --> " + ex.Message);

            }
        }
    }
}
