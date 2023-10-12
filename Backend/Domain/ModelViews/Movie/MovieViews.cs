using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ModelViews.Author;

namespace Domain.ModelViews
{
    public class MovieViews
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int Duration { get; set; }
        public int Classification { get; set; }
        public string Trailer { get; set; }
        public string Sinopse { get; set; }
        public ICollection<AuthorView> Authors { get; set; }
    }
}