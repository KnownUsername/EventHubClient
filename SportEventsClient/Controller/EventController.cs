using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using static Controller.UserController;


namespace Controller
{
    /// <summary>
    /// Controls Sport Events' methods
    /// </summary>
    /// <obs>
    /// Ponderate use other way to implement function (like in UserController)
    /// </obs>
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
        /// Gives a list with all competitive events
        /// </summary>
        /// <returns></returns>
        public static List<Event> GetCompetitiveEvents()
        {
            List<Event> events = new List<Event>();

            #region URIConstruction
            HttpWebRequest request;
            StringBuilder uri;
            string url = "https://localhost:44318/api/events/getFriendlyEvents"; // change link accordly

            uri = new StringBuilder();
            uri.Append(url);
            #endregion

            // RequestPreparation
            request = WebRequest.Create(uri.ToString()) as HttpWebRequest;

            #region RequestSend
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)     //via GET
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }


                // Storage of requested Json
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string content = reader.ReadToEnd();

                // Deserialization of received Json
                //events = JsonConvert.DeserializeObject<List<Event>>(content);
                return events;
            }
            #endregion
        }



        /// <summary>
        /// Requests service to create an event
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
            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");   //Header

            // Wait result
            HttpResponseMessage response = client.PostAsync("createEvent", stringContent).Result;  //Post

            Session.Token = response.Content.ReadAsStringAsync().Result;

            // Check if it's returned 200
            if (response.IsSuccessStatusCode) return true;

            return false;
        }



    }
}