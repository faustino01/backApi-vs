
namespace backApi_vs.Entidades.Repositorios
{
    public interface IRepositorio
    {
        Genero? ObtenerPorId(int Id);
        List<Genero> ObtenerTodosLosGeneros();
    }
}
