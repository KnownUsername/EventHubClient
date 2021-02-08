/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engeneer of Informatic Systems
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
            friendlyEvents = GetEvents(eventType);

            //friendlyEvents = GetFriendlyEvents(); // reception of events
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
            competitiveEvents = GetEvents(eventType); // reception of events
            EventsDataGridViewFiller(competitiveEvents); // DataGrid fill with friendly events
            events_dataGridView.Visible = true;

            /*  Add Event Section    */
            addEvent_Label.Text = "Add Competitive Event";
            addEvent_Label.Visible = true;
            addEvent_Button.Visible = true;

        }

        /// <summary>
        /// [ButtonClick] Add new Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEvent_Button_Click(object sender, EventArgs e)
        {
            GeneralForm auxForm = new GeneralForm();
            auxForm = GetGeneralForm();
            CreateEventForm createEventForm = new CreateEventForm(eventType);

            auxForm.ChangePanelView(createEventForm);
        }

        #endregion

        #region METHODS

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

        #endregion

    }
}
