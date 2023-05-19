using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegraNegocios;

namespace Apresentacao
{
    public partial class FormCadastroConsulta : Form
    {
        AcaoNaTela acaoTelaSelecionado;
        public FormCadastroConsulta(AcaoNaTela acaoTela, Consultas consultas)
        {
            InitializeComponent();

            this.acaoTelaSelecionado = acaoTela;

            if (acaoTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Consulta";
            }
            else if (acaoTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Consulta";

                textBoxCodigo.Text = consultas.IDconsultaConsulta.ToString();
                textNomeMedico.Text = consultas.NomeMedico;
                textData.Text = consultas.Data;
                textNomePaciente.Text = consultas.NomePaciente;
                textHora.Text = consultas.Horario;
                comboBoxRetorno.Text = consultas.Retorno;
            }
            else if (acaoTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Consulta Médica";

                //carregar campos na tela 
                textBoxCodigo.Text = consultas.IDconsultaConsulta.ToString();
                textNomeMedico.Text = consultas.NomeMedico;
                textData.Text = consultas.Data;
                textNomePaciente.Text = consultas.NomePaciente;
                textHora.Text = consultas.Horario;
                comboBoxRetorno.Text = consultas.Retorno;

                //desabilitar campos na tela
                textNomeMedico.ReadOnly = true;
                textNomeMedico.TabStop = false;

                textData.ReadOnly = true;
                textData.TabStop = false;

                textNomePaciente.ReadOnly = true;
                textNomePaciente.TabStop = false;

                textHora.ReadOnly = true;
                textHora.TabStop = false;

                comboBoxRetorno.Visible = true;

                buttonSalvar.Visible = false;
                buttonCancelar.Text = "Fechar";

                buttonCancelar.Focus();


            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //verifica se é inserção ou alteração
            if (acaoTelaSelecionado == AcaoNaTela.Inserir)
            {
                Consultas consultas = new Consultas();
                consultas.NomeMedico = textNomeMedico.Text;
                consultas.NomePaciente = textNomePaciente.Text;
                consultas.Data = textData.Text;
                consultas.Horario = textHora.Text;
                consultas.Retorno = comboBoxRetorno.Text;

                ConsultaNegocios consultaNegocios = new ConsultaNegocios();
                string retorno = consultaNegocios.Inserir(consultas);

                //tenta converter para inteiro
                //se dar errado é por q devolve o dódigo do erro
                //se der errado mensagem de erro

                try
                {
                    int idConsulta = Convert.ToInt32(retorno);
                    MessageBox.Show("Consulta Adicionada com Sucesso. Código:  " + idConsulta.ToString());

                    //vai fechar a tela e avisa que o resultado foi positivo
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {

                    MessageBox.Show("Não foi possivel Adiciona uma nova consulta. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;

                }


            }
            else if (acaoTelaSelecionado == AcaoNaTela.Alterar)
            {
                Consultas consultas = new Consultas();

            }
        }
    }
}
