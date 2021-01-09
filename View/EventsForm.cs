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

namespace View
{
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
        }

        #region EVENTS

        #region BUTTONS

        private void friendliesButton_Click(object sender, EventArgs e)
        {
            competitivesButton.Visible = false;
            friendliesButton.Visible = false;

            List<Event> friendlyEvents = new List<Event>();
            friendlyEvents = GetFriendlyEvents(); // reception of events
            EventDataGridViewFiller(friendlyEvents); // DataGrid fill with friendly events

            Events_dataGridView.CellClick += Events_dataGridView_CellClick;
        }

        private void competitivesButton_Click(object sender, EventArgs e)
        {
            competitivesButton.Visible = false;
            friendliesButton.Visible = false;

            List<Event> competitiveEvents = new List<Event>();
            competitiveEvents = GetCompetitiveEvents(); // reception of events
            EventDataGridViewFiller(competitiveEvents); // DataGrid fill with friendly events

        }

        #endregion

        #region METHODS
        private List<Event> GetFriendlyEvents()
        {
            List<Event> events = new List<Event>();

            #region URIConstruction
            HttpWebRequest request;
            StringBuilder uri;
            string url = "https://localhost:44318/events/getFriendlyEvents";

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

        private List<Event> GetCompetitiveEvents()
        {
            List<Event> events = new List<Event>();

            #region URIConstruction
            HttpWebRequest request;
            StringBuilder uri;
            string url = "https://localhost:44318/events/getFriendlyEvents"; // change link accordly

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
        private void Events_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Events_dataGridView.Columns["enter_event"].Index) // Check if was clicked a button on table
            {

                Events_dataGridView.Visible = false;
               // ChangePanelView(createEventForm);
            }
        }



        private void EventDataGridViewFiller(List<Event> events)
        {

            Events_dataGridView.DataSource = events; // Fill DataGrid with events

            // Add button to join an event
            DataGridViewButtonColumn joinEventButtonColumn = new DataGridViewButtonColumn();
            joinEventButtonColumn.Name = "enter_event";
            joinEventButtonColumn.Text = "Join";

            Events_dataGridView.RowHeadersVisible = false; // Remove of default blank column

            if (Events_dataGridView.Columns["enter_event"] == null) // Check if column already exists
            {
                Events_dataGridView.Columns.Insert(0, joinEventButtonColumn); // Introduction of join button to table
            }

        }

        #endregion
        #endregion
        #endregion
        #endregion

    }
}
