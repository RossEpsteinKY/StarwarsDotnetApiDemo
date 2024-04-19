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
    public class ShipController(HttpClient client) : ControllerBase
    {
        //private readonly HttpClient _httpClient;
        private HttpClient _client = client;
        private string baseUrl = "https://swapi.dev/api/starships/";

        


        [HttpGet("{id:int}")]
        // use `public` instead of `static`
        // only this is then visible in Swagger UI
        public async Task<dynamic> GetOneStarship(int id)
        {


            var response = await _client.GetAsync(baseUrl +  id);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("id is " + id);
                var jsonString = await response.Content.ReadAsStringAsync();
                var _ship = JsonConvert.DeserializeObject<Ships>(jsonString);

                if (_ship!= null)
                {
                    return _ship;
                }
            }
            return new Ships();
            
        }

        [HttpGet]
        public async Task<List<object>> GetAllStarships()
        {
            List<dynamic> shipList = new List<dynamic>();

            var response = await _client.GetAsync(baseUrl);
            if (response.IsSuccessStatusCode)
            {


                //System.Diagnostics.Debug.WriteLine(response.Content);

                var jsonString = await response.Content.ReadAsStringAsync();
                JsonConvert.DeserializeObject<dynamic>(jsonString);

                dynamic _ships = JsonConvert.DeserializeObject<dynamic>(jsonString);

                foreach (var ship in _ships.results)
                {
                    var _newShip = JsonConvert.DeserializeObject<Ships>(ship.ToString());



                    shipList.Add(_newShip);
                }

                return shipList;
            }

            return shipList;

        }




    }
}
