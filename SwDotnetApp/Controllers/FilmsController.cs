using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
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


        [HttpGet("{id:int}")]
        // use `public` instead of `static`
        // only this is then visible in Swagger UI
        public async Task<Film> GetOneFilm(int id)
        {


            var response = await _client.GetAsync(baseUrl +  id);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("id is " + id);
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
                        release_date = _film.release_date,
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

        [HttpGet]
        public async Task<List<Film>> GetAllFilms()
        {
            List<Film> filmList = new List<Film>();
      
            var response = await _client.GetAsync(baseUrl);
            if (response.IsSuccessStatusCode)
            {

                
                //System.Diagnostics.Debug.WriteLine(response.Content);

                var jsonString = await response.Content.ReadAsStringAsync();
                JsonConvert.DeserializeObject<dynamic>(jsonString);
                
                dynamic _films = JsonConvert.DeserializeObject<dynamic>(jsonString);
                
                //var _films = JsonConvert.DeserializeObject<Film>(jsonString);
                
                
                foreach (var film in _films.results)
                {
                    var _film = JsonConvert.DeserializeObject<Film>(film.ToString());
                    filmList.Add(_film);
                }

                return filmList;
            }

            return filmList;
        }




    }
}
