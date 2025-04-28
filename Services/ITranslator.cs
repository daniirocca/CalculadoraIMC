namespace CalculadoraIMC.Services
{
    public interface ITranslator
    {
        string this[string key] { get; }   // Para pegar a tradução pela chave
        void SetCulture(string culture);   // Para mudar a cultura
    }
}
