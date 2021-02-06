using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Formatting;
//using Newtonsoft.Json;
using Model;
using static Controller.UserController;

namespace View
{

    public partial class HomeForm : Form
    {          
             
        public HomeForm()
        {
            InitializeComponent();
        }

        private async void login_button_Click(object sender, EventArgs e)
        {
            Session.CurrentUser.Email = emailLog_textBox.Text.ToString();
            Session.CurrentUser.Password = passwordLog_textBox.Text.ToString();

            // Send info to service
            bool responseStatus = await Login(Session.CurrentUser);
            if (responseStatus) MessageBox.Show("Login Sucessful!");
            else MessageBox.Show("Invalid login!");

        }

        private void join_button_Click(object sender, EventArgs e)
        {
            Session.CurrentUser.Name = name_textBox.Text.ToString();
            Session.CurrentUser.Email = emailReg_textBox.Text.ToString();
            Session.CurrentUser.Password = passwordReg_textBox.Text.ToString();

            // Send info to service 
            
        }



    }

}
