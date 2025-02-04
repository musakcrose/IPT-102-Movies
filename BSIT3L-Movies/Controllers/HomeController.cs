﻿using System.Diagnostics;
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
            new MovieViewModel { Id = 1, Name = "She’s Dating the Gangster", Rating = "7/10 (IMDB)", ReleaseYear = 2014, Genre = "Romance, Comedy, Drama", ImageUrl = "/Images/1 ‘She’s Dating the Gangster’.jpg" },
            new MovieViewModel { Id = 2, Name = "Can’t Help Falling in Love", Rating = "6/10 (IMDB)", ReleaseYear = 2017, Genre = "Romance, Comedy, Drama", ImageUrl = "/Images/2 ‘Can’t Help Falling in Love’.jpg" },
            new MovieViewModel { Id = 3, Name = "Must Be Love", Rating = "6.5/10 (IMDB)", ReleaseYear = 2013, Genre = "Romance, Comedy, Drama", ImageUrl = "/Images/3 ‘Must Be Love’.jpg" },
            new MovieViewModel { Id = 4, Name = "Barcelona: A Love Untold", Rating = "6.6/10 (IMDB)", ReleaseYear = 2016, Genre = "Drama, Romance", ImageUrl = "/Images/4 ‘Barcelona - A Love Untold’.jpg" },
            new MovieViewModel { Id = 5, Name = "Loving in Tandem", Rating = "6.5/10 (IMDB)", ReleaseYear = 2017, Genre = "Comedy, Romance", ImageUrl = "/Images/5 ‘Loving in Tandem’.jpg" },
            new MovieViewModel { Id = 6, Name = "24/7 In Love", Rating = "6.3/10 (IMDB)", ReleaseYear = 2012, Genre = "Drama, Romance", ImageUrl = "/Images/6 '24-7 In Love'.jpg" },
            new MovieViewModel { Id = 7, Name = "Talk Back and You’re Dead", Rating = "4.7/10 (IMDB)", ReleaseYear = 2014, Genre = "Comedy, Romance", ImageUrl = "/Images/7 ‘Talk Back and You’re Dead’.jpg" },
            new MovieViewModel { Id = 8, Name = "I Love You, Hater", Rating = "6.2/10 (IMDB)", ReleaseYear = 2018, Genre = "Comedy", ImageUrl = "/Images/8 ‘I Love You, Hater’.jpg" },
            new MovieViewModel { Id = 9, Name = "Love You to the Stars and Back", Rating = "7.5/10 (IMDB)", ReleaseYear = 2017, Genre = "Adventure, Comedy, Drama", ImageUrl = "/Images/9 ‘Love You to the Stars and Back’.jpg" },
            new MovieViewModel { Id = 10, Name = "Starting Over Again", Rating = "6.9/10 (IMDB)", ReleaseYear = 2014, Genre = "Drama, Romance", ImageUrl = "/Images/10 ‘Starting Over Again’.jpg" },
            new MovieViewModel { Id = 11, Name = "Para sa Hopeless Romantic", Rating = "5.5/10 (IMDB)", ReleaseYear = 2015, Genre = "Comedy, Drama, Romance", ImageUrl = "/Images/11 ‘Para sa Hopeless Romantic’.jpg" },
            new MovieViewModel { Id = 12, Name = "Crazy Beautiful You", Rating = "7.0/10 (IMDB)", ReleaseYear = 2015, Genre = "Comedy, Drama, Romance", ImageUrl = "/Images/12 ‘Crazy Beautiful You’.jpg" },
            new MovieViewModel { Id = 13, Name = "Way Back Home", Rating = "7.1/10 (IMDB)", ReleaseYear = 2011, Genre = "Drama", ImageUrl = "/Images/13 ‘Way Back Home’.jpg" },
            new MovieViewModel { Id = 14, Name = "Suddenly It’s Magic", Rating = "5.8/10 (IMDB)", ReleaseYear = 2012, Genre = "Comedy, Romance", ImageUrl = "/Images/14 'Suddenly It’s Magic’.jpg" },
            new MovieViewModel { Id = 15, Name = "Finally Found Someone", Rating = "5.8/10 (IMDB)", ReleaseYear = 2017, Genre = "Comedy, Romance", ImageUrl = "/Images/15 ‘Finally Found Someone’.jpg" },
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

