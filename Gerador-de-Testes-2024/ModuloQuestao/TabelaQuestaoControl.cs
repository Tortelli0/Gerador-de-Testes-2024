using GeradorDeTestes.WinForm.Compartilhado;

namespace GeradorDeTestes2024.ModuloQuestao
{
    public partial class TabelaQuestaoControl : UserControl
    {
        public TabelaQuestaoControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Questao> Questoes)
        {
            grid.Rows.Clear();

            foreach (Questao Questao in Questoes)
                grid.Rows.Add(Questao.Id, Questao.Enunciado, Questao.Materia, Questao.RetornarRespostaCorreta());
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }
        private DataGridViewColumn[] ObterColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Enunciado", HeaderText = "Enunciado" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Materia", HeaderText = "Materia" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Resposta", HeaderText = "Resposta" }
            };
        }
    }
}
