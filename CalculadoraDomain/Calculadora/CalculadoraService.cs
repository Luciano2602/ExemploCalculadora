using shared;
using System.Threading.Tasks;

namespace CalculadoraDomain.Calculadora
{
    public static class CalculadoraService
    {
        public static async Task<Result<CalculadoraBase>> Validar(CalculadoraCommand command)
        {
            if (OperacaoEnum.Divisao == command.Operacao && command.Numero2 == 0)
                return await Task.FromResult(Result<CalculadoraBase>.Falha(command, "Não é possível dividir por zero"));

            if (command.Numero1 <= 0 || command.Numero2 <= 0)
                return await Task.FromResult(Result<CalculadoraBase>.Falha(command, "Não pode ter numero zero."));

            return await Task.FromResult(Result<CalculadoraBase>.Sucesso());
        }
    }
}
