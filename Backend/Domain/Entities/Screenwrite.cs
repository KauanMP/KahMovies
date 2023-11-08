using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Screenwrite
    {
        public int Id { get; set; }
        public string Screenwriter { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}