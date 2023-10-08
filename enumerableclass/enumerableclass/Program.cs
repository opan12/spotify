using System;
using System.Collections.Generic;
using System.Linq;

public enum GenreType
{
    Comedy,
    Action,
  
}

class Movie
{
    public string Title { get; set; }
    public int Year { get; set; }
    public GenreType Genre { get; set; }
}

class Program
{
    static Movie[] GetComedyMovies()
    {
        Movie[] comedyMovies = { new Movie { Title = "recep ivedik", Year = 2008, Genre = GenreType.Comedy },
                                 new Movie { Title = "aile arasında", Year = 2019, Genre = GenreType.Comedy },
                                 new Movie { Title = "hangover", Year = 2021, Genre = GenreType.Comedy } };
        return comedyMovies;
    }

    static Movie[] GetActionMovies()
    {
        Movie[] actionMovies = { new Movie { Title = "fast and furious", Year = 2018, Genre = GenreType.Action },
                                 new Movie { Title = "batman", Year = 2022, Genre = GenreType.Action },
                                 new Movie { Title = "", Year = 2017, Genre = GenreType.Action } };
        return actionMovies;
    }

    public static void ConcatMovies()
    {
        Movie[] comedyMovies = GetComedyMovies();
        Movie[] actionMovies = GetActionMovies();

        IEnumerable<Movie> query =
            comedyMovies.Concat(actionMovies);

        foreach (Movie movie in query)
        {
            Console.WriteLine($"Title: {movie.Title}, Year: {movie.Year}, Genre: {movie.Genre}");
        }
    }

    static void Main(string[] args)
    {
        ConcatMovies();
    }
}

