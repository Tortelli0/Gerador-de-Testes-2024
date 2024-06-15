using GeradorDeTestes.WinForm;
using GeradorDeTestes2024.Compartilhado;
using GeradorDeTestes2024.ModuloDisciplina;
using GeradorDeTestes2024.ModuloMateria;
using GeradorDeTestes2024.ModuloQuestao;

namespace GeradorDeTestes2024.ModuloTeste
{
    public partial class TelaTesteForm : Form
    {
        private bool duplicar;
        private Disciplina disciplina;
        private Teste teste;
        private List<Teste> testes;
        private List<Questao> todasAsQuestoes;
        private List<Questao> questoesDisponiveis;
        public Teste Teste
        {
            get { return teste; }
            set
            {
                txtTitulo.Text = value.Titulo;

                if (duplicar)
                    txtTitulo.Text = value.Titulo + "- Cópia";

                cmbDisciplina.SelectedItem = value.Disciplina;

                if (!duplicar)
                    CarregarListaQuestoes(value.Questoes);

                if (value.Recuperacao)
                {
                    cmbMateria.Enabled = false;
                    cmbMateria.SelectedIndex = -1;
                }
            }
        }
        public TelaTesteForm(List<Teste> testes, List<Disciplina> disciplinas, List<Questao> questoes, bool habilitarDuplicacao)
        {
            InitializeComponent();
            ConfigurarTelaDuplicacao(habilitarDuplicacao);
            this.ConfigurarDialog();
            this.testes = testes;
            todasAsQuestoes = questoes;
            CarregarInformacoes(disciplinas);
        }

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMateria.SelectedItem != null)
            {
                numQuestoes.Value = 0;
                Materia materiaSelecionada = (Materia)cmbMateria.SelectedItem;
                numQuestoes.Maximum = materiaSelecionada.QuantidadeQuestoes();
                questoesDisponiveis = materiaSelecionada.Questoes;
            }
            else if (checkBoxRecuperacao.Checked)
            {
                numQuestoes.Value = 0;
                Disciplina disciplinaSelecionada = (Disciplina)cmbDisciplina.SelectedItem;
                numQuestoes.Maximum = disciplinaSelecionada.QuantidadeQuestoes("serie");
                questoesDisponiveis = disciplinaSelecionada.ListaQuestoes("serie");
            }
        }

        private void checkBoxRecuperacao_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRecuperacao.Checked)
            {
                cmbMateria.SelectedIndex = -1;
                cmbMateria.Enabled = false;
            }
            else
            {
                cmbMateria.Enabled = true;
            }
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            List<Questao> questoesSorteadas = new List<Questao>();

            SortearQuestoes(questoesSorteadas);

            listQuestoes.Items.Clear();
            foreach (Questao q in questoesSorteadas)
            {
                listQuestoes.Items.Add(q);
            }
        }



        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();

            Disciplina disciplina = (Disciplina)cmbDisciplina.SelectedItem;

            List<Questao> questoesSelecionadas = new List<Questao>();

            foreach (Questao q in listQuestoes.Items)
            {
                questoesSelecionadas.Add(q);
            }

            teste = new Teste(titulo, disciplina, questoesSelecionadas);

            if (!checkBoxRecuperacao.Checked && cmbMateria.SelectedItem != null)
            {
                teste.Materia = (Materia)cmbMateria.SelectedItem;
                teste.Serie = teste.Materia.Serie;
            }

            List<string> erros = teste.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }

            if (teste.TituloTesteIgual(testes))
            {
                TelaPrincipalForm.Instancia.AtualizarRodape($"Já existe um \"Teste\" com o título de: \"{teste.Titulo}\"");
                DialogResult = DialogResult.None;
            }

        }
        private void CarregarInformacoes(List<Disciplina> disciplinas)
        {
            numQuestoes.Maximum = 0;
            foreach (Disciplina disciplina in disciplinas)
            {
                cmbDisciplina.Items.Add(disciplina);
            }
            cmbDisciplina.SelectedIndex = 0;
        }
        private void SortearQuestoes(List<Questao> questoesSorteadas)
        {
            List<Questao> copiaQuestoes = new List<Questao>(questoesDisponiveis);

            Random rand = new Random();

            while (questoesSorteadas.Count < numQuestoes.Value)
            {
                int index = rand.Next(copiaQuestoes.Count);
                questoesSorteadas.Add(copiaQuestoes[index]);
                copiaQuestoes.RemoveAt(index);
            }
        }
        private void CarregarListaQuestoes(List<Questao> questoes)
        {
            listQuestoes.Items.Clear();
            foreach (Questao q in questoes)
            {
                listQuestoes.Items.Add(q);
            }
        }
        private void ConfigurarTelaDuplicacao(bool habilitarDuplicacao)
        {
            if (habilitarDuplicacao)
            {
                duplicar = habilitarDuplicacao;
                this.Text = "Duplicação de Teste";
            }
        }

        private void cmbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!checkBoxRecuperacao.Checked)
            {
                disciplina = (Disciplina)cmbDisciplina.SelectedItem;
                foreach (Materia m in disciplina.Materias)
                {
                    cmbMateria.Items.Add(m);
                }
            }
        }
    }
}

