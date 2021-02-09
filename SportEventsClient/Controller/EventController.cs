/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [Controller]
 * EventController -> Controls Sport Events' methods, that interacts with View
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
using System.Text;


namespace Controller
{
    /// <summary>
    /// Controls Sport Events' methods, that interacts with View
    /// </summary>
    public static class EventController
    {

        static string baseUrl = "https://localhost:44318/api/events/"; // base URL for Events'method


        /// <summary>
        /// GET -> list of events, based on eventType, using HttpClient
        /// </summary>
        /// <param name="eventType"></param>
        /// <returns></returns>
        public static List<Event> GetEvents(EventType eventType)
        {
            string method;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);

            // Define result type: JSON 
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Using token authorization
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Session.Token);

            // Method pick, based on type of event
            if (eventType == EventType.Friendly) method = "GetFriendlyEvents";
            else method = "GetCompEvents";

            // Wait result
            HttpResponseMessage response = client.GetAsync(method).Result;

            // Check if it's returned 200
            if (response.IsSuccessStatusCode)
            {
                string listSerialized = response.Content.ReadAsStringAsync().Result; // allocate result of request, on string
                List<Event> events = new List<Event>();
                events = JsonConvert.DeserializeObject<List<Event>>(listSerialized); // Converting string's result to Event type 
                return events;
            }

            return null; // Case insucess on request
        }
         

        /// <summary>
        /// POST -> Requests service to create an event
        /// </summary>
        /// <param name="createdEvent"></param>
        /// <returns></returns>
        public static bool CreateEventRequest(Event createdEvent)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);

            // Define result type: JSON 
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Convets object from JSON format
            string jsonString = JsonConvert.SerializeObject(createdEvent);
            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");   // Header

            // Wait result
            HttpResponseMessage response = client.PostAsync("createEvent", stringContent).Result;  // Post

            Session.Token = response.Content.ReadAsStringAsync().Result;

            // Check if it's returned 200
            if (response.IsSuccessStatusCode) return true;

            return false;
        }

    }
}