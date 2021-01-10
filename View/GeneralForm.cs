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
using Newtonsoft.Json;
using Entities.EntitiesService;


namespace View
{
    public partial class GeneralForm : Form
    {
        //CreateEventForm createEventForm = new CreateEventForm();

        public GeneralForm()
        {
            InitializeComponent();
            ChangePanelView(new HomeForm());
        }

        private void home_Click(object sender, EventArgs e)
        {
            ReinitializeButtonsColor();
            homeButton.ForeColor = Color.Blue;
            homeButton.BackColor = Color.LightGray;

            HomeForm homeForm = new HomeForm();
            ChangePanelView(homeForm);
        }
        private void eventButton_Click(object sender, EventArgs e)
        {

            #region VISUAL
            ReinitializeButtonsColor();
            eventButton.ForeColor = Color.FromArgb(176, 159, 3);
            eventButton.BackColor = Color.LightGray;

            #endregion

            EventsForm eventsForm = new EventsForm();
            ChangePanelView(eventsForm);
        }
     
        private void teamsButton_Click(object sender, EventArgs e)
        {
            ReinitializeButtonsColor();
            teamsButton.ForeColor = Color.Green;
            teamsButton.BackColor = Color.LightGray;

        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            ReinitializeButtonsColor();
            accountButton.ForeColor = Color.IndianRed;
            accountButton.BackColor = Color.LightGray;

        }



        public void ReinitializeButtonsColor()
        {
            
           foreach (Button button in header_groupBox.Controls.OfType<Button>())
            {
                button.ForeColor = Color.White;
                button.BackColor = Color.Black;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }
        public void ChangePanelView(Form newForm)
        {
  
            foreach(Control control in underPanel.Controls)
            {
                control.Visible = false;
            }

            newForm.TopLevel = false;
            underPanel.Controls.Add(newForm);
            newForm.Dock = DockStyle.Fill;

            newForm.Show();
        }

    }

}
