using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
            new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", Image = "~/images/titanic.jpg" },
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller", Image = "~/images/inception.jpg" },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama", Image = "~/images/TheShawshankRedemption.jpg" },
            new MovieViewModel { Id = 4, Name = "Nanny McPhee", Rating = "4", ReleaseYear = 2005, Genre = "Fantasy", Image = "~/images/Nanny McPhee.jpg" },
            new MovieViewModel { Id = 5, Name = "Matilda", Rating = "4", ReleaseYear = 1996, Genre = "Fantasy", Image = "~/images/Matilda.jpg" },
            new MovieViewModel { Id = 6, Name = "Luck", Rating = "4", ReleaseYear = 2002, Genre = "Comedy", Image = "~/images/Luck.jpg" },
            new MovieViewModel { Id = 7, Name = "The Witches", Rating = "3", ReleaseYear = 2020, Genre = "Comedy", Image = "~/images/The Witches.jpg" },
            new MovieViewModel { Id = 8, Name = "Love at First Sight", Rating = "4", ReleaseYear = 2023, Genre = "Romance/Drama", Image = "~/images/Love At First Sight.jpg" },
            new MovieViewModel { Id = 9, Name = "Persuasion", Rating = "2", ReleaseYear = 2022, Genre = "Romance/Drama", Image = "~/images/Persuasion.jpg" },
            new MovieViewModel { Id = 10, Name = "After We fell", Rating = "3", ReleaseYear = 2021, Genre = "Romance/Drama", Image = "~/images/After We Fell.jpg" },
            new MovieViewModel { Id = 11, Name = "The Invitation", Rating = "2", ReleaseYear = 2022, Genre = "Horror", Image = "~/images/The Invitation.jpg" },
            new MovieViewModel { Id = 12, Name = "Incantation", Rating = "3", ReleaseYear = 2022, Genre = "Horror", Image = "~/images/Incantation.jpg" },
            new MovieViewModel { Id = 13, Name = "True Beauty", Rating = "4", ReleaseYear = 2020, Genre = "Romance/Drama", Image = "~/images/True Beauty.jpg" },
            new MovieViewModel { Id = 14, Name = "Train to Busan", Rating = "5", ReleaseYear = 2016, Genre = "Horror", Image = "~/images/Train To Busan.jpg" },
            new MovieViewModel { Id = 15, Name = "The 8th Night", Rating = "3", ReleaseYear = 2021, Genre = "Horror", Image = "~/images/The 8th Night.jpg" },



        };
    }

    public IActionResult Index()
    {
        return View(_movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

