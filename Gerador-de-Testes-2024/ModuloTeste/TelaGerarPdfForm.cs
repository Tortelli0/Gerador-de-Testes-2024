using GeradorDeTestes2024.Compartilhado;
using GeradorDeTestes2024.ModuloDisciplina;
using GeradorDeTestes2024.ModuloMateria;
using GeradorDeTestes2024.ModuloQuestao;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GeradorDeTestes2024.ModuloTeste
{
    public partial class TelaGerarPdfForm : Form
    {
        private string caminho = "";
        public string Caminho { get { return caminho; } }
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private string conteudoPdf = "";
        private List<Disciplina> disciplinas;
        private List<Materia> materias;
        private List<Questao> questoes;
        private Teste testeSelecionado;
        public TelaGerarPdfForm(Teste testeSelecionado, List<Disciplina> disciplinas, List<Materia> materias, List<Questao> questoes)
        {
            InitializeComponent();
            this.testeSelecionado = testeSelecionado;
            this.materias = materias;
            this.disciplinas = disciplinas;
            this.questoes = questoes;
            this.ConfigurarDialog();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            MontarConteudo();

            caminho = "";

            if (cbGabarito.Checked)
                caminho = $"{path}\\ProvaComGabarito.pdf";
            else
                caminho = $"{path}\\Prova.pdf";

            if (!File.Exists(caminho))
            {
                GerarPdf(caminho);
                return;
            }

            DialogResult resposta = MessageBox.Show("O arquivo PDF já existe! Deseja substitui-lo?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
            {
                DialogResult = DialogResult.None;
                return;
            }

            GerarPdf(caminho);
        }
        private void MontarConteudo()
        {
            foreach (Disciplina d in disciplinas)
            {
                if (d.Id == testeSelecionado.Disciplina.Id)
                    conteudoPdf += $"Disciplina: {d}.\n";
            }

            foreach (Materia m in materias)
            {
                if (m.Id == testeSelecionado.Materia.Id)
                    conteudoPdf += $"Matéria: {m}.\n\n";
            }

            int numeroQuestao = 1;
            conteudoPdf += "=================================QUESTÕES=================================\n\n";

            foreach (Questao quest in testeSelecionado.Questoes)
            {
                if (questoes.Find(q => q.Id == quest.Id) != null)
                {
                    conteudoPdf += $"{numeroQuestao}) {quest}\n";
                    numeroQuestao++;

                    foreach (Alternativa alt in quest.Alternativas)
                    {
                        if (cbGabarito.Checked && alt.Correta)
                            conteudoPdf += $"(X) {alt}\n";
                        else
                            conteudoPdf += $"( ) {alt}\n";
                    }

                    conteudoPdf += "\n";
                }
            }
        }
        private void GerarPdf(string caminho)
        {
            QuestPDF.Settings.License = LicenseType.Community;
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    //Configuração Geral
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    //Configuração Header
                    page.Header().Text(testeSelecionado.Titulo).SemiBold().FontSize(30).AlignCenter().FontFamily(Fonts.SegoeUI);

                    //Configuração Conteúdo
                    page.Content()
                    .PaddingVertical(1, Unit.Centimetre)
                    .Column(x => { x.Item().Text(conteudoPdf).FontSize(11); });
                });
            }).GeneratePdf(caminho);
        }
    }
}
