namespace GeradorDeTestes2024.ModuloQuestao
{
    public class Alternativa
    {
        public string Descricao { get; set; }
        public bool Correta { get; set; }

        public Alternativa(string descricao)
        {
            Descricao = descricao;
            Correta = false;
        }

        public void MarcarCorreta()
        {
            Correta = true;
        }
        public override string ToString()
        {
            return $"{Descricao}";
        }
    }
}