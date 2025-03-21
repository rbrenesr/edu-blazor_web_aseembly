using BlazorPeliculas.Shared.Entidades;

namespace BlazorPeliculas.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>() {
            new Pelicula { Titulo ="Pelicula 01", FechaLanzamiento = new DateTime(2023,01,01)},
            new Pelicula { Titulo ="Pelicula 02", FechaLanzamiento = new DateTime(2024,01,01)},
            new Pelicula { Titulo ="Pelicula 03", FechaLanzamiento = new DateTime(2025,03,14)},
        };
        }
    }
}
