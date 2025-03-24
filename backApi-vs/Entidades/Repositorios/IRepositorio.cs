

namespace backApi_vs.Entidades.Repositorios
{
    public interface IRepositorio
    {
        Guid ObtenerGuid();
        Task<Genero?> ObtenerPorId(int Id);
        List<Genero> ObtenerTodosLosGeneros();

    }
}
