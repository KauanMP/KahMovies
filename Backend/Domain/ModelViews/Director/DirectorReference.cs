using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.ModelViews.Director
{
    public class DirectorReference
    {
        [DefaultValue(0)]
        [Range(1, 30, ErrorMessage = "O campo autor é obrigatório.")]
        public int Id { get; set; }
    }
}