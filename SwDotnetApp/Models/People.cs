namespace SwDotnetApp.Models
{
    public class People
    {
		/**
        "name": "Luke Skywalker",
	"height": "172",
	"mass": "77",
	"hair_color": "blond",
	"skin_color": "fair",
	"eye_color": "blue",
	"birth_year": "19BBY",
	"gender": "male",
	"homeworld": "https://swapi.dev/api/planets/1/",
	"films": [
		"https://swapi.dev/api/films/1/",
		"https://swapi.dev/api/films/2/",
		"https://swapi.dev/api/films/3/",
		"https://swapi.dev/api/films/6/"
	],
	"species": [],
	"vehicles": [
		"https://swapi.dev/api/vehicles/14/",
		"https://swapi.dev/api/vehicles/30/"
	],
	"starships": [
		"https://swapi.dev/api/starships/12/",
		"https://swapi.dev/api/starships/22/"
	],
	"created": "2014-12-09T13:50:51.644000Z",
	"edited": "2014-12-20T21:17:56.891000Z",
	"url": "https://swapi.dev/api/people/1/"
		**/

		public string? Name { get; set; }
		public int? Height { get; set; }
		public int? Mass { get; set; }
		public string? Hair_Color { get; set; }
		public string? Skin_Color { get; set; }	
		public string? Eye_Color { get; set; }
		public string? Birth_Year { get; set; }
		public string? Gender { get; set; }
		public string[]? Films { get; set; }
		public string[]? Species { get; set; }
		public string[]? Vehicles { get; set; }
		public DateTime? Created { get; set; }
		public DateTime? Edited { get; set; }
		public string? URL { get; set; }



    }
}
