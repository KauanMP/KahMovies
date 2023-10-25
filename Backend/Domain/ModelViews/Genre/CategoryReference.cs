using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.ModelViews.Genre
{
    public class GenreReference
    {
        [DefaultValue(0)]
        [Range(1, 30, ErrorMessage = "O campo categoria é obrigatório.")]
        public int Id { get; set; }
    }
}