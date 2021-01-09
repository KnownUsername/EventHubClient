using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
