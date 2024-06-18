using GeradorDeTestes2024.ModuloDisciplina;
using GeradorDeTestes2024.ModuloMateria;
using GeradorDeTestes2024.ModuloQuestao;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GeradorDeTestes2024.ModuloTeste
{
    public class GerarArquivoPdf
    {
        private Teste testeSelecionado;
        private List<Disciplina> disciplinas;
        private List<Materia> materias;
        private List<Questao> questoes;

        public GerarArquivoPdf(Teste teste, List<Disciplina> disciplinas, List<Materia> materias, List<Questao> questoes)
        {
            this.testeSelecionado = teste;
            this.disciplinas = disciplinas;
            this.materias = materias;
            this.questoes = questoes;
        }



        private string MontarConteudo(string camingo, bool gabarito)
        {
            string conteudoPdf = "";
            foreach (Disciplina d in disciplinas)
            {
                if (d.Id == testeSelecionado.Disciplina.Id)
                    conteudoPdf += $"Disciplina: {d}.\n";
            }

            if (testeSelecionado.Materia != null)
                foreach (Materia m in materias)
                {
                    if (m.Id == testeSelecionado.Materia.Id)
                        conteudoPdf += $"Matéria: {m}.\n\n";
                }
            else
                conteudoPdf += $"Recuperação, {testeSelecionado.Serie} ";

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
                        if (gabarito && alt.Correta)
                            conteudoPdf += $"(X) {alt}\n";
                        else
                            conteudoPdf += $"( ) {alt}\n";
                    }

                    conteudoPdf += "\n";
                }
            }
            return conteudoPdf;
        }
        public bool GerarPdf(string caminho, bool gabarito)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            if (gabarito)
                caminho = $"{caminho}\\{testeSelecionado.Titulo} - com gabarito.pdf";
            else
                caminho = $"{caminho}\\{testeSelecionado.Titulo}.pdf";


            if (File.Exists(caminho))
            {
                DialogResult resultado = MessageBox.Show("Já existe um arquivo com esse nome! Deseja substitui-lo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado != DialogResult.Yes)
                    return false;
            }


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
                    .Column(x => { x.Item().Text(MontarConteudo(caminho, gabarito)).FontSize(11); });
                });
            }).GeneratePdf(caminho);
            return true;
        }
    }
}
