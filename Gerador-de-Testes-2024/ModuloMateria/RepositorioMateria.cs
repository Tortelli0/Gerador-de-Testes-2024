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

        public void AtualizarDependencia(Questao questaoSelecionado, Questao questaoEditada)
        {
            Materia materia = null;
            List<Questao> questoes = new List<Questao>();

            foreach (Materia mat in contexto.Materias)
            {
                if (mat.Questoes.Find(q => q.Materia.Id == questaoSelecionado.Materia.Id) != null)
                    materia = mat;

            }
            foreach (Questao q in materia.Questoes)
            {
                if (q.Id != questaoSelecionado.Id)
                {
                    questoes.Add(q);
                }
            }
            materia.Questoes.Clear();
            materia.Questoes = questoes;

            materia = contexto.Materias.Find(i => i == questaoEditada.Materia);
            materia.Questoes.Add(questaoEditada);
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
