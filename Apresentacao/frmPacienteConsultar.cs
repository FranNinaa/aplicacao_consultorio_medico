using Apresentacao;
using ObjetoTransferencia;
using RegraNegocios;

namespace Apresentacao
{
    public partial class frmPacienteConsultar : Form
    {
        public frmPacienteConsultar()
        {
            InitializeComponent();

            dataGridViewPacientes.AutoGenerateColumns = false;
        }

        private void butonPesquisar_Click(object sender, EventArgs e)
        {
            AtulizarGrid();
        }
        private void AtulizarGrid()
        {

            PacienteNegocios pacienteNegocios = new PacienteNegocios();
            PacienteColecao pacienteColecao = new PacienteColecao();
            pacienteColecao = pacienteNegocios.ConsultarPorNome(textPesquisa.Text);

            dataGridViewPacientes.DataSource = null;
            dataGridViewPacientes.DataSource = pacienteColecao;

            dataGridViewPacientes.Update();
            dataGridViewPacientes.Refresh();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            //verifica se tem alguma paciente selecionado
            if (dataGridViewPacientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Paciente Salecionado !");
                return;
            }

            //pergunta se quer excluir mesmo
            DialogResult resultado = MessageBox.Show(" Tem certeza da Exclusão ? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {

                return;
            }

            //pega o paciente selecionado no grid
            Paciente? pacienteSelecionado = (dataGridViewPacientes.SelectedRows[0].DataBoundItem as Paciente);

            //instancia a regra de negocio 
            PacienteNegocios pacienteNegocios = new PacienteNegocios();

            //chama o metodo exlcuir
            string retorno = pacienteNegocios.Excluir(pacienteSelecionado);


            try
            {
                //veririfica se excluiu com sucesso
                //se o retorno for número é por que deu certo, senão é a mensagem de erro.

                string IDpaciente = retorno;
                MessageBox.Show("Paciente excluido com Sucesso !!");

                AtulizarGrid();

            }
            catch
            {

                MessageBox.Show("Não foi possivel Excluir esse Paciente !! \n" + retorno);
            }

            //////pega o cliente selecionado
            //Paciente? pacienteSelecionado = dataGridViewPacientes.SelectedRows[0].DataBoundItem as Paciente;

        }
        private void butonInserir_Click(object sender, EventArgs e)
        {
            //instanciar o formulario de cadasrtro
            FormCadastroPaciente inserirPaciente = new FormCadastroPaciente(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = inserirPaciente.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                AtulizarGrid();
            }

        }
        private void buttonAlterar_Click(object sender, EventArgs e)
        {

            if (dataGridViewPacientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Paciente Selecionado !");
                return;
            }
            //pegar um paciente selecionado no grid
            Paciente? pacienteSelecionado = (dataGridViewPacientes.SelectedRows[0].DataBoundItem as Paciente);

            //instanciar o formulario cadastro do paciente
            FormCadastroPaciente alterarPaciente = new FormCadastroPaciente(AcaoNaTela.Alterar, pacienteSelecionado);
            DialogResult resultado = alterarPaciente.ShowDialog();
            if (resultado == DialogResult.Yes)
            {
                AtulizarGrid();
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {

            if (dataGridViewPacientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Paciente Selecionado !");
                return;
            }
            Paciente? pacienteSelecionado = (dataGridViewPacientes.SelectedRows[0].DataBoundItem as Paciente);

            FormCadastroPaciente consultarPaciente = new FormCadastroPaciente(AcaoNaTela.Consultar, pacienteSelecionado);
            consultarPaciente.ShowDialog();

        }

        private void frmPacienteConsultar_Load(object sender, EventArgs e)
        {

        }
    }
}
