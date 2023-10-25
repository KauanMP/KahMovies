using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Director
    {
        public int Id { get; set; }
        public string DirectorName { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}