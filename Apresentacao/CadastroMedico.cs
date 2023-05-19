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
using System;


namespace Apresentacao
{
    public partial class FormCadastroMedico : Form
    {
        AcaoNaTela acaoSelecionado;

        //construtor 
        public FormCadastroMedico(AcaoNaTela acao, Medico medico)
        {
            InitializeComponent();

            acaoSelecionado = acao;

            if (acao == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Médico";
                //textNomeMedico.Text = medico.NomeMedico;
                //TextTelefone.Text = medico.TelefoneMedico;
                //txtValorConsulta.Text = medico.ValorConsulta.ToString();
            }
            else if (acao == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Médico";

                textCodigo.Text = medico.IDmedico.ToString();
                textNomeMedico.Text = medico.NomeMedico;
                TextTelefone.Text = medico.TelefoneMedico;
                txtValorConsulta.Text = medico.ValorConsulta.ToString();

            }
            else if (acao == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Médico";

                textCodigo.Text = medico.IDmedico.ToString();
                textNomeMedico.Text = medico.NomeMedico;
                TextTelefone.Text = medico.TelefoneMedico;
                txtValorConsulta.Text = medico.ValorConsulta.ToString();

                //desabilitar campos da tela
                textNomeMedico.ReadOnly = true;
                textNomeMedico.TabStop = false;

                TextTelefone.ReadOnly = true;
                TextTelefone.TabStop = false;

                

                txtValorConsulta.ReadOnly = true;
                txtValorConsulta.TabStop = false;

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
            if (acaoSelecionado == AcaoNaTela.Inserir)
            {
                Medico medico = new Medico();
                medico.NomeMedico = textNomeMedico.Text;
              
                medico.TelefoneMedico = TextTelefone.Text;
                medico.ValorConsulta = txtValorConsulta.Text;

                MedicoNegocios medicoNegocios = new MedicoNegocios();
                string retorno = medicoNegocios.Inserir(medico);

                //tenta converter para inteiro
                //se dar certo é por q devolveu o código do cliente
                //se der errado mensagem de erro

                try
                {
                    int idMedico = Convert.ToInt32(retorno);
                    MessageBox.Show("Médico Adicionado com Sucesso. Código: " + idMedico.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {

                    MessageBox.Show("Não foi possivel Adiciona um novo Médico. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }
            else if (acaoSelecionado == AcaoNaTela.Consultar)
            {

            }
        }
    }
}
