using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apresentacao;
using ObjetoTransferencia;
using RegraNegocios;

namespace Apresentacao
{
    public partial class FormCadastroPaciente : Form
    {
        AcaoNaTela acaoNaTelaSelecionado;

        //CONSTRUTOR ele constroi (a tela )interface como definimos
        public FormCadastroPaciente(AcaoNaTela acaoNaTela, Paciente paciente)
        {
            InitializeComponent();

            this.acaoNaTelaSelecionado = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Cliente";


            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Cliente";

                textCodigo.Text = paciente.Idpaciente.ToString();
                comboBoxSexo.Text = paciente.Sexo;
                textNumero.Text = paciente.Numero;
                textNome.Text = paciente.NomePaciente;
                textEndereco.Text = paciente.Endereco;
                textBairro.Text = paciente.Bairro;
                textCep.Text = paciente.Cep;
                textTelefone.Text = paciente.Telefone;
                textCelular.Text = paciente.Celular;

            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Cliente";

                //carregar na da tela
                textCodigo.Text = paciente.Idpaciente.ToString();
                comboBoxSexo.Text = paciente.Sexo;
                textNumero.Text = paciente.Numero;
                textNome.Text = paciente.NomePaciente;
                textEndereco.Text = paciente.Endereco;
                textBairro.Text = paciente.Bairro;
                textCep.Text = paciente.Cep;
                textTelefone.Text = paciente.Telefone;
                textCelular.Text = paciente.Celular;

                //desabilitar campos na tela
                comboBoxSexo.Enabled = false;
                comboBoxSexo.TabStop = true;

                textNome.ReadOnly = true;
                textNome.TabStop = false;

                textEndereco.ReadOnly = true;
                textEndereco.TabStop = false;

                textBairro.ReadOnly = true;
                textBairro.TabStop = false;

                textNumero.ReadOnly = true;
                textNumero.TabStop = false;

                textCidade.ReadOnly = true;
                textCidade.TabStop = false;

                textCep.ReadOnly = true;
                textCep.TabStop = false;

                textTelefone.ReadOnly = true;
                textTelefone.TabStop = false;

                textCelular.ReadOnly = true;
                textCelular.TabStop = false;

                buttonSalvar.Visible = false;

                buttonCancelar.Text = "Fechar";

                buttonCancelar.Focus();



            }

        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //verifica se tem inserção do paciente ou será alteração
            if (acaoNaTelaSelecionado == AcaoNaTela.Inserir)
            {
                Paciente paciente = new Paciente();

                paciente.NomePaciente = textNome.Text;
                paciente.Sexo = comboBoxSexo.Text;
                paciente.Endereco = textEndereco.Text;
                paciente.Bairro = textBairro.Text;
                paciente.Numero = textNumero.Text;
                paciente.Cidade = textCidade.Text;
                paciente.Cep = textCep.Text;
                paciente.Telefone = textTelefone.Text;
                paciente.Celular = textCelular.Text;

                PacienteNegocios pacienteNegocios = new PacienteNegocios();
                string retorno = pacienteNegocios.Inserir(paciente);

                //tenta converter para inteiro
                //se dar errado é por q devolve o dódigo do erro
                //se der errado mensagem de erro
                try
                {
                    int idPaciente = Convert.ToInt32(retorno);

                    MessageBox.Show("Paciente Adicionado com Sucesso. Código: " + idPaciente.ToString());
                    this.DialogResult = DialogResult.Yes;

                }
                catch (Exception)
                {

                    MessageBox.Show("Não foi possivel Adiciona o Paciente. Detalhes: " + retorno);
                    this.DialogResult = DialogResult.No;
                }

            }
            else if (acaoNaTelaSelecionado == AcaoNaTela.Alterar)
            {
                //cria um novo paciente
                Paciente paciente = new Paciente();

                //coloco os campos da tel DO objeto paciente e envio para o banco de dados 
                paciente.Idpaciente = Convert.ToInt32(textCodigo.Text);
                paciente.NomePaciente = textNome.Text;
                paciente.Sexo = comboBoxSexo.Text;
                paciente.Endereco = textEndereco.Text;
                paciente.Bairro = textBairro.Text;
                paciente.Numero = textNumero.Text;
                paciente.Cidade = textCidade.Text;
                paciente.Cep = textCep.Text;
                paciente.Telefone = textTelefone.Text;
                paciente.Celular = textCelular.Text;

                PacienteNegocios pacienteNegocios = new PacienteNegocios();
                string retorno = pacienteNegocios.Alterar(paciente);

                //tenta converter para inteiro
                //se dar certo ele atualiza os dados do paciente
                //se der errado mensagem de erro
                try
                {
                    int idPaciente = Convert.ToInt32(retorno);

                    MessageBox.Show("Paciente Alterado com Sucesso. Código: " + idPaciente.ToString());
                    this.DialogResult = DialogResult.Yes;

                }
                catch (Exception)
                {

                    MessageBox.Show("Não foi possivel alterar o Paciente. Detalhes: " + retorno);
                    this.DialogResult = DialogResult.No;
                }
            }
        }
    }
}
