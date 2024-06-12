using GeradorDeTestes.ConsoleApp.Compartilhado;

namespace GeradorDeTestes2024.ModuloDisciplina
{
    public class Disciplina : EntidadeBase
    {
        public string Nome { get; set; }

        public Disciplina(string nome)
        {
            Nome = nome;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Disciplina d = (Disciplina)novoRegistro;

            Nome = d.Nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            return erros;
        }

        public bool ExisteDisciplina(List<Disciplina> disciplinas, Disciplina disciplina)
        {
            foreach (Disciplina d in disciplinas)           
                if (d.Nome == disciplina.Nome)
                    return true;
            

            return false;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}