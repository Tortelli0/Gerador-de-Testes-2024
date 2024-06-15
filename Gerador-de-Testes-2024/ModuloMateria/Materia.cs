using GeradorDeTestes.ConsoleApp.Compartilhado;
using GeradorDeTestes2024.ModuloDisciplina;
using GeradorDeTestes2024.ModuloQuestao;

namespace GeradorDeTestes2024.ModuloMateria
{
    public class Materia : EntidadeBase
    {
        public string Nome { get; set; }
        public string Serie { get; set; }
        public Disciplina Disciplina { get; set; }
        public List<Questao> Questoes { get; set; }
        public Materia()
        {

        }

        public Materia(string nome, string serie, Disciplina disciplina)
        {
            Nome = nome;
            Serie = serie;
            Disciplina = disciplina;
            Questoes = new List<Questao>();
        }
        public Materia(int id, string nome, string serie, Disciplina disciplina)
        {
            Id = id;
            Nome = nome;
            Serie = serie;
            Disciplina = disciplina;
            Questoes = new List<Questao>();
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(Serie.Trim()))
                erros.Add("Ao menos uma das \"séries\" deve ser selecionada");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Materia m = (Materia)novoRegistro;

            Nome = m.Nome;
            Serie = m.Serie;
            Disciplina = m.Disciplina;
        }

        public override string ToString()
        {
            return $"{Nome}, {Serie}";
        }

        public bool PrimeiraSerieMarcada()
        {
            if (Serie.Contains("1"))
                return true;

            return false;
        }

        public int QuantidadeQuestoes()
        {
            return Questoes.Count;
        }
    }
}
