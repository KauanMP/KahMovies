using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities.MoviesInfo
{
    public class Producer
    {
        public int Id { get; set; }
        public string ProducerName { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}