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
using Newtonsoft.Json;

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
            string otherBaseUrl = "https://localhost:44318/api/users/";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);

            // Define result type:
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Convets object from JSON format
            string jsonString = JsonConvert.SerializeObject(user);
            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");   //Header

            // Wait result
            HttpResponseMessage response = client.PostAsync("login", stringContent).Result;  //Post

            // Check if it's not returned 200
            if (!response.IsSuccessStatusCode) return false;

            
            string result = response.Content.ReadAsStringAsync().Result;
            
            /*      Deserialization of received "Session" - by parts      */

            // Obtaining of needed indexes of json string
            int tokenIndex = result.IndexOf("\"token\""); // where starts token (since it's variable name)
            int lastCharRemoveIndex = result.LastIndexOf("\""); // where ends token

            // User part of Json
            string serializedUser = result.Substring(15, tokenIndex - 16);

            int serializedTokenLength = lastCharRemoveIndex - tokenIndex - 9; // Size of token (Difference between both indices - length of "token": )
           
            // Values assignment
            Session.Token = result.Substring(tokenIndex+9, serializedTokenLength); // corresponding part of token
            Session.CurrentUser = JsonConvert.DeserializeObject<User>(serializedUser); // deserialize of User
           
            return true;
        }

        /// <summary>
        /// Regists a user 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool Regist(User user)
        {
            string otherBaseUrl = "https://localhost:44318/api/users/";

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(baseUrl);

            // Define result type:
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Convets object from JSON format
            string jsonString = JsonConvert.SerializeObject(user);

            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");   //Header

            // Wait result
            HttpResponseMessage response = client.PostAsync("registerUser", stringContent).Result;  //Post
          
            // Check if it's returned 200
            if (response.IsSuccessStatusCode) return true;
            return false;
        }

    }
}
