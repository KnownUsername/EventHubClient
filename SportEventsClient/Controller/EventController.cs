using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
//using System.Text.Json;
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

        static string baseUrl = "https://localhost:44318/api/events/";


        #region GET_EVENTS_LISTS

        /// <summary>
        /// GET to obtain list of events, using WebClient/ Yet in test and without using EventType
        /// </summary>
        /// <returns></returns>
        public static List<Event> GetEvents_Web()
        {
            string url = baseUrl + "GetFriendlyEvents"; // full url - composed with baseUrl + specific service to use
            WebClient client = new WebClient();
            string listSerialized = client.DownloadString(url); // receives information requested, from the service

            // Lists of start and end indexes for each event
            List<int> startingIndexes = new List<int>();
            List<int> endingIndexes = new List<int>();

            int index = 0; // current index on loop / initialized as 0

            // Loop to search start and end of an Event on string listSerialized
            foreach (char c in listSerialized)
            {
                // Starter character for an Event
                if (c == '{') startingIndexes.Add(index);

                // Ending character for an Event
                if (c == '}') endingIndexes.Add(index);

                index++; // increment on index, to match current
            }
            if (startingIndexes.Count != endingIndexes.Count) return null;

            List<string> eventsAsJsonString = new List<string>();
            int numberOfEvents = startingIndexes.Count; // number of events found

            int subStringLength;
            // Create Substrings and store on eventsAsJsonString
            for (int i = 0; i < numberOfEvents; i++)
            {

                subStringLength = endingIndexes[i] - startingIndexes[i] + 1;
                // Use of stored indexes and substring add, directly to list
                eventsAsJsonString.Add(listSerialized.Substring(startingIndexes[i], subStringLength));
            }

            List<Event> events = new List<Event>();

            // Deserialize of each Event
            foreach (string eventString in eventsAsJsonString)
            {
                events.Add(JsonConvert.DeserializeObject<Event>(eventString)); // Event deserialized, added to event list
            }

            //events = JsonSerializer.Deserialize<List<Event>>(listSerialized);

            return events;
        }

        /// <summary>
        /// GET Testing to get list of events, based on eventType, using HttpClient
        /// </summary>
        /// <param name="eventType"></param>
        /// <returns></returns>
        public static List<Event> GetEvents(EventType eventType)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);

            // Define result type: JSON 
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Wait result
            //HttpResponseMessage response = client.PostAsync("createEvent", stringContent).Result;  //Post
            HttpResponseMessage response = client.GetAsync("GetFriendlyEvents").Result;

            // Check if it's returned 200
            if (response.IsSuccessStatusCode)
            {
                string listSerialized = response.Content.ReadAsStringAsync().Result;

                string listSerializedTrimmed = listSerialized.TrimStart('[');
                listSerializedTrimmed = listSerializedTrimmed.TrimEnd(']');

                List<Event> events = new List<Event>();

                events = JsonConvert.DeserializeObject<List<Event>>(listSerialized);

                return events;
            }

            return null;
        }

        /// <summary>
        /// Gives a list with all friendly events
        /// </summary>
        public static List<Event> GetFriendlyEvents()
        {
            List<Event> events = new List<Event>();

            #region URIConstruction
            HttpWebRequest request;
            StringBuilder uri;
            string url = "https://localhost:44318/api/events/getFriendlyEvents";

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
                events = JsonConvert.DeserializeObject<List<Event>>(content);
                //events = JsonSerializer.Deserialize<List<Event>>(content);
                return events;
            }
            #endregion
        }

        // NOTE: Try to join both GetEvents, using EventType, to switch link

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

        #endregion

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