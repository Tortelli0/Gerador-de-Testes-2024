namespace GeradorDeTestes2024.Compartilhado
{
    internal interface IControladorPDF
    {
        string ToolTipPDF { get; }
        void GerarPDF();
    }
}
