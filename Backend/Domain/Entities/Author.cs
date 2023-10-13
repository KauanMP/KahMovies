using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}