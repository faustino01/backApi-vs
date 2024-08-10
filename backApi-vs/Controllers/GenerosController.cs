using backApi_vs.Entidades;
using backApi_vs.Entidades.Repositorios;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace backApi_vs.Controllers
{
    [Route("api/generos")]
    [ApiController]
    public class GenerosController:Controller
    {
        private readonly IRepositorio repositorio;

        public GenerosController(IRepositorio repositorio) {
            this.repositorio = repositorio;
        }
        [HttpGet]
        public ActionResult<List<Genero>> Get()
        {
            return repositorio.ObtenerTodosLosGeneros();
        }
        //se puede validar el tipo de parametro a recibir Id:int de esta manera se limita a solo tipo numerico
        [HttpGet("{Id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Genero?>> Get_ActionText(int Id, [FromHeader] string nombre) 
        {
          
            var genero = await repositorio.ObtenerPorId(Id);
            if (genero == null)
            {
               return NotFound();
            }


            return genero;

        }

        [HttpPost]
        public ActionResult Post([FromBody] Genero genero)
        {
            return NoContent();
        }
        [HttpPut]
        public ActionResult Put([FromBody] Genero genero)
        {
            return NoContent();
        }
        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }
    }
}
