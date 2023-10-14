using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain.ModelViews.Category
{
    public class CategoryReference
    {
        [DefaultValue(0)]
        [Range(1, 30, ErrorMessage = "O campo categoria é obrigatório.")]
        public int Id { get; set; }
    }
}