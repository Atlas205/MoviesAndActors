// See https://aka.ms/new-console-template for more information
using MoviesAndActors;

var repo = new MovieRepository();

foreach (Movie m in repo.GetMovieInfo("Wars"))
{
    Console.WriteLine(m.Title);
}

foreach(Movie m in repo.GetAllInCategory("horror"))// create categories
{
    Console.WriteLine(m.Category);
}
