/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [VIEW]
 * JoinEventForm -> Page to join an event
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */

using System;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Page to join an event
    /// </summary>
    public partial class JoinEventForm : Form
    {
        public JoinEventForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// [ButtonClick] Add member to the team
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addMember_button_Click(object sender, EventArgs e)
        {
            if (addMember_textBox.Text != null)
            {
                // Send email to service, to check if it's a registered email
            }

        }
    }
}
