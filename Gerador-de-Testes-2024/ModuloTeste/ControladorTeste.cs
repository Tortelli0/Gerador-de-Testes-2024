using GeradorDeTestes.WinForm;
using GeradorDeTestes.WinForm.Compartilhado;
using GeradorDeTestes2024.Compartilhado;
using GeradorDeTestes2024.ModuloDisciplina;
using GeradorDeTestes2024.ModuloMateria;
using GeradorDeTestes2024.ModuloQuestao;

namespace GeradorDeTestes2024.ModuloTeste
{
    internal class ControladorTeste : ControladorBase, IControladorDuplicavel, IControladorVisualizavel, IControladorPDF
    {
        private IRepositorioTeste repositorioTeste;
        private TabelaTesteControl tabelaTeste;
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepositorioQuestao repositorioQuestao;
        private IRepositorioMateria repositorioMateria;

        public ControladorTeste(IRepositorioTeste repositorioTeste, IRepositorioDisciplina repositorioDisciplina,
            IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria)
        {
            this.repositorioTeste = repositorioTeste;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioMateria = repositorioMateria;
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
            if (ValidarExisteRegistrosSuficientes())
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Não é possível realizar o cadastro de \"Teste\" " +
                    $"sem possuir uma \"Questão\" cadastradas!");
                return;
            }
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
            Teste TesteSelecionado = repositorioTeste.SelecionarPorId(tabelaTeste.ObterRegistroSelecionado());
            if (TesteSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult resposta = MessageBox.Show($"Você deseja realmente excluir o registro \"{TesteSelecionado.Titulo}\"?"
                , "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
                return;

            repositorioTeste.Excluir(TesteSelecionado.Id);

            CarregarTestes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{TesteSelecionado.Titulo}\" foi excluído com sucesso!");
        }
        public void Duplicar()
        {
            Teste TesteSelecionado = repositorioTeste.SelecionarPorId(tabelaTeste.ObterRegistroSelecionado());
            if (TesteSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            TelaTesteForm telaTeste = new TelaTesteForm(
                repositorioTeste.SelecionarTodos(),
                repositorioDisciplina.SelecionarTodos(),
                repositorioQuestao.SelecionarTodos(),
                true);

            DialogResult resultado = telaTeste.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Teste novoTeste = telaTeste.Teste;

            repositorioTeste.Cadastrar(novoTeste);

            CarregarTestes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoTeste.Titulo}\" foi criado com sucesso!");

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
        private bool ValidarExisteRegistrosSuficientes()
        {
            if (repositorioQuestao.SelecionarTodos().Any())
                return true;
            return false;
        }
    }
}
