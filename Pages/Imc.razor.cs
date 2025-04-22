using Microsoft.AspNetCore.Components;
using CalculadoraIMC.Services;

namespace CalculadoraIMC.Pages
{


    public partial class Imc : ComponentBase
    {
        protected double? ResultadoIMC;
        protected string Classificacao = string.Empty;
        protected string Recomendacao = string.Empty;

        [Inject]
        public ImcCalculatorService ImcService { get; set; }

        protected void HandleSubmit((double altura, double peso) dados)
        {
            ResultadoIMC = ImcService.CalcularImc(dados.peso, dados.altura);
            Classificacao = ImcService.ClassificarImc(ResultadoIMC.Value);
            Recomendacao = ImcService.ObterRecomendacao(Classificacao);
        }

    }

}
