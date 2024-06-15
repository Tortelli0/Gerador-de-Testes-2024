using GeradorDeTestes2024.ModuloQuestao;

namespace GeradorDeTestes2024.ModuloMateria
{
    public interface IRepositorioMateria
    {
        void AdicionarDependencia(Questao novoQuestao);
        void Cadastrar(Materia novaMateria);
        bool Editar(int id, Materia materiaEditada);
        bool Excluir(int id);
        Materia SelecionarPorId(int id);
        List<Materia> SelecionarTodos();
    }
}
