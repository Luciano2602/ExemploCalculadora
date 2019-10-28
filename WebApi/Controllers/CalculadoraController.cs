using CalculadoraDomain.Calculadora;
using shared;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi.Controllers
{
    [RoutePrefix("api")]
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
    public class CalculadoraController : ApiController
    {
        [HttpPost]
        [Route("calculadora")]
        public async Task<Result<CalculadoraBase>> Calcular([FromBody] CalculadoraCommand command)
        {
            return await CalculadoraCommandHandler.Calcular(command);
        }
    }
}
