using GeradorDeTestes.WinForm;
using GeradorDeTestes.WinForm.Compartilhado;

namespace GeradorDeTestes2024.ModuloTeste
{
    internal class ControladorTeste : ControladorBase
    {
        private IRepositorioTeste repositorioTeste;
        private TabelaTesteControl tabelaTeste;

        public ControladorTeste(IRepositorioTeste repositorioTeste)
        {
            this.repositorioTeste = repositorioTeste;

            AtualizarRodapeQuantidadeRegistros();
        }

        public override string TipoCadastro => "Testes";

        public override string ToolTipAdicionar => "Cadastrar um novo teste";

        public override string ToolTipEditar => "Editar um teste existente";

        public override string ToolTipExcluir => "Excluir um teste existente";

        public override void Adicionar()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
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
        private void CarregarQuestoes()
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
