

using ListaAtividades.AtividadeRepositorio;


namespace ListaAtividades.Dominio
{
    internal class Atividade
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Situacao Situacao { get; set; }

        public void Criar()
        {

        }

        public void AtualizarSituacao()
        {

        }

        public Atividade BuscarAtividadeEmAndamento()
        {
            return new Atividade();
        }

        public List<Atividade> ListarAtividadePendentes()
        {
            return [];
        }

        private bool ValidarTitulo()
        {
            return !string.IsNullOrEmpty(Titulo);
        }

        private Situacao BuscarProximoSituacao()
        {
            return Situacao.Concluido;
        }
    }
}   
