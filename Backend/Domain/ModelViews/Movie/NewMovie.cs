using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Domain.ModelViews.Director;
using Domain.ModelViews.Genre;
using Domain.ModelViews.Producers;
using Domain.ModelViews.Screenwrite;

namespace Domain.ModelViews.Movie
{
    public class NewMovie
    {
        [Required(ErrorMessage = "O campo título é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo título deve ter no maxímo 100 caracteres.")]
        [MinLength(3, ErrorMessage = "O campo título deve ter no mínimo 3 caracteres.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "O campo Data de lançamento é obrigatório.")]
        [DisplayFormat(DataFormatString = "yyyy/mm/dd")]
        public DateTime ReleaseYear { get; set; }

        [Required(ErrorMessage = "O campo duração é obrigatório.")]
        [DefaultValue(0)]
        [Range(1, 5220, ErrorMessage = "O tempo de duração deve ser maior que zero")]
        public int Duration { get; set; }

        [Required(ErrorMessage = "O campo duração é obrigatório.")]
        [DefaultValue(0)]
        [Range(1, 18, ErrorMessage = "O tempo de duração deve ser maior que zero")]
        public int Classification { get; set; }

        public string Poster { get; set; }
        
        [Url(ErrorMessage = "A URL é invalida")]
        public string Trailer { get; set; }

        public string Sinopse { get; set; }
        public ICollection<ProducerReference> Producers { get; set; }
        public ICollection<DirectorReference> Directors { get; set; }
        public ICollection<GenreReference> Genres { get; set; }
        public ICollection<ScreenwriteReference> ScreenWriter { get; set; }
    }
}