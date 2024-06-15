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

        public void atualizarDependenciaDisciplina(Disciplina disciplinaSelecionada, Disciplina disciplinaEditada)
        {
            List<Teste> teste = new List<Teste>();

            foreach (Teste t in contexto.Testes)
            {
                if (t.Disciplina.Id == disciplinaSelecionada.Id)
                    t.Disciplina = disciplinaEditada;
            }
        }

        public override bool Excluir(int id)
        {
            Teste teste = SelecionarPorId(id);

            List<Questao> questoes = new List<Questao>();
            foreach (Questao q in contexto.Questoes)
            {
                if (q.Testes.Find(t => t.Id == teste.Id) != null)
                    questoes.Add(q);
            }
            List<Teste> testes = new List<Teste>();
            foreach (Questao q in questoes)
            {
                foreach (Teste t in q.Testes)
                    if (t.Id != teste.Id)
                        testes.Add(t);
                q.Testes.Clear();
                q.Testes = testes;
            }


            testes = new List<Teste>();
            Disciplina disciplina = contexto.Disciplinas.Find(d => d.Id == teste.Disciplina.Id);
            foreach (Teste t in disciplina.Testes)
            {
                if (t.Id != teste.Id)
                    testes.Add(t);
            }
            disciplina.Testes.Clear();
            disciplina.Testes = testes;

            return base.Excluir(id);
        }
        protected override List<Teste> ObterRegistros()
        {
            return contexto.Testes;
        }
    }
}
