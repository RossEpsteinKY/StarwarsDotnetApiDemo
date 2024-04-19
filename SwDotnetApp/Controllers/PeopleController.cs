using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph.Models;
using Microsoft.OpenApi.Any;
using Newtonsoft.Json;
using SwDotnetApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using static System.Net.WebRequestMethods;

namespace SwDotnetApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController(HttpClient client) : ControllerBase
    {
        //private readonly HttpClient _httpClient;
        private HttpClient _client = client;
        private string baseUrl = "https://swapi.dev/api/people/";

        public object? Film { get; private set; }


        
        // use `public` instead of `static`
        // only this is then visible in Swagger UI
       
        [HttpGet]
        public async Task<List<object>> GetAllPeople()
        {
           List<dynamic> peopleList = new List<dynamic>();
      
            var response = await _client.GetAsync(baseUrl);
            if (response.IsSuccessStatusCode)
            {

                
                //System.Diagnostics.Debug.WriteLine(response.Content);

                var jsonString = await response.Content.ReadAsStringAsync();
                JsonConvert.DeserializeObject<dynamic>(jsonString);
                
                dynamic _people = JsonConvert.DeserializeObject<dynamic>(jsonString);
                
                //var _films = JsonConvert.DeserializeObject<Film>(jsonString);
                
                
                foreach (var people in _people.results)
                {
                    var _newPeople = JsonConvert.DeserializeObject<People>(people.ToString());
                    
                  
                    
                    peopleList.Add(_newPeople);
                }

                return peopleList;
            }

            return peopleList; 

                    }


        [HttpGet("{id:int}")]
        public async Task<object> GetOneFilm(int id)
        {

            dynamic newPerson = new ExpandoObject();
            var response = await _client.GetAsync(baseUrl +  id);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("id is " + id);
                var jsonString = await response.Content.ReadAsStringAsync();
                dynamic _person = JsonConvert.DeserializeObject<People>(jsonString);

                
                if (_person != null)
                {
                    return _person;
                }
            }
            return newPerson;
            
        }



    }
}
