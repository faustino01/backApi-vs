using backApi_vs.Entidades;
using backApi_vs.Filtros;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading.Tasks;


namespace backApi_vs.Controllers
{
    [Route("api/generos")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GenerosController:Controller
    {
        private readonly ILogger<GenerosController> logger;
        private readonly ApplicationDbContext context;

        public GenerosController(ILogger<GenerosController> logger, ApplicationDbContext context) {
            this.logger = logger;
            this.context = context;
        }
        [HttpGet]
      
        public async Task<ActionResult<List<Genero>>> Get()
        {
           // return new List<Genero>() { new Genero() { Id = 1, Nombre = "TINA TIN" } };
           return await context.Generos.ToListAsync();
        } 
      
        //se puede validar el tipo de parametro a recibir Id:int de esta manera se limita a solo tipo numerico
        [HttpGet("{Id:int}")]
        public async Task<ActionResult<Genero?>> Get(int Id) 
        {
              throw new NotImplementedException();
           
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Genero genero)
        {
            //throw new NotImplementedException();
            context.Add(genero);
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPut]
        public ActionResult Put([FromBody] Genero genero)
        {
            throw new NotImplementedException();

        }
        [HttpDelete]
        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}
