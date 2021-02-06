using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
//using Newtonsoft.Json;
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
        /// Gives a list with all friendly events
        /// </summary>
        //public static List<Event> GetFriendlyEvents()
        //{
        //    List<Event> events = new List<Event>();

        //    #region URIConstruction
        //    HttpWebRequest request;
        //    StringBuilder uri;
        //    string url = "https://localhost:44318/api/events/getFriendlyEvents";

        //    uri = new StringBuilder();
        //    uri.Append(url);
        //    #endregion

        //    // RequestPreparation
        //    request = WebRequest.Create(uri.ToString()) as HttpWebRequest;

        //    #region RequestSend
        //    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)     //via GET
        //    {
        //        if (response.StatusCode != HttpStatusCode.OK)
        //        {
        //            string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
        //            throw new ApplicationException(message);
        //        }


        //        // Storage of requested Json
        //        StreamReader reader = new StreamReader(response.GetResponseStream());
        //        string content = reader.ReadToEnd();

        //        // Deserialization of received Json
        //        events = JsonConvert.DeserializeObject<List<Event>>(content);
        //        return events;
        //    }
        //    #endregion
        //}

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
        //public static async Task<bool> CreateEventRequest(Event createdEvent) // Change comments + put like "UserController"
        //{
        //    string url = "https://localhost:44318/api/events/createFriendlyEvent";
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri(url);

        //    //Definir tipo de resultado: JSON
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //    // Associar o token ao header do objeto do tipo HttpClient
        //    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Session.Token);


        //    // Converte objeto para formato Json
        //    //string jsonString = JsonSerializer.Serialize(createdEvent);
        //    string jsonString = JsonConvert.SerializeObject(createdEvent);

        //    var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");   //Header

        //    // Espera o resultado
        //    HttpResponseMessage response = client.PostAsync(url, stringContent).Result;  //Post

        //    string result = response.Content.ReadAsStringAsync().Result;

        //    // Verifica se o retorno é 200
        //    if (response.IsSuccessStatusCode) return true;

        //    return false;
        //}

        public static bool CreateEventRequest(Event createdEvent)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);

            //Definir tipo de resultado: JSON
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Converte objeto para formato Json
            string jsonString = JsonSerializer.Serialize(createdEvent);
            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");   //Header

            // Espera o resultado
            HttpResponseMessage response = client.PostAsync("users/login", stringContent).Result;  //Post

            //var response = client.PostAsync(url, stringContent);  //Post
            Session.Token = response.Content.ReadAsStringAsync().Result;

            //Verifica se o retorno é 200
            if (response.IsSuccessStatusCode) return true;

            return false;
        }



    }
}