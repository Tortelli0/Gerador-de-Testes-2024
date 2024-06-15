using GeradorDeTestes2024.ModuloMateria;
using GeradorDeTestes2024.ModuloTeste;

namespace GeradorDeTestes2024.ModuloDisciplina
{
    public interface IRepositorioDisciplina
    {
        void AdicionarDependenciaMateria(Materia novaMateria);
        void AdicionarDependenciaTeste(Teste novoTeste);
        void Cadastrar(Disciplina novaDisciplina);
        bool Editar(int id, Disciplina disciplinaEditada);
        bool Excluir(int id);
        Disciplina SelecionarPorId(int id);
        List<Disciplina> SelecionarTodos();
    }
}
