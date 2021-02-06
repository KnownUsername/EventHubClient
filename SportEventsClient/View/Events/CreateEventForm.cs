/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [VIEW]
 * CreateEventForm -> Page to create an event 
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */

using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static Controller.EventController;

namespace View
{
    /// <summary>
    /// Page to create an event 
    /// </summary>
    public partial class CreateEventForm : Form
    {
        EventType eventType;
        List<EventStatus> initialStatus;
        List<Sport> sports;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="incomingEventType"></param>
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

            // Initializations of components
            InitializeInitialEventTypes();
            InitializeSports();

            // Combo boxes' info fill
            eventStatus_Picker.DataSource = initialStatus;
            sport_Picker.DataSource = GetSportsName();

        }

        /// <summary>
        /// Where is sent the request to create an event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirm_button_Click(object sender, EventArgs e)
        {
            Event createdEvent = new Event();

            /*     Data Retriev       */
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

            bool responseStatus = CreateEventRequest(createdEvent); // request for service, to create event

        }

        #region VALUES_ASSIGNMENTS

        #region INITIALIZATIONS
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
        void InitializeSports()
        {

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

            }
            #endregion
        }

        #endregion

        #region INFO_PICKUP
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
       
        #endregion
    }
}
