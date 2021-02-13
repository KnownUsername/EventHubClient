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
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;

namespace Controller
{
    /// <summary>
    /// Controls Sport Events' methods, that interacts with View
    /// </summary>
    public static class EventController
    {

        static string baseUrl = "https://eventhub2021.azurewebsites.net/api/events/"; // base URL for Events'method

        #region SERVICE_REQUESTS
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
        public static bool CreateEvent(Event createdEvent)
        {
            string oldUrl = "https://localhost:44318/api/events/";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);

            // Define result type: JSON 
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Using token authorization
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Session.Token);

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


        /// <summary>
        /// GET -> Check if user is already registered in event, using it's email
        /// </summary>
        /// <param name="email"></param>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public static bool IsRegisteredInEvent(string email, int eventId)
        {



            return false;
        }


        /// <summary>
        /// GET -> Get latitude and longitude of a place
        /// </summary>
        /// <param name="local"></param>
        /// <returns></returns>
        public static Location GetCoordinates(string local)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);

            // Define result type: JSON 
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Wait result
            HttpResponseMessage response = client.GetAsync("getCoordinates/"+local).Result;

            // Check if it's returned 200
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;

                string encodedResult = RemoveEncoding(result); // removes overserialize
                string encodedResultFormatted = encodedResult.Substring(1, encodedResult.Length - 2); // takes out excessive characters

                Location eventLocation = new Location();
                eventLocation = GetCoordinatesFromJson(encodedResultFormatted); // take latitude and longitude from json
               
                return eventLocation;
            }

            return null;
        }

        #endregion

        #region AUX_METHODS
        /// <summary>
        /// Removes json extra formatted
        /// </summary>
        /// <param name="encodedJson"></param>
        /// <returns></returns>
        private static string RemoveEncoding(string encodedJson)
        {
            var sb = new StringBuilder(encodedJson);
            sb.Replace("\\", string.Empty);
            sb.Replace("\"[", "[");
            sb.Replace("]\"", "]");
            return sb.ToString();
        }


        /// <summary>
        /// Gets latitude and longitude from a json string
        /// </summary>
        /// <param name="jsonText"></param>
        /// <returns></returns>
        private static Location GetCoordinatesFromJson (string jsonText)
        {
            //      Regular Expressions for latitude and longitude
            string latitudeRegularExpression = "\"lat\":(-*[0-9]+\\.[0-9]+)";
            string longitudeRegularExpression = "\"lng\":(-*[0-9]+\\.[0-9]+)";

            //      Match of regular expression on text
            Match latitudeMatch = Regex.Match(jsonText, latitudeRegularExpression);
            Match longitudeMatch = Regex.Match(jsonText, longitudeRegularExpression);

            //      Check if there was matches
            if (!latitudeMatch.Success | !longitudeMatch.Success) return null;

            //      Store matched fields
            Location givenLocation = new Location();
            givenLocation.Latitude = latitudeMatch.Groups[1].Value;
            givenLocation.Longitude = longitudeMatch.Groups[1].Value;

            return givenLocation;
        }

        #endregion
    }
}