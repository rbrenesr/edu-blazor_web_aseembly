using BlazorPeliculas.Shared.Entidades;

namespace BlazorPeliculas.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>() {
            new Pelicula {
                Titulo ="Capitan América",
                FechaLanzamiento = new DateTime(2023,01,01),
                Poster = "https://upload.wikimedia.org/wikipedia/en/b/bf/CaptainAmericaHughes.jpg"},
            new Pelicula {
                Titulo ="Spiderman",
                FechaLanzamiento = new DateTime(2024,01,01),
                Poster = "https://upload.wikimedia.org/wikipedia/en/2/21/Web_of_Spider-Man_Vol_1_129-1.png"},
            new Pelicula {
                Titulo ="Moana",
                FechaLanzamiento = new DateTime(2025,03,14),
                Poster = "https://upload.wikimedia.org/wikipedia/en/2/26/Moana_Teaser_Poster.jpg"},
        };
        }
    }
}
