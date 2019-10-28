namespace CalculadoraDomain.Calculadora
{
    public abstract class CalculadoraBase
    {
        public decimal Numero1 { get; set; }
        public decimal Numero2 { get; set; }
        public OperacaoEnum Operacao { get; set; }
        public decimal Resultado { get; set; }
    }
}
