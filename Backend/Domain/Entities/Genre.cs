using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreMovie { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}