namespace CalculadoraIMC.Services
{
    public class ImcCalculatorService
    {
        public double CalcularImc(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        public string ClassificarImc(double imc)
        {
            if (imc < 18.5) return "Abaixo do peso";
            if (imc < 25) return "Peso normal";
            if (imc < 30) return "Sobrepeso";
            if (imc < 35) return "Obesidade grau I";
            if (imc < 40) return "Obesidade grau II";
            return "Obesidade grau III";
        }

        public string ObterRecomendacao(string classificacao)
        {
            return classificacao switch
            {
                "Abaixo do peso" => "Busque orientação nutricional para ganhar peso de forma saudável.",
                "Peso normal" => "Mantenha hábitos saudáveis com alimentação equilibrada e atividade física.",
                "Sobrepeso" => "Reduza o consumo de alimentos ultraprocessados e pratique exercícios regularmente.",
                "Obesidade grau I" => "Reavalie seus hábitos alimentares e consulte um profissional de saúde.",
                "Obesidade grau II" => "Requer atenção médica especializada para controle de peso e prevenção de doenças.",
                "Obesidade grau III" => "Procure acompanhamento médico contínuo para tratar possíveis comorbidades.",
                _ => ""
            };
        }

        public string ObterCor(string classificacao)
        {
            return classificacao switch
            {
                "Peso normal" => "lightgreen",
                "Sobrepeso" => "orange",
                "Abaixo do peso" => "gold",
                "Obesidade grau I" => "orangered",
                "Obesidade grau II" => "red",
                "Obesidade grau III" => "darkred",
                _ => "white"
            };
        }
    }
}
