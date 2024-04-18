using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class FilmsController(HttpClient client) : ControllerBase
    {
        //private readonly HttpClient _httpClient;
        private HttpClient _client = client;
        private string baseUrl = "https://swapi.dev/api/films/";

        public object? Film { get; private set; }


        [HttpGet]
        // use `public` instead of `static`
        // only this is then visible in Swagger UI
        public async Task<Film> GetOneFilm(int Id )
        {


            var response = await _client.GetAsync(baseUrl +  Id);
            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var _film = JsonConvert.DeserializeObject<Film>(jsonString);

                if (_film != null)
                {
                    Film film = new Film
                    {
                        Title = _film.Title,
                        Producer = _film.Producer,
                        Director = _film.Director,
                        Created = _film.Created,
                        Edited = _film.Edited,
                        episode_Id = _film.episode_Id,
                        Vehicles = _film.Vehicles,
                        Characters = _film.Characters,
                        opening_crawl = _film.opening_crawl,
                        ReleaseDate = _film.ReleaseDate,
                        Species = _film.Species,
                        Planets = _film.Planets,
                        Starships = _film.Starships,
                        url = _film.url
                    };


                    return film;
                }
            }
            return new Film();
            
        }
        

        
    }
}
