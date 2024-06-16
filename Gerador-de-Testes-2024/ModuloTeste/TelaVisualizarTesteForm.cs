using GeradorDeTestes2024.Compartilhado;
using GeradorDeTestes2024.ModuloDisciplina;
using GeradorDeTestes2024.ModuloMateria;
using GeradorDeTestes2024.ModuloQuestao;

namespace GeradorDeTestes2024.ModuloTeste
{
    public partial class TelaVisualizarTesteForm : Form
    {
        public TelaVisualizarTesteForm(Teste testeSelecionado, List<Disciplina> disciplinas, List<Materia> materias, List<Questao> questoes)
        {
            InitializeComponent();
            this.ConfigurarDialog();
            CarregarInformacoes(testeSelecionado, disciplinas, materias, questoes);
        }

        private void CarregarInformacoes(Teste testeSelecionado, List<Disciplina> disciplinas, List<Materia> materias, List<Questao> questoes)
        {
            txtTitulo.Text = testeSelecionado.Titulo;

            foreach (Disciplina d in disciplinas)
            {
                if (d.Id == testeSelecionado.Disciplina.Id)
                    txtDisciplina.Text = d.Nome;
            }
            foreach (Materia m in materias)
            {
                if (m.Id == testeSelecionado.Materia.Id)
                    txtMateria.Text = m.Nome;
            }
            foreach (Questao quest in questoes)
            {
                if (testeSelecionado.Questoes.Find(q => q.Id == quest.Id) != null)
                    listQuestoes.Items.Add(quest);
            }
        }
    }
}
