
using ObjetoTransferencia;
using RegraNegocios;
using Apresentacao;

namespace Apresentacao
{
    public partial class FormMedico : Form
    {

        //CONSTRUTOR
        public FormMedico()
        {
            InitializeComponent();
            dataGridViewMedico.AutoGenerateColumns = false;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            MedicoNegocios medicoNegocios = new MedicoNegocios();
            MedicoColecao medicoColecao = new MedicoColecao();

            medicoColecao = medicoNegocios.ConsultarMedicoNome(textNomeMedico.Text);

            dataGridViewMedico.DataSource = null;
            dataGridViewMedico.DataSource = medicoColecao;

            dataGridViewMedico.Update();
            dataGridViewMedico.Refresh();
        }
        private void buttonSalvarMedico_Click(object sender, EventArgs e)
        {


        }
        private void buttonAlterarMedico_Click(object sender, EventArgs e)
        {
            //verificar se tem algum registro selecionado
            if (dataGridViewMedico.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Médico Selecionado !");
                return;
            }
            //pegar o médico selecionado no grid
            Medico? medicoSelecionado = (dataGridViewMedico.SelectedRows[0].DataBoundItem as Medico);


            FormCadastroMedico formCadastroMedico = new FormCadastroMedico(AcaoNaTela.Alterar, medicoSelecionado);
            DialogResult dialogResult = formCadastroMedico.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }

        }

        private void buttonConsultarMedico_Click(object sender, EventArgs e)
        {

            //verificar se tem algum registro selecionado
            if (dataGridViewMedico.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Médico Selecionado !");
                return;
            }
            //pegar o cliente selecionado no grid
            Medico? medicoSelecionado = (dataGridViewMedico.SelectedRows[0].DataBoundItem as Medico);

            FormCadastroMedico formCadastroMedico = new FormCadastroMedico(AcaoNaTela.Consultar, medicoSelecionado);
            formCadastroMedico.ShowDialog();

            AtualizarGrid();

        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {

            //instanciar o formulario de cadastro
            FormCadastroMedico formCadastroMedico = new FormCadastroMedico(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = formCadastroMedico.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }

        }


    }
}
