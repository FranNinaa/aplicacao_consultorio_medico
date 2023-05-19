using Apresentacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            frmPacienteConsultar FrmPacienteSelecionar = new frmPacienteConsultar();
            FrmPacienteSelecionar.Show();

        }

        private void buttonConsultas_Click(object sender, EventArgs e)
        {
            FormConsultas formConsultas = new FormConsultas();
            formConsultas.Show();
        }

        private void buttonMedico_Click(object sender, EventArgs e)
        {
            FormMedico formMedico = new FormMedico();
            formMedico.Show();
        }
    }
}
