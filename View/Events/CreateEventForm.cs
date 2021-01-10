using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.EntitiesService;
using Newtonsoft.Json;


namespace View
{
    public partial class CreateEventForm : Form
    {
        EventType eventType;
        List<EventStatus> initialStatus;
        List<Sport> sports;

        public CreateEventForm(EventType incomingEventType)
        {
            initialStatus = new List<EventStatus>();
            sports = new List<Sport>();
            eventType = incomingEventType;
            InitializeComponent();

            // Enable entryFee field 's vision
            if (eventType == EventType.Competitive)
            {
                entryFee_textBox.Visible = true;
                entryFee_label.Visible = true;
            }
            InitializeInitialEventTypes();
            sports = InitializeSports();

            eventStatus_Picker.DataSource = initialStatus;
            sport_Picker.DataSource = GetSportsName();

        }

        private void eventStatusPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventStatus_Picker.DataSource = Enum.GetValues(typeof(EventStatus));
        }

        /// <summary>
        /// Where is sent the request to create an event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirm_button_Click(object sender, EventArgs e)
        {
            Event createdEvent = new Event();

            createdEvent.Name = name_textBox.Text;
            createdEvent.Description = description_textBox.Text;
            createdEvent.InitialDate = initialDate_Picker.Value;
            createdEvent.EndDate = endDate_Picker.Value;
            createdEvent.Slots = Int32.Parse(slots_textBox.Text);
            createdEvent.Local = local_textBox.Text;
            createdEvent.SportId = GetSportId(sport_Picker.Text);

            createdEvent.TeamMax = Int32.Parse(teamMax_textBox.Text);

            if (eventType == EventType.Friendly) createdEvent.EntryFee = null;
            else createdEvent.EntryFee = float.Parse(entryFee_textBox.Text);
            createdEvent.Status = (EventStatus)eventStatus_Picker.SelectedIndex;


            CreateEventRequest(createdEvent); // request for service, to create event

        }

        /// <summary>
        /// Requests service to create an event
        /// </summary>
        /// <param name="createdEvent"></param>
        /// <returns></returns>
        async Task<bool> CreateEventRequest(Event createdEvent)
        {
            string url = "https://localhost:44318/api/events/createFriendlyEvent";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            //Definir tipo de resultado: JSON
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // Associar o token ao header do objeto do tipo HttpClient
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Session.Token);


            // Converte objeto para formato Json
            //string jsonString = JsonSerializer.Serialize(createdEvent);
            string jsonString = JsonConvert.SerializeObject(createdEvent);

            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");   //Header

            // Espera o resultado
            HttpResponseMessage response = await client.PostAsync(url, stringContent);  //Post

            string result = response.Content.ReadAsStringAsync().Result;

            // Verifica se o retorno é 200
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Done!");
                return true;
            }
            return false;
        }


        #region VALUES_ASSIGNMENTS

        /// <summary>
        /// Initializes list of initial event status.
        /// </summary>
        /// <varExplain>
        /// This list contains all possible values,
        /// for an event status have, when it's 
        /// created.
        /// </varExplain>
        void InitializeInitialEventTypes()
        {
            initialStatus.Add(EventStatus.open);
            initialStatus.Add(EventStatus.closed);
        }

        /// <summary>
        /// Initializes list of available sports
        /// </summary>
        /// <returns></returns>
        List<Sport> InitializeSports()
        {
            List<Sport> sports = new List<Sport>();

            #region URIConstruction
            HttpWebRequest request;
            StringBuilder uri;
            string url = "https://localhost:44318/api/sports/getSports"; // change link accordly

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
                sports = JsonConvert.DeserializeObject<List<Sport>>(content);

                //sports = JsonSerializer.Deserialize<List<Sport>>(content);
                return sports;
            }
            #endregion
        }

        /// <summary>
        /// Captures all names from sports
        /// </summary>
        /// <param name="sports"></param>
        /// <returns></returns>
        List<string> GetSportsName()
        {
            List<string> sportsNames = new List<string>();


            foreach (Sport sport in sports)
            {
                sportsNames.Add(sport.Name);
            }

            return sportsNames;
        }

        /// <summary>
        /// Gets id of a sport, giving its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        int GetSportId(string name)
        {
            foreach (Sport sport in sports)
            {
                if (sport.Name == name)
                {
                    return sport.Id;
                }
            }
            return -1;
        }

        #endregion
    }
}
