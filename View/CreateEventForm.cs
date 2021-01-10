using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.EntitiesService;

namespace View
{
    public partial class CreateEventForm : Form
    {
        EventType eventType;
        List<EventStatus> initialStatus;
        public CreateEventForm(EventType incomingEventType)
        {
            initialStatus = new List<EventStatus>();

            eventType = incomingEventType;
            InitializeComponent();

            // Enable entryFee field 's vision
            if (eventType == EventType.Competitive)
            {
                entryFee_textBox.Visible = true;
                entryFee_label.Visible = true;
            }

            //eventStatus_Picker.DataSource = Enum.GetValues(typeof(EventStatus));
            eventStatus_Picker.DataSource = initialStatus;
        }

        private void eventStatusPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventStatus_Picker.DataSource = Enum.GetValues(typeof(EventStatus));
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            Event createdEvent = new Event();
            

            createdEvent.Name = name_textBox.Text;
            createdEvent.Description = description_textBox.Text;
            createdEvent.InitialDate = initialDate_Picker.Value;
            createdEvent.EndDate = endDate_Picker.Value;
            createdEvent.Slots = Int32.Parse(slots_textBox.Text);
            createdEvent.Local = local_textBox.Text;
            createdEvent.SportId = Int32.Parse(sport_textBox.Text); // Check this - need sports to show --> to pick
            createdEvent.TeamMax = Int32.Parse(teamMax_textBox.Text);

            if (eventType == EventType.Friendly) createdEvent.EntryFee = null; 
            else createdEvent.EntryFee = float.Parse(entryFee_textBox.Text);
            //createdEvent.Status =   Need to input possible values


            CreateEventRequest(createdEvent); // request for service, to create event

        }

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
            string jsonString = JsonSerializer.Serialize(createdEvent);
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

    }
}
