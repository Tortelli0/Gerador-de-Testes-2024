using GeradorDeTestes.WinForm.Compartilhado;
using GeradorDeTestes2024.ModuloDisciplina;
using GeradorDeTestes2024.ModuloQuestao;

namespace GeradorDeTestes2024.ModuloMateria
{
    public class RepositorioMateria : RepositorioBaseEmArquivo<Materia>, IRepositorioMateria
    {
        public RepositorioMateria(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Materias.Any())
                contadorId = contexto.Materias.Max(i => i.Id) + 1;
        }

        public void AdicionarDependencia(Questao novoQuestao)
        {
            Materia materia = contexto.Materias.Find(m => m.Id == novoQuestao.Materia.Id);
            materia.Questoes.Add(novoQuestao);
            Editar(materia.Id, materia);
        }

        public override bool Excluir(int id)
        {
            Materia materia = SelecionarPorId(id);

            Disciplina disciplina = contexto.Disciplinas.Find(d => d.Materias.Contains(materia));
            disciplina.Materias.Remove(materia);

            return base.Excluir(id);
        }
        protected override List<Materia> ObterRegistros()
        {
            return contexto.Materias;
        }
    }
}
