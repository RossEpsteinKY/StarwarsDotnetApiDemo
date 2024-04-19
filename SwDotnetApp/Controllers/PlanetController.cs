using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph.Models;
using Newtonsoft.Json;
using SwDotnetApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using static System.Net.WebRequestMethods;

namespace SwDotnetApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanetController(HttpClient client) : ControllerBase
    {
        //private readonly HttpClient _httpClient;
        private HttpClient _client = client;
        private string baseUrl = "https://swapi.dev/api/planets/";

        


        [HttpGet("{id:int}")]
        // use `public` instead of `static`
        // only this is then visible in Swagger UI
        public async Task<dynamic> GetOnePlanet(int id)
        {


            var response = await _client.GetAsync(baseUrl +  id);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("id is " + id);
                var jsonString = await response.Content.ReadAsStringAsync();
                var _planet = JsonConvert.DeserializeObject<Film>(jsonString);

                if (_planet!= null)
                {
                    return _planet;
                }
            }
            return new Planets();
            
        }

        [HttpGet]
        public async Task<List<object>> GetAllPlanets()
        {
            List<dynamic> planetList = new List<dynamic>();

            var response = await _client.GetAsync(baseUrl);
            if (response.IsSuccessStatusCode)
            {


                //System.Diagnostics.Debug.WriteLine(response.Content);

                var jsonString = await response.Content.ReadAsStringAsync();
                JsonConvert.DeserializeObject<dynamic>(jsonString);

                dynamic _planets = JsonConvert.DeserializeObject<dynamic>(jsonString);

                //var _films = JsonConvert.DeserializeObject<Film>(jsonString);


                foreach (var planet in _planets.results)
                {
                    var _newPlanet = JsonConvert.DeserializeObject<Planets>(planet.ToString());



                    planetList.Add(_newPlanet);
                }

                return planetList;
            }

            return planetList;

        }




    }
}
