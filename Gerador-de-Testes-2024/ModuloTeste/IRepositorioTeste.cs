namespace GeradorDeTestes2024.ModuloTeste
{
    internal interface IRepositorioTeste
    {
        void Cadastrar(Teste novaTeste);
        bool Editar(int id, Teste testeEditado);
        bool Excluir(int id);
        Teste SelecionarPorId(int id);
        List<Teste> SelecionarTodos();
    }
}
