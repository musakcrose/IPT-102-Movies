using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
               new MovieViewModel { Id = 1, Name = "She’s Dating the Gangster", Distributed = "Star Cinema", Rating = "7/10 (IMDB)", ReleaseYear = 2014, Genre = "Romance, Comedy, Drama", YouTubeUrl = "https://www.youtube.com/watch?v=ONH5oAhqTro", ImageUrl = "/Images/1 ‘She’s Dating the Gangster’.jpg" },
            new MovieViewModel { Id = 2, Name = "Can’t Help Falling in Love", Distributed = "Star Cinema", Rating = "6/10 (IMDB)", ReleaseYear = 2017, Genre = "Romance, Comedy, Drama", YouTubeUrl = "https://www.youtube.com/watch?v=P9TYUdmn8Hk", ImageUrl = "/Images/2 ‘Can’t Help Falling in Love’.jpg" },
            new MovieViewModel { Id = 3, Name = "Must Be Love", Distributed = "Star Cinema", Rating = "6.5/10 (IMDB)", ReleaseYear = 2013, Genre = "Romance, Comedy, Drama", YouTubeUrl = "https://www.youtube.com/watch?v=qgbHV7ocK7Y", ImageUrl = "/Images/3 ‘Must Be Love’.jpg" },
            new MovieViewModel { Id = 4, Name = "Barcelona: A Love Untold", Distributed = "Star Cinema", Rating = "6.6/10 (IMDB)", ReleaseYear = 2016, Genre = "Drama, Romance", YouTubeUrl = "https://www.youtube.com/watch?v=oi_VrHQpFo8", ImageUrl = "/Images/4 ‘Barcelona - A Love Untold’.jpg" },
            new MovieViewModel { Id = 5, Name = "Loving in Tandem", Distributed = "Star Cinema", Rating = "6.5/10 (IMDB)", ReleaseYear = 2017, Genre = "Comedy, Romance", YouTubeUrl = "https://www.youtube.com/watch?v=NbtYGBgkSto", ImageUrl = "/Images/5 ‘Loving in Tandem’.jpg" },
            new MovieViewModel { Id = 6, Name = "24/7 In Love", Distributed = "Star Cinema", Rating = "6.3/10 (IMDB)", ReleaseYear = 2012, Genre = "Drama, Romance", YouTubeUrl = "https://www.youtube.com/watch?v=IvWHISNVOOA", ImageUrl = "/Images/6 '24-7 In Love'.jpg" },
            new MovieViewModel { Id = 7, Name = "Talk Back and You’re Dead", Distributed = "Star Cinema", Rating = "4.7/10 (IMDB)", ReleaseYear = 2014, Genre = "Comedy, Romance", YouTubeUrl = "https://www.youtube.com/watch?v=6sbT6VIThrs",  ImageUrl = "/Images/7 ‘Talk Back and You’re Dead’.jpg" },
            new MovieViewModel { Id = 8, Name = "I Love You, Hater", Distributed = "Star Cinema", Rating = "6.2/10 (IMDB)", ReleaseYear = 2018, Genre = "Comedy", YouTubeUrl = "https://www.youtube.com/watch?v=35ojcUg5wDA", ImageUrl = "/Images/8 ‘I Love You, Hater’.jpg" },
            new MovieViewModel { Id = 9, Name = "Love You to the Stars and Back", Distributed = "Star Cinema", Rating = "7.5/10 (IMDB)", ReleaseYear = 2017, Genre = "Adventure, Comedy, Drama", YouTubeUrl = "https://www.youtube.com/watch?v=GYDobu-adnI", ImageUrl = "/Images/9 ‘Love You to the Stars and Back’.jpg" },
            new MovieViewModel { Id = 10, Name = "Starting Over Again", Distributed = "Star Cinema", Rating = "6.9/10 (IMDB)", ReleaseYear = 2014, Genre = "Drama, Romance", YouTubeUrl = "https://www.youtube.com/watch?v=scVOj_3aiFg", ImageUrl = "/Images/10 ‘Starting Over Again’.jpg" },
            new MovieViewModel { Id = 11, Name = "Para sa Hopeless Romantic", Distributed = "Star Cinema", Rating = "5.5/10 (IMDB)", ReleaseYear = 2015, Genre = "Comedy, Drama, Romance", YouTubeUrl = "https://www.youtube.com/watch?v=eaf4blmJYE8", ImageUrl = "/Images/11 ‘Para sa Hopeless Romantic’.jpg" },
            new MovieViewModel { Id = 12, Name = "Crazy Beautiful You", Distributed = "Star Cinema", Rating = "7.0/10 (IMDB)", ReleaseYear = 2015, Genre = "Comedy, Drama, Romance", YouTubeUrl = "https://www.youtube.com/watch?v=2Xj6UJZJD3U", ImageUrl = "/Images/12 ‘Crazy Beautiful You’.jpg" },
            new MovieViewModel { Id = 13, Name = "Way Back Home", Distributed = "Star Cinema", Rating = "7.1/10 (IMDB)", ReleaseYear = 2011, Genre = "Drama", YouTubeUrl = "https://www.youtube.com/watch?v=U8tqvj37AQU", ImageUrl = "/Images/13 ‘Way Back Home’.jpg" },
            new MovieViewModel { Id = 14, Name = "Suddenly It’s Magic", Distributed = "Star Cinema", Rating = "5.8/10 (IMDB)", ReleaseYear = 2012, Genre = "Comedy, Romance", YouTubeUrl = "https://www.youtube.com/watch?v=4Dx2sdmcVxw", ImageUrl = "/Images/14 'Suddenly It’s Magic’.jpg" },
            new MovieViewModel { Id = 15, Name = "Finally Found Someone", Distributed = "Star Cinema", Rating = "5.8/10 (IMDB)", ReleaseYear = 2017, Genre = "Comedy, Romance", YouTubeUrl = "https://www.youtube.com/watch?v=8tjI5ALAvH4", ImageUrl = "/Images/15 ‘Finally Found Someone’.jpg" },
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

