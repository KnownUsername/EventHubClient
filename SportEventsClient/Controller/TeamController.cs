/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [CONTROLLER]
 * TeamController -> Controls Teams'methods, that interacts with View
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Model;
using Newtonsoft.Json;

namespace Controller
{
    /// <summary>
    /// Controls Teams'methods, that interacts with View
    /// </summary>
    public static class TeamController
    {
        static string baseUrl = "https://eventhub2021.azurewebsites.net/api/teams/";

        
        /// <summary>
        /// GET -> Current teams, the user current belongs
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static List<Team> GetTeams(int userId)
        {

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(baseUrl);

            // Define result type:
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Convets object from JSON format
            string jsonString = JsonConvert.SerializeObject(userId);

            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");   //Header

            // Wait result
            HttpResponseMessage response = client.PostAsync("registerUser", stringContent).Result;  //GET

            // Check if it's returned 200
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                List<Team> teams = new List<Team>();
                teams = JsonConvert.DeserializeObject<List<Team>>(result);
                return teams;
            }

            return null;
        }
    
    }
}
