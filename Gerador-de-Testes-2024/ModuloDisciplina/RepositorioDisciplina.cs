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

        public void AtualizarDependenciaMateria(Materia materiaSelecionada, Materia materiaEditada)
        {
            Disciplina disciplina = null;
            List<Materia> materias = new List<Materia>();

            foreach (Disciplina disci in contexto.Disciplinas)
            {
                if (disci.Materias.Find(m => m.Disciplina.Id == materiaSelecionada.Disciplina.Id) != null)
                    disciplina = disci;

            }
            foreach (Materia m in disciplina.Materias)
            {
                if (m.Id != materiaSelecionada.Id)
                {
                    materias.Add(m);
                }
            }
            disciplina.Materias.Clear();
            disciplina.Materias = materias;

            disciplina = contexto.Disciplinas.Find(i => i == materiaEditada.Disciplina);
            disciplina.Materias.Add(materiaEditada);
        }

        public void AtualizarDependenciaTeste(Teste testeSelecionado, Teste testeEditado)
        {
            Disciplina disciplina = null;
            List<Teste> testes = new List<Teste>();

            foreach (Disciplina disci in contexto.Disciplinas)
            {
                if (disci.Materias.Find(m => m.Disciplina.Id == testeSelecionado.Disciplina.Id) != null)
                    disciplina = disci;

            }

            foreach (Teste t in disciplina.Testes)
            {
                if (t.Id != testeSelecionado.Id)
                {
                    testes.Add(t);
                }
            }

            disciplina.Testes.Clear();
            disciplina.Testes = testes;

            disciplina = contexto.Disciplinas.Find(i => i == testeEditado.Disciplina);
            disciplina.Testes.Add(testeEditado);
        }

        protected override List<Disciplina> ObterRegistros()
        {
            return contexto.Disciplinas;
        }
    }
}
