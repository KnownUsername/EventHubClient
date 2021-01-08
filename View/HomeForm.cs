using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using BusinessObjects;
using Newtonsoft.Json;
using System.Net.Http;

namespace View
{
    public partial class HomeForm : Form
    {
        CreateEventForm joinEventForm = new CreateEventForm();
        

        public HomeForm()
        {
            InitializeComponent();


        }

        private void home_Click(object sender, EventArgs e)
        {
            ReinitializeButtonsColor();
            homeButton.ForeColor = Color.Blue;
            homeButton.BackColor = Color.LightGray;
            if (Events_dataGridView.Visible) Events_dataGridView.Visible = false;
            
        }


        #region EVENTS

        #region BUTTONS
        private void eventButton_Click(object sender, EventArgs e)
        {

            #region VISUAL
            ReinitializeButtonsColor();
            eventButton.ForeColor = Color.FromArgb(176, 159, 3);
            eventButton.BackColor = Color.LightGray;

            Events_dataGridView.Visible = true;
            #endregion

            friendliesButton.Visible = true;
            competitivesButton.Visible = true;
        }

        private void friendlies_Click(object sender, EventArgs e)
        {
            competitivesButton.Visible = false;
            List<Event> events = new List<Event>();
            events = GetFriendlyEvents(); // reception of events
            EventDataGridViewFiller(events); // DataGrid fill with friendly events

            Events_dataGridView.CellClick += Events_dataGridView_CellClick;
        }

        private void competitivesButton_Click(object sender, EventArgs e)
        {

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

        private void Events_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == Events_dataGridView.Columns["enter_event"].Index) // Check if was clicked a button on table
            {

                Point startPoint = new Point(0, 16);
                joinEventForm.Location = startPoint;
                joinEventForm.Show();
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
        private void teamsButton_Click(object sender, EventArgs e)
        {
            ReinitializeButtonsColor();
            teamsButton.ForeColor = Color.Green;
            teamsButton.BackColor = Color.LightGray;
            if (Events_dataGridView.Visible) Events_dataGridView.Visible = false;


        }
    
        private void accountButton_Click(object sender, EventArgs e)
        {
            ReinitializeButtonsColor();
            accountButton.ForeColor = Color.IndianRed;
            accountButton.BackColor = Color.LightGray;
            if (Events_dataGridView.Visible) Events_dataGridView.Visible = false;

        }



        public void ReinitializeButtonsColor()
        {
            
           foreach (Button button in groupBox1.Controls.OfType<Button>())
            {
                button.ForeColor = Color.White;
                button.BackColor = Color.Black;
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

            
        }


    }
}
