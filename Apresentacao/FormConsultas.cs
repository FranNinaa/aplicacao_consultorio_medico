using ObjetoTransferencia;
using RegraNegocios;

namespace Apresentacao
{
    public partial class FormConsultas : Form
    {

        public FormConsultas()
        {
            InitializeComponent();
            dataGridViewConsultas.AutoGenerateColumns = false;

        }

        private void buttonConsultarConsulta_Click_1(object sender, EventArgs e)
        {
            //verifica se tem algum registro selecionado
            if (dataGridViewConsultas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma consulta Selecionada !!");
                return;
            }

            //pega a consulta selecionada no grid
            Consultas? consultaSelecionada = (dataGridViewConsultas.SelectedRows[0].DataBoundItem as Consultas);

            FormCadastroConsulta formCadastroConsulta = new FormCadastroConsulta(AcaoNaTela.Consultar, consultaSelecionada);
            formCadastroConsulta.ShowDialog();
            AtulizarGrid();

        }
        private void AtulizarGrid()
        {
            ConsultaNegocios consultaNegocios = new ConsultaNegocios();
            ConsultaColecao consultaColecao = new ConsultaColecao();
            consultaColecao = consultaNegocios.ConsultarPorNomePaciente(textNomePaciente.Text);

            dataGridViewConsultas.DataSource = null;
            dataGridViewConsultas.DataSource = consultaColecao;

            dataGridViewConsultas.Update();
            dataGridViewConsultas.Refresh();


        }

        private void buttonExcluirConsulta_Click(object sender, EventArgs e)
        {
            //verifica se tem algum registro selecionado
            if (dataGridViewConsultas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Consulta Selecionada ! ");
                return;
            }
            //pergunta se quer realmenete excluir
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja Excluir ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            //pega o consulta selecionado
            Consultas? consultaSelecionada = (dataGridViewConsultas.SelectedRows[0].DataBoundItem as Consultas);

            //instanciar a regra de negocios
            ConsultaNegocios consultaNegocios = new ConsultaNegocios();

            //chama o metodo para excluir
            string retorno = consultaNegocios.Excluir(consultaSelecionada);


            try
            {
                //verifica se excluiu com sucesso
                //se o retorno for número é por que deu certo, senão é a mensagem de erro.

                int IDconsultas = Convert.ToInt32(retorno);
                MessageBox.Show("Consulta excluida com sucesso !! ");

                AtulizarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possivel excluir. Detalhes: " + retorno);
            }


        }
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            ConsultaNegocios consultasNegocios = new ConsultaNegocios();
            ConsultaColecao consultasColecao = new ConsultaColecao();

            consultasColecao = consultasNegocios.ConsultarPorNomePaciente(textNomePaciente.Text);

            dataGridViewConsultas.DataSource = null;
            dataGridViewConsultas.DataSource = consultasColecao;

            dataGridViewConsultas.Update();
            dataGridViewConsultas.Refresh();
        }

        private void buttonAlterarConsulta_Click(object sender, EventArgs e)
        {

            //verifica se tem algum registro selecionado
            if (dataGridViewConsultas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma consulta Selecionada !!");
                return;
            }

            //pega a consulta selecionada no grid
            Consultas? consultaSelecionada = (dataGridViewConsultas.SelectedRows[0].DataBoundItem as Consultas);

            FormCadastroConsulta formCadastroConsulta = new FormCadastroConsulta(AcaoNaTela.Alterar, consultaSelecionada);

            DialogResult dialogResult = formCadastroConsulta.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }

        }

        private void buttonInserirConsulta_Click(object sender, EventArgs e)
        {
            FormCadastroConsulta formCadastroConsulta = new FormCadastroConsulta(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = formCadastroConsulta.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {

                AtualizarGrid();
            }
        }


    }
}
