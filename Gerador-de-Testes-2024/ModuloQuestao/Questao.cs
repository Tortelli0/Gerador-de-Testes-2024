using GeradorDeTestes.ConsoleApp.Compartilhado;

namespace GeradorDeTestes2024.ModuloQuestao
{
    public class Questao : EntidadeBase
    {
        public string Materia { get; set; }
        public string Enunciado { get; set; }
        public List<Alternativa> Alternativas { get; set; }

        public Questao()
        {

        }
        public Questao(string materia, string enunciado, List<Alternativa> alternativas)
        {
            Materia = materia;
            Enunciado = enunciado;
            Alternativas = alternativas;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Questao q = (Questao)novoRegistro;
            Materia = q.Materia;
            Enunciado = q.Enunciado;
            Alternativas = q.Alternativas;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Enunciado.Trim()))
                erros.Add("O campo \"Enunciado\" é obrigatório");

            return erros;
        }
    }
}
