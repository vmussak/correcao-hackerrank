using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao
{
    public interface IFilm
    {
        string Title { get; set; }

        string Director { get; set; }
    }

    public interface IFilmLibrary
    {
    }

    public class Film : IFilm
    {
        public string Title { get; set; }

        public string Director { get; set; }

        public int Year { get; set; }
    }

    public class FilmLibrary : IFilmLibrary
    {
        private List<IFilm> _films = new List<IFilm>();

        public void AddFilm(IFilm film) 
        {
            _films.Add(film);
        }

        public void RemoveFilm(string title)
        {
            var filmeQueVouExcluir = _films.FirstOrDefault(x => x.Title == title);

            if(filmeQueVouExcluir != null)
            {
                _films.Remove(filmeQueVouExcluir);
            }
        }

        public List<IFilm> GetFilms() 
        { 
            return _films; 
        }

        public IEnumerable<IFilm> SearchFilms(string query)
        {
            return _films.Where(
                x => x.Title.Contains(query)
                || x.Director.Contains(query)
            );
        }

        public int GetTotalFilmCount()
        {
            return _films.Count;
        }
    }
}
