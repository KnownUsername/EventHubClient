/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [VIEW]
 * GeneralForm -> Controls all views and vertical up bar buttons
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace View
{
    /// <summary>
    /// Controls all views and vertical up bar buttons
    /// </summary>
    public partial class GeneralForm : Form
    {
        // Form constructor
        public GeneralForm()
        {
            InitializeComponent();
            ChangePanelView(new HomeForm());
        }

        #region HEADER_OPTIONS

        /// <summary>
        /// [ButtonClick] -> Option Home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void home_Click(object sender, EventArgs e)
        {
            #region VISUAL
            ReinitializeButtonsColor(); // changes all buttons of header to white

            // Change buttons' colors (Font and background)
            homeButton.ForeColor = Color.Blue; // Font
            homeButton.BackColor = Color.LightGray; // Background
            #endregion

            // Page transaction
            HomeForm homeForm = new HomeForm();
            ChangePanelView(homeForm); // Change current showing page/view (to Home)
        }

        /// <summary>
        /// [ButtonClick] -> Option Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eventButton_Click(object sender, EventArgs e)
        {

            #region VISUAL
            ReinitializeButtonsColor(); // changes all buttons of header to white

            // Change buttons' colors (Font and background)
            eventButton.ForeColor = Color.FromArgb(176, 159, 3); // Font
            eventButton.BackColor = Color.LightGray; // Background
            #endregion

            // Page transaction
            EventsForm eventsForm = new EventsForm();
            ChangePanelView(eventsForm); // Change current showing page/view (to Event)
        }
     
        /// <summary>
        /// [ButtonClick] -> Option Teams
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void teamsButton_Click(object sender, EventArgs e)
        {
            #region VISUAL
            ReinitializeButtonsColor(); // changes all buttons of header to white

            // Change buttons' colors (Font and background)
            teamsButton.ForeColor = Color.Green; // Font
            teamsButton.BackColor = Color.LightGray; // Background
            #endregion

            // Page transaction
            TeamsForm teamsForm = new TeamsForm();
            ChangePanelView(teamsForm); // Change current showing page/view (to Teams)

        }

        /// <summary>
        /// [ButtonClick] -> Option Account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accountButton_Click(object sender, EventArgs e)
        {
            #region VISUAL
            ReinitializeButtonsColor(); // changes all buttons of header to white

            // Change buttons' colors (Font and background)
            accountButton.ForeColor = Color.IndianRed; // Font
            accountButton.BackColor = Color.LightGray; // Background
            #endregion

            // Page transaction
            AccountForm accountForm = new AccountForm();
            ChangePanelView(accountForm); // Change current showing page/view (to Account)
        }

        #endregion

        /// <summary>
        /// Assigns standard colors for header buttons.
        /// </summary>
        /// <use>
        /// It's used for when changing a page through header, in order to,
        /// then, activate color of picked page.
        /// </use>
        public void ReinitializeButtonsColor()
        {
            
            // Cicle through buttons on header
           foreach (Button button in header_groupBox.Controls.OfType<Button>())
            {
                // Change colors on button to standard
                button.ForeColor = Color.White; // Font
                button.BackColor = Color.Black; // Background
            }
        }

        /// <summary>
        /// Changes current viewing page
        /// </summary>
        /// <param name="newForm"></param>
        public void ChangePanelView(Form newForm)
        {
            
            // Cicle through all controls except the ones from header 
            foreach(Control control in underPanel.Controls)
            {
                control.Visible = false; // hide control
            }

            newForm.TopLevel = false; // unables top border 
            underPanel.Controls.Add(newForm); // add new form to manipulate it in underPanel's Panel
            newForm.Dock = DockStyle.Fill; // fill form into underPanel

            newForm.Show(); // shows form
        }

    }

}
