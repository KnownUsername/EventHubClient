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

        EventStatus initialEventStatus;
     

        public CreateEventForm()
        {

            InitializeComponent();



            //eventStatus_Picker.DataSource = Enum.GetValues(typeof(EventStatus));
            //eventStatus_Picker.DataSource = EventStatus.open + EventStatus.closed;
            //eventStatus_Picker.DataSource += EventStatus.closed;
        }

        private void eventStatusPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventStatus_Picker.DataSource = Enum.GetValues(typeof(EventStatus));
        }
    
    
    }
}
