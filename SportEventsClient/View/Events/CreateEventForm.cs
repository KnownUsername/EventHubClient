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
using static Controller.SportController;

namespace View
{
    /// <summary>
    /// Page to create an event 
    /// </summary>
    public partial class CreateEventForm : Form
    {
        #region VARIABLES
        EventType eventType;
        List<EventStatus> initialStatus;
        List<Sport> sports;
        #endregion

        /// <summary>
        /// Creates page to create an event, based on event type
        /// </summary>
        /// <param name="incomingEventType"></param>
        public CreateEventForm(EventType incomingEventType)
        {
            // Lists' initialization
            initialStatus = new List<EventStatus>();
            sports = new List<Sport>();

            eventType = incomingEventType; // attribution of event type
            InitializeComponent();

            // Enable entryFee field 's vision
            if (eventType == EventType.Competitive)
            {
                entryFee_textBox.Visible = true;
                entryFee_label.Visible = true;
            }

            /*      Initializations of components  */
            InitializeInitialEventTypes(); // for possible types of event
            InitializeSports(); // for available sports

            // Combo boxes' info fill
            eventStatus_Picker.DataSource = initialStatus; // EventType's options
            sport_Picker.DataSource = GetSportsName(); // Sports' options

        }

        /// <summary>
        /// [ButtonClick] Where is sent the request to create an event
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void confirm_button_Click(object sender, EventArgs e)
        {
            Event createdEvent = new Event();

            /*     Collection of Data     */            // Lacks control of possible inputs, influencing Parses
            createdEvent.Name = name_textBox.Text;
            createdEvent.Description = description_textBox.Text;
            createdEvent.InitialDate = initialDate_Picker.Value;
            createdEvent.EndDate = endDate_Picker.Value;
            createdEvent.Slots = Int32.Parse(slots_textBox.Text);
            createdEvent.Local = local_textBox.Text;
            createdEvent.SportId = GetSportId(sport_Picker.Text);
            createdEvent.TeamMax = Int32.Parse(teamMax_textBox.Text);
            createdEvent.UserId = Session.CurrentUser.Id;

            if (eventType == EventType.Friendly) createdEvent.EntryFee = null; // Friendly events has null value for entry fee
            else createdEvent.EntryFee = float.Parse(entryFee_textBox.Text); // Competitive events got entry fee chosen by user
            
            createdEvent.Status = (EventStatus)eventStatus_Picker.SelectedIndex;

            bool responseStatus = CreateEvent(createdEvent); // request for service, to create event
            
            // Check if request suceeded
            if (responseStatus) MessageBox.Show("Event created!");
            else MessageBox.Show("Fail on creating event! :(");
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
            sports = GetSports(); // assign possible sports values to list os sports 
        }

        #endregion

        #region INFO_PICKUP
        /// <summary>
        /// Captures all names from sports
        /// </summary>
        /// <param name="sports"></param>
        /// <returns></returns>
        private List<string> GetSportsName()
        {
            List<string> sportsNames = new List<string>();

            // Cicle through sports
            foreach (Sport sport in sports)
            {
                sportsNames.Add(sport.Name); // Add sports'name to the list
            }

            return sportsNames;
        }

        /// <summary>
        /// Gets id of a sport, giving its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private int GetSportId(string name)
        {
            // Cicle through all sports
            foreach (Sport sport in sports)
            {
                if (sport.Name == name) // find match sport's name
                {
                    return sport.Id;
                }
            }
            return -1; // case sport not found
        }

        #endregion
       
        #endregion
    }
}
