using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.ModelViews.Author;
using Domain.ModelViews.Category;

namespace Domain.ModelViews.Movie
{
    public class NewMovie
    {
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int Duration { get; set; }
        public int Classification { get; set; }
        public string Trailer { get; set; }
        public string Sinopse { get; set; }
        public ICollection<AuthorReference> Authors { get; set; }
        public ICollection<CategoryReference> Categories { get; set; }
    }
}