using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class JoinEventForm : Form
    {
        public JoinEventForm()
        {
            InitializeComponent();
        }

        private void addMember_button_Click(object sender, EventArgs e)
        {
            if (addMember_textBox.Text != null)
            {
                // Send email to service, to check if it's a registered email
            }


        }
    }
}
