using System;

namespace ObjetoTransferencia
{
    public class Consultas
    {
        public int IDconsultaConsulta { get; set; }
        public int idPacienteConsulta { get; set; }
        public int idMedicoConsulta { get; set; }
        public string NomeMedico { get; set; }
        public string NomePaciente { get; set; }

        public string Data { get; set; }
        public string Horario { get; set; }
        public string Retorno { get; set; }

    }
}
