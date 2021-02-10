/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [CONTROLLER]
 * UserController -> Controls User's methods, that interacts with View
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */

using Model;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Controller
{

    /// <summary>
    /// Controls User's methods, that interacts with View
    /// </summary>
    public static class UserController
    {
        static string baseUrl = "https://eventhub2021.azurewebsites.net/api/users/";

        /// <summary>
        /// Login of a user 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool Login(User user)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);

            // Define result type:
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Convets object from JSON format
            string jsonString = JsonSerializer.Serialize(user);
            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");   //Header

            // Wait result
            HttpResponseMessage response = client.PostAsync("login", stringContent).Result;  //Post

            string result = response.Content.ReadAsStringAsync().Result;
            int tokenIndex = result.IndexOf("\"token\"");

            string serializedUser = result.Substring(1,tokenIndex-2);
            
            int serializedTokenLength = result.Length - tokenIndex;
            string serializedToken = result.Substring(tokenIndex, serializedTokenLength-1);

            //Session.Token = JsonSerializer.Deserialize<string>(serializedToken);
            Session.CurrentUser = JsonSerializer.Deserialize<User>(serializedUser);

            //Session = JsonSerializer.Deserialize(Session); 
            
            //Session.Token = result.Substring(1, result.Length - 2);

            // Check if it's returned 200
            if (response.IsSuccessStatusCode) return true;

            return false;
        }

        /// <summary>
        /// Regists a user 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool Regist(User user)
        {
            HttpClient client = new HttpClient();
            string newBaseUrl = "https://localhost:44318/api/users/";
            client.BaseAddress = new Uri(newBaseUrl);

            // Define result type:
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Convets object from JSON format
            string jsonString = JsonSerializer.Serialize(user);
            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");   //Header

            // Wait result
            HttpResponseMessage response = client.PostAsync("registerUser", stringContent).Result;  //Post

            string result = response.Content.ReadAsStringAsync().Result;

            // Check if it's returned 200
            if (response.IsSuccessStatusCode) return true;

            return false;
        }



    }
}
