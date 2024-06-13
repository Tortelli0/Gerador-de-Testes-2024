using GeradorDeTestes.WinForm;
using GeradorDeTestes.WinForm.Compartilhado;
using GeradorDeTestes2024.ModuloDisciplina;

namespace GeradorDeTestes2024.ModuloMateria
{
    internal class ControladorMateria : ControladorBase
    {
        private TabelaMateriaControl tabelaMateria;
        private IRepositorioMateria repositorioMateria;
        private IRepositorioDisciplina repositorioDisciplina;

        public ControladorMateria(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
            AtualizarRodapeQuantidadeRegistros();
        }

        public override string TipoCadastro { get { return "Matéria"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova matéria"; } }

        public override string ToolTipEditar { get { return "Editar uma matéria existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma matéria existente"; } }

        public override void Adicionar()
        {
            if (ValidarDisciplinasExistentes())
            {
                TelaMateriaForm telaMateria = new TelaMateriaForm(repositorioDisciplina.SelecionarTodos());

                DialogResult resultado = telaMateria.ShowDialog();

                if (resultado != DialogResult.OK)
                    return;

                Materia novaMateria = telaMateria.Materia;

                repositorioMateria.Cadastrar(novaMateria);

                CarregarMaterias();

                TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novaMateria.Nome}\" foi criado com sucesso!");
            }

            else
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Não é possível adicionar uma matéria sem ter uma disciplina!");
            }
        }


        public override void Editar()
        {
            if (ValidarDisciplinasExistentes())
            {
                TelaMateriaForm telaMateria = new TelaMateriaForm(repositorioDisciplina.SelecionarTodos());

                int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

                Materia materiaSelecionada = repositorioMateria.SelecionarPorId(idSelecionado);

                if (materiaSelecionada == null)
                {
                    MessageBox.Show(
                        "Não é possível realizar esta ação sem um registro selecionado",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                telaMateria.Materia = materiaSelecionada;

                DialogResult resultado = telaMateria.ShowDialog();

                if (resultado != DialogResult.OK)
                    return;

                Materia materiaEditada = telaMateria.Materia;

                repositorioMateria.Editar(materiaSelecionada.Id, materiaEditada);

                CarregarMaterias();

                TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{materiaSelecionada.Nome}\" foi editado com sucesso!");
            }

            else
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Não é possível editar uma matéria sem ter uma disciplina!");
            }
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materia materiaSelecionada = repositorioMateria.SelecionarPorId(idSelecionado);

            if (materiaSelecionada == null)
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
                $"Você deseja realmente excluir o registro \"{materiaSelecionada.Nome}\" ",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (resposta != DialogResult.Yes)
                return;

            repositorioMateria.Excluir(materiaSelecionada.Id);

            CarregarMaterias();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{materiaSelecionada.Nome}\" foi excluido com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaMateria == null)
                tabelaMateria = new TabelaMateriaControl();

            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(materias);

            return tabelaMateria;
        }
        private void CarregarMaterias()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(materias);
        }
        private void AtualizarRodapeQuantidadeRegistros()
        {
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {repositorioMateria.SelecionarTodos().Count} registro(s)...");
        }

        private bool ValidarDisciplinasExistentes()
        {
            return repositorioDisciplina.SelecionarTodos().Any();
        }
    }
}
