
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

        internal char AdicionarFormatoAlternativa(List<char> letrasUsadas)
        {
            char letra = (char)65;
            for (int i = 65; i < 91; i++)
            {
                letra = (char)i;
                if (!letrasUsadas.Contains(letra))
                {
                    Descricao = $"({letra}) -> {Descricao}";
                    break;
                }
            }
            return letra;
        }
        public void LimparRespostaCorreta()
        {
            Correta = false;
        }
    }
}