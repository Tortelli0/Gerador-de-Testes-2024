using GeradorDeTestes.WinForm.Compartilhado;
using GeradorDeTestes2024.ModuloDisciplina;
using GeradorDeTestes2024.ModuloQuestao;

namespace GeradorDeTestes2024.ModuloTeste
{
    public class RepositorioTeste : RepositorioBaseEmArquivo<Teste>, IRepositorioTeste
    {
        public RepositorioTeste(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Testes.Any())
                contadorId = contexto.Questoes.Max(i => i.Id) + 1;
        }
        public override bool Excluir(int id)
        {
            Teste teste = SelecionarPorId(id);

            List<Questao> questoes = contexto.Questoes.FindAll(q => q.Testes.Contains(teste));

            foreach (Questao q in questoes)
            {
                q.Testes.Remove(teste);
            }

            Disciplina disciplina = contexto.Disciplinas.Find(d => d.Testes.Contains(teste));
            disciplina.Testes.Remove(teste);

            return base.Excluir(id);
        }
        protected override List<Teste> ObterRegistros()
        {
            return contexto.Testes;
        }
    }
}
