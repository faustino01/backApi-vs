
namespace backApi_vs.Entidades.Repositorios
{
    public interface IRepositorio
    {
        Task<Genero?> ObtenerPorId(int Id);
        List<Genero> ObtenerTodosLosGeneros();
    }
}
