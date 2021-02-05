using Entities.EntitiesService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IdentityModel.Tokens.Jwt;

namespace View
{
    public enum EventType
    {
        Friendly,
        Competitive
    }

    public partial class EventsForm : Form
    {
        EventType eventType = new EventType();
        public EventsForm()
        {
            InitializeComponent();
            
        }

        #region BUTTONS
        /// <summary>
        /// [ButtonClick] Friendly Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void friendliesButton_Click(object sender, EventArgs e)
        {
            competitivesButton.Visible = false;
            friendliesButton.Visible = false;

            eventType = EventType.Friendly;

            List<Event> friendlyEvents = new List<Event>();
            friendlyEvents = GetFriendlyEvents(); // reception of events
            EventsDataGridViewFiller(friendlyEvents); // DataGrid fill with friendly events
            
            events_dataGridView.Visible = true;
            addEvent_Label.Visible = true;
            addEvent_Button.Visible = true;

            events_dataGridView.CellClick += Events_dataGridView_CellClick;
        }

        /// <summary>
        /// [ButtonClick] Competitive Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void competitivesButton_Click(object sender, EventArgs e)
        {
            competitivesButton.Visible = false;
            friendliesButton.Visible = false;

            eventType = EventType.Competitive;

            List<Event> competitiveEvents = new List<Event>();
            competitiveEvents = GetCompetitiveEvents(); // reception of events
            EventsDataGridViewFiller(competitiveEvents); // DataGrid fill with friendly events
            events_dataGridView.Visible = true;

            /*  Add Event Section    */
            addEvent_Label.Text = "Add Competitive Event";
            addEvent_Label.Visible = true;
            addEvent_Button.Visible = true;

        }

        #endregion

        #region METHODS

        /// <summary>
        /// Gives a list with all friendly events
        /// </summary>
        /// <returns></returns>
        private List<Event> GetFriendlyEvents()
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
                return events;
            }
        }
        
        // NOTE: Try to join both GetEvents, using EventType, to switch link

        /// <summary>
        /// Gives a list with all competitive events
        /// </summary>
        /// <returns></returns>
        private List<Event> GetCompetitiveEvents()
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
                events = JsonConvert.DeserializeObject<List<Event>>(content);
                return events;
            }
        }    



        /// <summary>
        /// Redirects user to JoinEvent window, if he clicks on "Join" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Events_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == events_dataGridView.Columns["enter_event"].Index) // Check if was clicked a button on table
            {
                
                JoinEventForm joinEventForm = new JoinEventForm();
                //Events_dataGridView.Visible = false;
                GeneralForm auxForm = new GeneralForm();
                auxForm = GetGeneralForm();

                auxForm.ChangePanelView(joinEventForm); // switch to window to join an event 
                Close();

            }
        }

        /// <summary>
        /// Auxiliar method, to get the GeneralForm running
        /// </summary>
        /// <returns></returns>
        public GeneralForm GetGeneralForm()
        {
            GeneralForm desiredForm = new GeneralForm();
           foreach(Form openForm in Application.OpenForms)
            {
                if (openForm.GetType().Equals(typeof(GeneralForm)))
                {
                    desiredForm = (GeneralForm)openForm; // Object atribution
                    break;
                }
            }

            return desiredForm;
        }
        
        /// <summary>
        /// Fills EventsDataGridView, with events' list 
        /// </summary>
        /// <param name="events"></param>
        private void EventsDataGridViewFiller(List<Event> events)
        {

            events_dataGridView.DataSource = events; // Fill DataGrid with events

            // Add button to join an event
            DataGridViewButtonColumn joinEventButtonColumn = new DataGridViewButtonColumn();
            joinEventButtonColumn.Name = "enter_event";
            joinEventButtonColumn.Text = "Join";
            joinEventButtonColumn.UseColumnTextForButtonValue = true; // so buttons' name shows

            events_dataGridView.RowHeadersVisible = false; // Remove of default blank column

            if (events_dataGridView.Columns["enter_event"] == null) // Check if column already exists
            {
                events_dataGridView.Columns.Insert(0, joinEventButtonColumn); // Introduction of join button to table
            }

        }

        #endregion

        #endregion

        #endregion

        private void addEvent_Button_Click(object sender, EventArgs e)
        {
            GeneralForm auxForm = new GeneralForm();
            auxForm = GetGeneralForm();
            CreateEventForm createEventForm = new CreateEventForm(eventType);

            auxForm.ChangePanelView(createEventForm);
        }
    }
}
