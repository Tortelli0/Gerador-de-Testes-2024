using GeradorDeTestes.WinForm.Compartilhado;

namespace GeradorDeTestes2024.ModuloTeste
{
    public class RepositorioTeste : RepositorioBaseEmArquivo<Teste>, IRepositorioTeste
    {
        public RepositorioTeste(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Testes.Any())
                contadorId = contexto.Questoes.Max(i => i.Id) + 1;
        }

        protected override List<Teste> ObterRegistros()
        {
            return contexto.Testes;
        }
    }
}
