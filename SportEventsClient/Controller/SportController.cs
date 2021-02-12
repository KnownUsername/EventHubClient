/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [CONTROLLER]
 * SportController -> Controls Sports' methods, that interacts with View
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */

using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Controller
{
    /// <summary>
    /// Controls Sports' methods, that interacts with View
    /// </summary>
    public static class SportController
    {

        static string baseUrl = "https://eventhub2021.azurewebsites.net/api/sports/"; // base URL for Events'method

        /// <summary>
        /// GET -> List of ãvailable sports
        /// </summary>
        /// <returns></returns>
        public static List<Sport> GetSports()
        {
            string method;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);

            // Define result type: JSON 
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Wait result
            HttpResponseMessage response = client.GetAsync("getSports").Result;

            // Check if it's returned 200
            if (response.IsSuccessStatusCode)
            {
                string listSerialized = response.Content.ReadAsStringAsync().Result; // allocate result of request, on string
                List<Sport> sports = new List<Sport>();
                sports = JsonConvert.DeserializeObject<List<Sport>>(listSerialized); // Converting string's result to Sport type 
                return sports;
            }

            return null; // Case insucess on request
        }
    }
}
