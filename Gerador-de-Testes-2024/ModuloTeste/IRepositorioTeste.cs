using GeradorDeTestes2024.ModuloDisciplina;

namespace GeradorDeTestes2024.ModuloTeste
{
    public interface IRepositorioTeste
    {
        void atualizarDependenciaDisciplina(Disciplina disciplinaSelecionada, Disciplina disciplinaEditada);
        void Cadastrar(Teste novaTeste);
        bool Editar(int id, Teste testeEditado);
        bool Excluir(int id);
        Teste SelecionarPorId(int id);
        List<Teste> SelecionarTodos();
    }
}
