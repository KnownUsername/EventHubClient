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
        static string baseUrl = "https://localhost:44318/api/users/";


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

            Session.Token = response.Content.ReadAsStringAsync().Result;

            // Check if it's returned 200
            if (response.IsSuccessStatusCode) return true;

            return false;
        }


        /// <summary>
        /// Current Session of an user
        /// </summary>
        public static class Session
        {
            static User currentUser = new User();
            static string token;

            public static User CurrentUser
            {
                get => currentUser; set => currentUser = value;
            }
            public static string Token { get => token; set => token = value; }

        }
    }
}
