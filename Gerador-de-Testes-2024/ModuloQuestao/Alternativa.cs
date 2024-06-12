namespace GeradorDeTestes2024.ModuloQuestao
{
    public class Alternativa
    {
        public string Texto { get; set; }
        public bool Correta { get; set; }

        public Alternativa(string texto)
        {
            Texto = texto;
            Correta = false;
        }

        public void MarcarCorreta()
        {
            Correta = true;
        }
    }
}