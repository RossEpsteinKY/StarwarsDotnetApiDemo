namespace SwDotnetApp.Models
{
    public class Films
    {
        public string? Title { get; set; }
        public int? EpisodeID { get; set; }
        public string? OpeningCrawl { get; set; }
        public string? Director { get; set; }
        public string? Producer { get; set; }
        public string? ReleaseDate { get; set;}
        public string[]? Characters { get; set;}
        public string[]? PlanetsInFilm { get; set; }
        public string[]? StarshipsInFilm { get; set; }
        public string[]? VehiclesInFilm { get; set; }
        public string[]? SpeciesInFilm { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Edited { get; set; }
        public string? URL { get; set; }

    }
}
