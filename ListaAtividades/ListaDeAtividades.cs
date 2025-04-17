using ListaAtividades.Dominio;
using ListaAtividades.Repositorio;

namespace ListaAtividades
{
    public partial class ListaDeAtividades : Form
    {
        private Atividade? atividadeEmAndamento;

        public ListaDeAtividades()
        {
            InitializeComponent();
        }

        private void ListaDeAtividades_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;

            CarregarAtividadeEmAndamento();
            CarregarListaAtividades();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (atividadeEmAndamento == null || atividadeEmAndamento.Id <= 0)
            {
                labelErro.Text = "Não há atividade em andamento";
                labelErro.ForeColor = Color.Red;
                return;
            }
            if(!atividadeEmAndamento.AtualizarSituacao())
            {
                labelErro.Text = "Não foi possivel finalizar a atividade";
                labelErro.ForeColor = Color.Red;
            }

            labelErro.Text = string.Empty;
            CarregarAtividadeEmAndamento();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if(dataGridViewAtividades.SelectedRows.Count <= 0)
            {
                labelErro.Text = "Selecione uma linha";
                labelErro.ForeColor = Color.Red;
                return;
            }

            var linhaSelecionada = dataGridViewAtividades.SelectedRows[0];

            Atividade atividade = new() 
            {
                Id = (int)linhaSelecionada.Cells[0].Value,
                Titulo = (string)linhaSelecionada.Cells[1].Value,
                Situacao = (Situacao)linhaSelecionada.Cells[2].Value
            };

            if (!atividade.AtualizarSituacao())
            {
                labelErro.Text = "Não foi possível atualizar a atividade";
                labelErro.ForeColor = Color.Red;
                return;
            }

            labelErro.Text = string.Empty;
            CarregarAtividadeEmAndamento();
            CarregarListaAtividades();
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            var resultado = new CriarAtividades().ShowDialog();

            if (resultado != DialogResult.OK)
            {
                labelErro.Text = "Criação da atividade não foi concluída.";
                labelErro.ForeColor = Color.Red;
                return;
            }

            labelErro.Text = "Atividade criada com sucesso";
            CarregarListaAtividades();
        }

        private void CarregarListaAtividades()
        {
            Atividade atividade = new();

            var atividadesPendentes = atividade.ListarAtividadesPendentes();
            dataGridViewAtividades.DataSource = atividadesPendentes;
        } 

        private void CarregarAtividadeEmAndamento()
        {
            Atividade atividade = new();

            atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            string textoAtividade = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}";
            textBoxAtividadeEmAndamento.Text = atividadeEmAndamento.Id > 0 ? textoAtividade : string.Empty;

        }

    }
}
