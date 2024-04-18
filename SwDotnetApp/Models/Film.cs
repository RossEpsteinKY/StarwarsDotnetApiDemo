namespace SwDotnetApp.Models
{
    public class Film
    {
       public string? Title { get; set; }
        public int? episode_Id { get; set; }
        public string? opening_crawl { get; set; }
        public string? Director { get; set; }
        public string? Producer { get; set; }
        public string? release_date { get; set;}
        public string[]? Characters { get; set;}
        public string[]? Planets { get; set; }
        public string[]? Starships { get; set; }
        public string[]? Vehicles{ get; set; }
        public string[]? Species{ get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Edited { get; set; }

        public string url { get; set; }
    }

    public class AllFilms
    {
        public Film[]? FilmsList { get; set; }

        
    }
}
