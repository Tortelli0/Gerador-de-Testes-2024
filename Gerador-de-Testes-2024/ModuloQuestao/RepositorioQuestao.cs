using GeradorDeTestes.WinForm.Compartilhado;
using GeradorDeTestes2024.ModuloMateria;
using GeradorDeTestes2024.ModuloTeste;

namespace GeradorDeTestes2024.ModuloQuestao
{
    internal class RepositorioQuestao : RepositorioBaseEmArquivo<Questao>, IRepositorioQuestao
    {
        public RepositorioQuestao(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Questoes.Any())
                contadorId = contexto.Questoes.Max(i => i.Id) + 1;
        }

        public void AdicionarDependencia(Teste novoTeste)
        {
            List<Questao> questoes = contexto.Questoes.FindAll(q => novoTeste.Questoes.Contains(q));

            foreach (Questao q in questoes)
            {
                q.Testes.Add(novoTeste);
                Editar(q.Id, q);
            }
        }

        public override bool Excluir(int id)
        {
            Questao questao = SelecionarPorId(id);

            Materia materia = contexto.Materias.Find(m => m.Questoes.Contains(questao));
            materia.Questoes.Remove(questao);

            return base.Excluir(id);
        }
        protected override List<Questao> ObterRegistros()
        {
            return contexto.Questoes;
        }

    }
}
