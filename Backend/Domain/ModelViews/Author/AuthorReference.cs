using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.ModelViews.Author
{
    public class AuthorReference
    {
        [DefaultValue(0)]
        [Range(1, 30, ErrorMessage = "O campo autor é obrigatório.")]
        public int Id { get; set; }
    }
}