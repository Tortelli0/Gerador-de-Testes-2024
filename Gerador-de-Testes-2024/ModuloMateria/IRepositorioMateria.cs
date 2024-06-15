using GeradorDeTestes2024.ModuloDisciplina;
using GeradorDeTestes2024.ModuloQuestao;

namespace GeradorDeTestes2024.ModuloMateria
{
    public interface IRepositorioMateria
    {
        void AdicionarDependenciaQuestao(Questao novoQuestao);
        void AtualizarDependenciaDisciplina(Disciplina disciplinaSelecionada, Disciplina disciplinaEditada);
        void AtualizarDependenciaQuestao(Questao questaoSelecionado, Questao questaoEditada);
        void Cadastrar(Materia novaMateria);
        bool Editar(int id, Materia materiaEditada);
        bool Excluir(int id);
        Materia SelecionarPorId(int id);
        List<Materia> SelecionarTodos();
    }
}
