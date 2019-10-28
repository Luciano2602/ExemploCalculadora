namespace CalculadoraDomain.Calculadora
{
    public class CalculadoraDomain
    {
        public CalculadoraDomain(Calculo calculo, OperacaoEnum operacao)
        {
            Calculo = calculo;
            Operacao = operacao;
            this.CalcularOperacao();
        }

        public Calculo Calculo { get; private set; }
        public OperacaoEnum Operacao { get; private set; }
        public decimal Resultado { get; private set; }

        private void CalcularOperacao()
        {
            if (!Calculo.Validar()) return;

            if (Operacao == OperacaoEnum.Adicao)
                Resultado = Calculo.Numero1 + Calculo.Numero2;

            if (Operacao == OperacaoEnum.Subtracao)
                Resultado = Calculo.Numero1 - Calculo.Numero2;

            if (Operacao == OperacaoEnum.Divisao)
                Resultado = Calculo.Numero1 / Calculo.Numero2;

            if (Operacao == OperacaoEnum.Multiplicacao)
                Resultado = Calculo.Numero1 * Calculo.Numero2;
        }

        public bool Validar()
        {
            return Resultado > 0;
        }
    }
}
