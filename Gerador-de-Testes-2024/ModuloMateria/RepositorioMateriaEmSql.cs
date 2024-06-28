using Microsoft.Data.SqlClient;

namespace GeradorDeTestes2024.ModuloMateria
{
    public class RepositorioMateriaEmSql : IRepositorioMateria
    {
        private string enderecoBanco;

        public RepositorioMateriaEmSql()
        {
            enderecoBanco = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=GeradorTesteDB;Integrated Security=True;Pooling=False";
        }

        private const string sqlInserir =
            @"INSERT INTO [TBMATERIA]
                (
                    [NOME],
                    [SERIE],
                    [DISCIPLINA_ID],
                    [QUESTOES_ID]
                )
                VALUES
                (
                    @NOME,
                    @SERIE,
                    @DISCIPLINA_ID,
                    @QUESTOES_ID
                ); SELECT SCOPE_IDENTITY();

";

        public void Cadastrar(Materia novaMateria)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexaoComBanco);

            comandoInsercao.Parameters.AddWithValue("Id", novaMateria.Id);
            comandoInsercao.Parameters.AddWithValue("Nome", novaMateria.Nome);
            comandoInsercao.Parameters.AddWithValue("Serie", novaMateria.Serie);

            comandoInsercao.Parameters.AddWithValue("DISCIPLINA_ID", novaMateria.Disciplina.Id);
            comandoInsercao.Parameters.AddWithValue("QUESTOES_ID", novaMateria.Questoes.Id);

            conexaoComBanco.Open();

            conexaoComBanco.Close();
        }

        public bool Editar(int id, Materia materiaEditada)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public Materia SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Materia> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
