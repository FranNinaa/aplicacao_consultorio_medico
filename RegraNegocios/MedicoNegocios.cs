using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados;

namespace RegraNegocios
{
    public class MedicoNegocios
    {
        //INSTANCIAR = CRIAR UM NOVO OBJETO BASEADO EM UM MODELO
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Medico medico)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionaParametros("@NomeMedico", medico.NomeMedico);
                acessoDadosSqlServer.AdicionaParametros("@TelefoneMedico", medico.TelefoneMedico);
                acessoDadosSqlServer.AdicionaParametros("@ValorConsulta", medico.ValorConsulta);
               

                string IDmedico = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "proMedicoInserir").ToString();

                return IDmedico;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }
        public string Alterar(Medico medico)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionaParametros("@IDmedico", medico.IDmedico);
                acessoDadosSqlServer.AdicionaParametros("@NomeMedico", medico.NomeMedico);
                acessoDadosSqlServer.AdicionaParametros("@TelefoneMedico", medico.TelefoneMedico);
                acessoDadosSqlServer.AdicionaParametros("@ValorConsulta", medico.ValorConsulta);
               

                string IDmedico = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMedicoAlterar").ToString();

                return IDmedico;
            }
            catch (Exception exeption)
            {

                return exeption.Message;
            }

        }

        public string Excluir(Medico medico)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionaParametros("@IDmedico", medico.IDmedico);
                
                string IDmedico = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspMedicoExcluir").ToString();



                return IDmedico;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        public MedicoColecao ConsultarMedicoNome(string medicoNome)
        {
           
            try
            {
                MedicoColecao medicoColecao = new MedicoColecao();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionaParametros("@NomeMedico", medicoNome);

                DataTable dataTableMedico = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspMedicoConsultarPorNome");

                foreach (DataRow linha in dataTableMedico.Rows)
                {
                    Medico medico = new Medico();


                    medico.IDmedico = Convert.ToInt32(linha["IDmedico"]);
                    medico.NomeMedico = Convert.ToString(linha["NomeMedico"]);
                    medico.TelefoneMedico = Convert.ToString(linha["TelefoneMedico"]);
                    medico.ValorConsulta = Convert.ToString(linha["ValorConsulta"]);
                   


                    medicoColecao.Add(medico);
                }
                return medicoColecao;


            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel consultar o Médico pelo nome --> " + ex.Message);
            }

        }
        public MedicoColecao ConsultarPorID(int idMedico)
        {
            try
            {
                MedicoColecao medicoColecao = new MedicoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionaParametros("@IDmedico", idMedico);
                DataTable dataTableMedico = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspMedicoConsultarPorID");

                foreach (DataRow row in dataTableMedico.Rows)
                {
                    Medico medico = new Medico();
                    medicoColecao.Add(medico);

                    medico.IDmedico = Convert.ToInt32(row["IDmedico"]);
                    medico.NomeMedico = Convert.ToString(row["NomeMedico"]);
                    medico.TelefoneMedico = Convert.ToString(row["TelefoneMedico"]);
                    medico.ValorConsulta = Convert.ToString(row["ValorConsulta"]);

                    medicoColecao.Add(medico);

                }
                return medicoColecao;
            }
            catch (Exception ex)
            {

                throw new Exception(" Não foi possivel consultar o Médico pelo codigo ! Detalhes --> \n" + ex.Message);

            }
        }

       
    }
}
