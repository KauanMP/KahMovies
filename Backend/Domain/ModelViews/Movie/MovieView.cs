using Domain.ModelViews.Director;
using Domain.ModelViews.Genre;
using Domain.ModelViews.Producers;
using Domain.ModelViews.Screenwrite;

namespace Domain.ModelViews
{
    public class MovieView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int Duration { get; set; }
        public int Classification { get; set; }
        public string StillImage { get; set; }
        public string Poster { get; set; }
        public string Trailer { get; set; }
        public string Sinopse { get; set; }
        public ICollection<ProducerView> Producers { get; set; }
        public ICollection<DirectorView> Directors { get; set; }
        public ICollection<GenreView> Genres { get; set; }
        public ICollection<ScreenwriteView> Screenwriter { get; set; }
    }
}