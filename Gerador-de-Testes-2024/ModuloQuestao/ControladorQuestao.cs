﻿using GeradorDeTestes.WinForm;
using GeradorDeTestes.WinForm.Compartilhado;

namespace GeradorDeTestes2024.ModuloQuestao
{
    internal class ControladorQuestao : ControladorBase
    {
        private IRepositorioQuestao repositorioQuestao;
        private TabelaQuestaoControl tabelaQuestao;

        public ControladorQuestao(IRepositorioQuestao repositorioQuestao)
        {
            this.repositorioQuestao = repositorioQuestao;
            AtualizarRodapeQuantidadeRegistros();
        }

        public override string TipoCadastro => "Questões";

        public override string ToolTipAdicionar => "Cadastrar uma nova questão";

        public override string ToolTipEditar => "Editar uma questão já existente";

        public override string ToolTipExcluir => "Excluir uma questão já existente";

        public override void Adicionar()
        {
            TelaQuestaoForm telaQuestao = new TelaQuestaoForm();

            DialogResult resultado = telaQuestao.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Questao novoQuestao = telaQuestao.Questao;

            repositorioQuestao.Cadastrar(novoQuestao);

            CarregarQuestoes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novoQuestao.Enunciado}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            Questao QuestaoSelecionado = repositorioQuestao.SelecionarPorId(tabelaQuestao.ObterRegistroSelecionado());

            TelaQuestaoForm telaQuestao = new TelaQuestaoForm();

            if (QuestaoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            telaQuestao.Questao = QuestaoSelecionado;

            DialogResult resultado = telaQuestao.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Questao QuestaoEditada = telaQuestao.Questao;

            repositorioQuestao.Editar(QuestaoSelecionado.Id, QuestaoEditada);
            CarregarQuestoes();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{QuestaoEditada.Enunciado}\" foi editado com sucesso!");
        }

        public override void Excluir()
        {
            Questao QuestaoSelecionado = repositorioQuestao.SelecionarPorId(tabelaQuestao.ObterRegistroSelecionado());
            if (QuestaoSelecionado == null)
            {
                MessageBox.Show(
                    "Não é possível realizar esta ação sem um registro selecionado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (QuestaoSelecionado.Teste != null)
            {
                MessageBox.Show(
                    "A questão esta relacionada a um teste, não é possível exclui-la",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }


            DialogResult resposta = MessageBox.Show($"Você deseja realmente excluir o registro \"{QuestaoSelecionado.Enunciado}\"?"
                , "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
                return;

            repositorioQuestao.Excluir(QuestaoSelecionado.Id);

            CarregarQuestoes();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{QuestaoSelecionado.Enunciado}\" foi excluído com sucesso!");
        }

        public override UserControl ObterListagem()
        {
            if (tabelaQuestao == null)
                tabelaQuestao = new TabelaQuestaoControl();

            List<Questao> questoes = repositorioQuestao.SelecionarTodos();

            tabelaQuestao.AtualizarRegistros(questoes);

            return tabelaQuestao;
        }
        private void CarregarQuestoes()
        {
            List<Questao> Questaos = repositorioQuestao.SelecionarTodos();

            tabelaQuestao.AtualizarRegistros(Questaos);
        }
        private void AtualizarRodapeQuantidadeRegistros()
        {
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {repositorioQuestao.SelecionarTodos().Count} registro(s)...");
        }
    }
}