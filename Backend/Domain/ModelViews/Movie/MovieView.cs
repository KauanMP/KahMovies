using Domain.ModelViews.Author;
using Domain.ModelViews.Category;

namespace Domain.ModelViews
{
    public class MovieView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int Duration { get; set; }
        public int Classification { get; set; }
        public string Image { get; set; }
        public string Trailer { get; set; }
        public string Sinopse { get; set; }
        public ICollection<AuthorView> Authors { get; set; }
        public ICollection<CategoryView> Categories { get; set; }
    }
}