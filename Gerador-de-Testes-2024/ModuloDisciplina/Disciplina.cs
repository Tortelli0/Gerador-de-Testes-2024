using GeradorDeTestes.ConsoleApp.Compartilhado;
using GeradorDeTestes2024.ModuloMateria;
using GeradorDeTestes2024.ModuloQuestao;
using GeradorDeTestes2024.ModuloTeste;

namespace GeradorDeTestes2024.ModuloDisciplina
{
    public class Disciplina : EntidadeBase
    {
        public string Nome { get; set; }
        public List<Materia> Materias { get; set; }
        public List<Teste> Testes { get; set; }

        public Disciplina()
        {

        }
        public Disciplina(string nome)
        {
            Nome = nome;
            Materias = new List<Materia>();
            Testes = new List<Teste>();
        }
        public Disciplina(int id, string nome)
        {
            Id = id;
            Nome = nome;
            Materias = new List<Materia>();
            Testes = new List<Teste>();
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Disciplina d = (Disciplina)novoRegistro;

            Nome = d.Nome;
            Materias = d.Materias;
            Testes = d.Testes;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            return erros;
        }

        public bool ExisteDisciplina(List<Disciplina> disciplinas)
        {
            foreach (Disciplina d in disciplinas)
                if (d.Nome == Nome)
                    return true;
            return false;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }

        internal decimal QuantidadeQuestoes(string serie)
        {
            int contador = 0;
            foreach (Materia m in Materias)
            {
                if (m.Serie == serie)
                    contador = m.QuantidadeQuestoes();
            }
            return contador;
        }

        internal List<Questao> ListaQuestoes(string serie)
        {
            List<Questao> lista = new List<Questao>();

            foreach (Materia m in Materias)
            {
                if (m.Serie == serie)
                    lista.AddRange(m.Questoes);
            }
            return lista;
        }
    }
}