using backApi_vs.Entidades;
using backApi_vs.Entidades.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace backApi_vs.Controllers
{
    [Route("api/generos")]
    public class GenerosController
    {
        private readonly IRepositorio repositorio;

        public GenerosController(IRepositorio repositorio) {
            this.repositorio = repositorio;
        }
        [HttpGet]
        public List<Genero> Get()
        {
            return repositorio.ObtenerTodosLosGeneros();
        }
        //se puede validar el tipo de parametro a recibir Id:int de esta manera se limita a solo tipo numerico
        [HttpGet("{Id:int}/{nombre}")]
        public Genero? Get(int Id,string nombre) 
        {
            var genero = repositorio.ObtenerPorId(Id);
            if (genero == null)
            {

            }

            return genero;
        }

        [HttpPost]
        public void Post()
        {

        }
        [HttpPut]
        public void Put()
        {

        }
        [HttpDelete]
        public void Delete()
        {

        }
    }
}
