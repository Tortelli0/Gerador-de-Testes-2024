using GeradorDeTestes.WinForm;
using GeradorDeTestes.WinForm.Compartilhado;


namespace GeradorDeTestes2024.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private TabelaDisciplinaControl tabelaDisciplina;
        private IRepositorioDisciplina repositorioDisciplina;

        public ControladorDisciplina(IRepositorioDisciplina repoDisciplina)
        {
            repositorioDisciplina = repoDisciplina;
        }

        public override string TipoCadastro { get { return "Disciplina"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova disciplina"; } }

        public override string ToolTipEditar { get { return "Editar uma disciplina existente"; } }
        public override string ToolTipExcluir { get { return "Excluir uma disciplina existente"; } }

        public override void Adicionar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm(repositorioDisciplina.SelecionarTodos());

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Disciplina novaDisciplina = telaDisciplina.Disciplina;

            repositorioDisciplina.Cadastrar(novaDisciplina);

            CarregarDisciplinas();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novaDisciplina.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm(repositorioDisciplina.SelecionarTodos());

            int idSelecionado = tabelaDisciplina.ObterRegistroSelecionado();

            Disciplina disciplinaSelecionada = repositorioDisciplina.SelecionarPorId(idSelecionado);

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaDisciplina.Disciplina = disciplinaSelecionada;

            DialogResult resultado = telaDisciplina.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Disciplina disciplinaEditada = telaDisciplina.Disciplina;

            repositorioDisciplina.Editar(disciplinaSelecionada.Id, disciplinaEditada);

            CarregarDisciplinas();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{disciplinaEditada.Nome}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaDisciplina.ObterRegistroSelecionado();

            Disciplina disciplinaSelecionada = repositorioDisciplina.SelecionarPorId(idSelecionado);

            if (disciplinaSelecionada == null)
            {
                MessageBox.Show(
                     "Não é possível realizar esta ação sem um registro selecionado.",
                     "Aviso",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning
                     );
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{disciplinaSelecionada.Nome}\" ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resposta != DialogResult.Yes)
                return;

            repositorioDisciplina.Excluir(disciplinaSelecionada.Id);

            CarregarDisciplinas();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{disciplinaSelecionada.Nome}\" foi excluido com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaDisciplina == null)
                tabelaDisciplina = new TabelaDisciplinaControl();

            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            tabelaDisciplina.AtualizarRegistros(disciplinas);

            return tabelaDisciplina;
        }

        private void CarregarDisciplinas()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            tabelaDisciplina.AtualizarRegistros(disciplinas);
        }
    }
}
