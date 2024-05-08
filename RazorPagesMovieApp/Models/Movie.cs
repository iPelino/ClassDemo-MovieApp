using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovieApp.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    public decimal Price { get; set; }

    // public List<Actor> Actors { get; set; }
    
}
