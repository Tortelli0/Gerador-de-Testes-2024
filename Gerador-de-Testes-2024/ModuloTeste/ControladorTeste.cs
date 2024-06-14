using GeradorDeTestes.WinForm;
using GeradorDeTestes.WinForm.Compartilhado;
using GeradorDeTestes2024.Compartilhado;
using GeradorDeTestes2024.ModuloDisciplina;
using GeradorDeTestes2024.ModuloQuestao;

namespace GeradorDeTestes2024.ModuloTeste
{
    internal class ControladorTeste : ControladorBase, IControladorDuplicavel, IControladorVisualizavel, IControladorPDF
    {
        private IRepositorioTeste repositorioTeste;
        private TabelaTesteControl tabelaTeste;
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioQuestao repositorioQuestao;

        public ControladorTeste(IRepositorioTeste repositorioTeste, IRepositorioDisciplina repositorioDisciplina,
            IRepositorioQuestao repositorioQuestao)
        {
            this.repositorioTeste = repositorioTeste;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioQuestao = repositorioQuestao;
            AtualizarRodapeQuantidadeRegistros();
        }

        public override string TipoCadastro => "Testes";

        public override string ToolTipAdicionar => "Cadastrar um novo teste";

        public override string ToolTipEditar => "Editar um teste existente";

        public override string ToolTipExcluir => "Excluir um teste existente";

        public string ToolTipDuplicar => "Duplicar um teste existente";

        public string ToolTipVisualizar => "Visualizar os detalhes do teste selecionado";

        public string ToolTipPDF => "Gerar arquivo PDF do teste selecionado";

        public override void Adicionar()
        {
            TelaTesteForm telaTeste = new TelaTesteForm(
                repositorioTeste.SelecionarTodos(),
                repositorioDisciplina.SelecionarTodos(),
                repositorioQuestao.SelecionarTodos(),
                false);

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste novoTeste = telaTeste.Teste;

            repositorioTeste.Cadastrar(novoTeste);

            CarregarTestes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoTeste.Titulo}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }
        public void Duplicar()
        {
            throw new NotImplementedException();
        }

        public void Visualizar()
        {
            throw new NotImplementedException();
        }

        public void GerarPDF()
        {
            throw new NotImplementedException();
        }
        public override UserControl ObterListagem()
        {
            if (tabelaTeste == null)
                tabelaTeste = new TabelaTesteControl();

            List<Teste> questoes = repositorioTeste.SelecionarTodos();

            tabelaTeste.AtualizarRegistros(questoes);

            return tabelaTeste;
        }
        private void CarregarTestes()
        {
            List<Teste> Testes = repositorioTeste.SelecionarTodos();

            tabelaTeste.AtualizarRegistros(Testes);
        }
        private void AtualizarRodapeQuantidadeRegistros()
        {
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {repositorioTeste.SelecionarTodos().Count} registro(s)...");
        }
    }
}
