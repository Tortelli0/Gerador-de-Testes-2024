using GeradorDeTestes.WinForm.Compartilhado;
using GeradorDeTestes2024.ModuloMateria;
using GeradorDeTestes2024.ModuloTeste;

namespace GeradorDeTestes2024.ModuloDisciplina
{
    public class RepositorioDisciplina : RepositorioBaseEmArquivo<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplina(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Disciplinas.Any())
                contadorId = contexto.Disciplinas.Max(i => i.Id) + 1;
        }

        public void AdicionarDependenciaMateria(Materia novaMateria)
        {
            Disciplina disciplina = contexto.Disciplinas.Find(d => d.Id == novaMateria.Disciplina.Id);
            disciplina.Materias.Add(novaMateria);
            Editar(disciplina.Id, disciplina);
        }

        public void AdicionarDependenciaTeste(Teste novoTeste)
        {
            Disciplina disciplina = contexto.Disciplinas.Find(d => d.Id == novoTeste.Disciplina.Id);
            disciplina.Testes.Add(novoTeste);
            Editar(disciplina.Id, disciplina);
        }

        protected override List<Disciplina> ObterRegistros()
        {
            return contexto.Disciplinas;
        }
    }
}
