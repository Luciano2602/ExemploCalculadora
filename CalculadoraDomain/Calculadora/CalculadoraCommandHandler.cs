using shared;
using System.Threading.Tasks;

namespace CalculadoraDomain.Calculadora
{
    public static class CalculadoraCommandHandler
    {
        public static async Task<Result<CalculadoraBase>> Calcular(CalculadoraCommand command)
        {
            var validar = await CalculadoraService.Validar(command);

            if (!validar.Valido)
                return await Task.FromResult(validar);

            var domain = CalculadoraFactory.Create(command);

            var model = CalculadoraFactory.Create(domain);

            return await Task.FromResult(Result<CalculadoraBase>.Sucesso(model));
        }
    }
}
