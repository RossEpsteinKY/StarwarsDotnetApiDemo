namespace SwDotnetApp.Models
{
    public class Ships
    {
      /**  "name": "Death Star",
	"model": "DS-1 Orbital Battle Station",
	"manufacturer": "Imperial Department of Military Research, Sienar Fleet Systems",
	"cost_in_credits": "1000000000000",
	"length": "120000",
	"max_atmosphering_speed": "n/a",
	"crew": "342,953",
	"passengers": "843,342",
	"cargo_capacity": "1000000000000",
	"consumables": "3 years",
	"hyperdrive_rating": "4.0",
	"MGLT": "10",
	"starship_class": "Deep Space Mobile Battlestation",
	"pilots": [],
	"films": [
		"https://swapi.dev/api/films/1/"
	],
	"created": "2014-12-10T16:36:50.509000Z",
	"edited": "2014-12-20T21:26:24.783000Z",
	"url": "https://swapi.dev/api/starships/9/"

**/

		public string? Name { get; set; }
		public string? Model { get; set; }
		public string? Manufacturer { get; set; }
		public string? Cost_In_Credits { get; set; }
		public string? Length { get; set; }
		public string? Max_Atmosphering_Speed { get; set; }
		public string? Crew { get; set; }
		public string? Passengers { get; set; }
		public string? Cargo_Capacity{ get; set; }
		public string? Hyperdrive_Rating { get; set; }
		public string? MGLT { get; set; }
		public string? Starship_Class { get; set; }
        public string[]? Pilots { get; set; }
		public string[]? Films { get; set; }
		public DateTime? Created { get; set; }
		public DateTime? Edited { get; set; }
		public string? URL { get; set; }



    }
}
