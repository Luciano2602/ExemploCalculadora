namespace CalculadoraDomain.Calculadora
{
    public static class CalculadoraFactory
    {
        public static CalculadoraDomain Create(CalculadoraCommand command)
        {
            return new CalculadoraDomain(new Calculo(command.Numero1, command.Numero2), command.Operacao);
        }

        public static CalculadoraViewModel Create(CalculadoraDomain domain)
        {
            return new CalculadoraViewModel() { Numero1 = domain.Calculo.Numero1, Numero2 = domain.Calculo.Numero1, Operacao = domain.Operacao, Resultado = domain.Resultado };
        }
    }
}
