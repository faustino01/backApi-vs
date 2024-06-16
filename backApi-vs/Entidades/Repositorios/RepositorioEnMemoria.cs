namespace backApi_vs.Entidades.Repositorios
{
    public class RepositorioEnMemoria : IRepositorio
    {
        private List<Genero> _generos;
        public RepositorioEnMemoria()
        {
            _generos = new List<Genero>()
            {
                    new Genero(){Id = 1, Nombre = "Comedia"},
                    new Genero(){Id = 2, Nombre = "Ficcion"}

            };
        }
        public List<Genero> ObtenerTodosLosGeneros()
        {
            return _generos;
        }

        public Genero? ObtenerPorId(int Id)
        {
            return _generos.FirstOrDefault(x => x.Id == Id);
        }
    }
}
