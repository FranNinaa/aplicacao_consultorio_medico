using ObjetoTransferencia;
using System;
using System.Data;
using AcessoBancoDados;
using System.Text;


namespace RegraNegocios
{
    public class PacienteNegocios
    {
        //INSTANCIAR = CRIAR UM NOVO OBJETO BASEADO EM UM MODELO
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Paciente paciente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionaParametros("@NomePaciente", paciente.NomePaciente);
                acessoDadosSqlServer.AdicionaParametros("@Endereco", paciente.Endereco);
                acessoDadosSqlServer.AdicionaParametros("@Numero", paciente.Numero);
                acessoDadosSqlServer.AdicionaParametros("@Bairro", paciente.Bairro);
                acessoDadosSqlServer.AdicionaParametros("@Cidade", paciente.Cidade);
                acessoDadosSqlServer.AdicionaParametros("@Cep", paciente.Cep);
                acessoDadosSqlServer.AdicionaParametros("@Telefone", paciente.Telefone);
                acessoDadosSqlServer.AdicionaParametros("@Calular", paciente.Celular);
                acessoDadosSqlServer.AdicionaParametros("@Sexo", paciente.Sexo);
               
                

                string IDpaciente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "usPacienteInserir").ToString();

                return IDpaciente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string Alterar(Paciente paciente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionaParametros("@IDpaciente", paciente.Idpaciente);
                acessoDadosSqlServer.AdicionaParametros("@NomePaciente", paciente.NomePaciente);
                acessoDadosSqlServer.AdicionaParametros("@Endereco", paciente.Endereco);
                acessoDadosSqlServer.AdicionaParametros("@Numero", paciente.Numero);
                acessoDadosSqlServer.AdicionaParametros("@Bairro", paciente.Bairro);
                acessoDadosSqlServer.AdicionaParametros("@Cidade", paciente.Cidade);
                acessoDadosSqlServer.AdicionaParametros("@Cep", paciente.Cep);
                acessoDadosSqlServer.AdicionaParametros("@Telefone", paciente.Telefone);
                acessoDadosSqlServer.AdicionaParametros("@Calular", paciente.Celular);
                acessoDadosSqlServer.AdicionaParametros("@Sexo", paciente.Sexo);
              
                


                string idpaciente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPacienteAlterar").ToString();

                return idpaciente;

            }
            catch (Exception exeption)
            {

                return exeption.Message;
            }
        }
        public string Excluir(Paciente paciente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionaParametros("@IDpaciente", paciente.Idpaciente);
                string IDpaciente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPacienteExcluir").ToString();



                return IDpaciente;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }


        public PacienteColecao ConsultarPorNome(string nome)
        {
            try
            {
                //CRIAR UMA COLEÇÃO NOVA DE CLIENTES
                PacienteColecao pacienteColecao = new PacienteColecao();


                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionaParametros("@NomePaciente", nome);

                //DATA = DADOS E TABLE= TABELA / ROW = LINHAS / FOREACH = PARA CADA
                DataTable dataTablePaciente = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspPacienteConsultarPorNome");

                //PERCORRER O DATA TABLE  E TRANSFORMAR EM COLEÇÃO
                //CADA LINHA DO DataTable É UM CLIENTE
                 //DataRow - Linha de Dados
                foreach (DataRow linha in dataTablePaciente.Rows)
                {
                    //CRIAR UM CLIENTE VAZIO - COLOCAR OS DADOS NA LINHA DELE - ADICIONA NA COLEÇÃO
                    Paciente paciente = new Paciente();

                    paciente.Idpaciente = Convert.ToInt32(linha["IDpaciente"]);
                    paciente.NomePaciente = Convert.ToString(linha["NomePaciente"]);
                    paciente.Endereco = Convert.ToString(linha["Endereco"]);
                    paciente.Numero = Convert.ToString(linha["Numero"]);
                    paciente.Bairro = Convert.ToString(linha["Bairro"]);
                    paciente.Cidade = Convert.ToString(linha["Cidade"]);
                    paciente.Cep = Convert.ToString(linha["Cep"]);
                    paciente.Telefone = Convert.ToString(linha["Telefone"]);
                    paciente.Celular = Convert.ToString(linha["Calular"]);
                    paciente.Sexo = Convert.ToString(linha["Sexo"]);
                   
                    

                    pacienteColecao.Add(paciente);

                }

                return pacienteColecao;
            }
            catch (Exception ex)
            {

                throw new Exception("Não foi possivel consultar o paciente pelo nome --> " +  ex.Message);
            }
        }
        public PacienteColecao ConsultarPorID(int idpaciente)
        {
            try
            {
                PacienteColecao pacienteColecao = new PacienteColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionaParametros("@IDpaciente", idpaciente);
                DataTable dataTablePaciente = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspPacienteConsultarPorID");

                foreach (DataRow row in dataTablePaciente.Rows)
                {
                    Paciente paciente = new Paciente();
                   

                    paciente.Idpaciente = Convert.ToInt32(row["IDpaciente"]);
                    paciente.NomePaciente = Convert.ToString(row["NomePaciente"]);
                    paciente.Endereco = Convert.ToString(row["Endereco"]);
                    paciente.Numero = Convert.ToString(row["Numero"]);
                    paciente.Bairro = Convert.ToString(row["Bairro"]);
                    paciente.Cidade = Convert.ToString(row["Cidade"]);
                    paciente.Cep = Convert.ToString(row["Cep"]);
                    paciente.Telefone = Convert.ToString(row["Telefone"]);
                    paciente.Celular = Convert.ToString(row["Calular"]);
                    paciente.Sexo = Convert.ToString(row["Sexo"]);
                 
                   

                    pacienteColecao.Add(paciente);

                }

                return pacienteColecao;

            }
            catch (Exception ex)
            {

                throw new Exception(" Não foi possivel consultar o Paciente pelo codigo --> " + ex.Message);

            }
        }

    }
}
