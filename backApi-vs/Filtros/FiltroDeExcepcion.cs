﻿using Microsoft.AspNetCore.Mvc.Filters;

namespace backApi_vs.Filtros
{
    public class FiltroDeExcepcion:ExceptionFilterAttribute
    {
        private readonly ILogger<FiltroDeExcepcion> _logger;

        public FiltroDeExcepcion(ILogger<FiltroDeExcepcion> logger)
        {
            this._logger = logger;  
        }
        public override void OnException(ExceptionContext context)
        {
            _logger.LogError(context.Exception, context.Exception.Message);
            base.OnException(context);
        }

    }
}
