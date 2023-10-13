using System;
namespace BSIT3L_Movies.Models
{
    
	public class MovieViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Distributed { get; set; } // add distributed
        public string Rating { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string ImageUrl { get; set; } // add image url
        public string YouTubeUrl { get; set; } // Add YouTubeUrl property

    }
}

