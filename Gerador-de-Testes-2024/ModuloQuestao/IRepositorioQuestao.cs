using GeradorDeTestes2024.ModuloTeste;

namespace GeradorDeTestes2024.ModuloQuestao
{
    public interface IRepositorioQuestao
    {
        void AdicionarDependencia(Teste novoTeste);
        void AtualizarDependencia(Teste testeSelecionado, Teste testeEditado);
        void Cadastrar(Questao novoQuestao);
        bool Editar(int id, Questao questaoEditado);
        bool Excluir(int id);
        Questao SelecionarPorId(int id);
        List<Questao> SelecionarTodos();
    }
}
