using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.MoviesInfo;

namespace Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int Duration { get; set; }
        public int Classification { get; set; }
        public string Poster { get; set; }
        public string Trailer { get; set; }
        public string Sinopse { get; set; }
        public ICollection<Producer> Producers { get; set; }
        public ICollection<Director> Directors { get; set; }
        public ICollection<Genre> Genres { get; set; }
    }
}