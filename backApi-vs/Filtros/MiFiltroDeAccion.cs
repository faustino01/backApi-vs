using Microsoft.AspNetCore.Mvc.Filters;

namespace backApi_vs.Filtros
{
    public class MiFiltroDeAccion : IActionFilter
    {
        private readonly ILogger<MiFiltroDeAccion> _logger;
        public MiFiltroDeAccion(ILogger<MiFiltroDeAccion> logger) { 
            this._logger = logger;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("Antes de ejejcutar la accion");
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("despues de ejejcutar la accion");

        }


    }
}
