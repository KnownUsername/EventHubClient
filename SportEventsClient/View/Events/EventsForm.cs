/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [VIEW]
 * EventsForm -> Principal page of events, controls:
 *                -> Acess to a certain type of event
 *                -> View of events, based on type of event
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */


using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Controller.EventController;

namespace View
{
    /// <summary>
    /// Principal page of events
    /// </summary>
    public partial class EventsForm : Form
    {
        EventType eventType = new EventType();
        
        // Form constructor
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
            #region VISUAL
            // Hide buttons to pick event type
            competitivesButton.Visible = false;
            friendliesButton.Visible = false;
            #endregion

            eventType = EventType.Friendly; // assign event type to friendly

            List<Event> friendlyEvents = new List<Event>();
            friendlyEvents = GetEvents(eventType); // colect friendly events, from external service

            EventsDataGridViewFiller(friendlyEvents); // DataGrid fill with friendly events

            #region VISUAL
            /*       Makes needed components visible      */
            events_dataGridView.Visible = true; // table 

            /*  Add Event Section    */
            addEvent_Label.Visible = true;  // button's subtitle
            addEvent_Button.Visible = true; // button
            #endregion

            events_dataGridView.CellClick += Events_dataGridView_CellClick; // case a cell is clicked  
                                                                            // takes action when clicked Join's button
        }

        /// <summary>
        /// [ButtonClick] Competitive Events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void competitivesButton_Click(object sender, EventArgs e)
        {
            #region VISUAL
            // Hide buttons to pick event type
            competitivesButton.Visible = false;
            friendliesButton.Visible = false;
            #endregion

            eventType = EventType.Competitive;

            List<Event> competitiveEvents = new List<Event>();
            competitiveEvents = GetEvents(eventType); // reception of events
            EventsDataGridViewFiller(competitiveEvents); // DataGrid fill with competitive events

            #region VISUAL
            /*       Makes needed components visible      */
            events_dataGridView.Visible = true;

            /*  Add Event Section    */
            addEvent_Label.Text = "Add Competitive Event"; // Change label's text
            addEvent_Label.Visible = true; // button's subtitle
            addEvent_Button.Visible = true; // button
            #endregion

            // Lacks implementation to competitive
            events_dataGridView.CellClick += Events_dataGridView_CellClick; // case a cell is clicked  
                                                                            // takes action when clicked Join's button
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
        /// Auxiliar method, to get the current GeneralForm running
        /// </summary>
        /// <returns></returns>
        public GeneralForm GetGeneralForm()
        {
            GeneralForm desiredForm = new GeneralForm();

            // Cicle through all forms open
           foreach(Form openForm in Application.OpenForms)
            {
                if (openForm.GetType().Equals(typeof(GeneralForm))) // Check if GeneralForm type
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

            //              Add columns
            CreateDataGridColumn("Enter event", "Join"); // Button to join an event
            CreateDataGridColumn("Maps", "🌍");
            events_dataGridView.Columns["Maps"].DisplayIndex = events_dataGridView.Columns["Local"].DisplayIndex; // change maps' column to be near Local column
        }

        /// <summary>
        /// Creates a button to a DataGridView
        /// </summary>
        /// <param name="name"></param>
        /// <param name="buttonText"></param>
        /// <param name="columnName"></param>
        private void CreateDataGridColumn(string columnName,string buttonText)
        {
            DataGridViewButtonColumn joinEventButtonColumn = new DataGridViewButtonColumn();
            joinEventButtonColumn.Name = columnName;
            joinEventButtonColumn.Text = buttonText;
            joinEventButtonColumn.UseColumnTextForButtonValue = true; // so buttons' name shows

            events_dataGridView.RowHeadersVisible = false; // Remove of default blank column

            if (events_dataGridView.Columns[columnName] == null) // Check if column already exists
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

            // Check if was clicked "Enter event" button on table
            if (e.ColumnIndex == events_dataGridView.Columns["Enter event"].Index) 
            {
                /*      Getting event's id from row corresponding to clicked Join   */
                int row = e.RowIndex; // row's index
                DataGridViewRow currentRow = events_dataGridView.Rows[e.RowIndex]; // obtain datagridRow to achieve cell's value
                int eventID = (int)currentRow.Cells["Id"].Value; // obtain of id on desired row

                // Check if user is already registered on that event


                JoinEventForm joinEventForm = new JoinEventForm(eventID);
                
                GeneralForm auxForm = new GeneralForm();
                auxForm = GetGeneralForm();

                auxForm.ChangePanelView(joinEventForm); // switch to window to join an event 
                Close(); // Close current form
            }

            // Check if was clicked Maps' button on table
            if (e.ColumnIndex == events_dataGridView.Columns["Maps"].Index)
            {
                int row = e.RowIndex; // row's index
                DataGridViewRow currentRow = events_dataGridView.Rows[e.RowIndex]; // obtain datagridRow to achieve cell's value
                string eventLocal = currentRow.Cells["Local"].Value.ToString(); // obain local of event on button's row
                string eventName = currentRow.Cells["Name"].Value.ToString(); // obtain name of event on button's row   
              
                GeneralForm auxForm = new GeneralForm();
                auxForm = GetGeneralForm();

                auxForm.ChangePanelView(new LocationForm(eventName,eventLocal)); // switch to window to join an event 
            }
        }

        #endregion

    }
}
