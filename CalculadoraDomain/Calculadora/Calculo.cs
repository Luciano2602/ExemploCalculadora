namespace CalculadoraDomain.Calculadora
{
    public class Calculo
    {
        public Calculo(decimal numero1, decimal numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public decimal Numero1 { get; private set; }
        public decimal Numero2 { get; private set; }

        public bool Validar()
        {
            return Numero1 > 0 && Numero2 > 0;
        }
    }
}
