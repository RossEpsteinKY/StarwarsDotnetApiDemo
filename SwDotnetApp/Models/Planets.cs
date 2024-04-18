namespace SwDotnetApp.Models
{
	public class Planets
	{

		/** 
         * name": "Yavin IV",
	"rotation_period": "24",
	"orbital_period": "4818",
	"diameter": "10200",
	"climate": "temperate, tropical",
	"gravity": "1 standard",
	"terrain": "jungle, rainforests",
	"surface_water": "8",
	"population": "1000",
	"residents": [],
	"films": [
		"https://swapi.dev/api/films/1/"
	],
	"created": "2014-12-10T11:37:19.144000Z",
	"edited": "2014-12-20T20:58:18.421000Z",
	"url": "https://swapi.dev/api/planets/3/"
         * **/

		public string? Name { get; set; }
		public int? RotationPeriod { get; set; }

		public int? OrbitalPeriod { get; set; }

		public int? Diameter { get; set; }
		public string? Climate { get; set; }
		public string? Gravity { get; set; }
		public string? Terrain { get; set; }
		public int? SurfaceWater { get; set; }
		public int? Population { get; set; }

		public string[]? Residents { get; set; }
		public string[]? Films { get; set; }
		public DateTime? Created { get; set; }
		public DateTime? Edited { get; set; }
		public string? URL { get; set; }


    }
}
