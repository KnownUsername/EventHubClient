/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [VIEW]
 * HomeForm -> Page to Login / Register an user
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */

using System;
using System.Windows.Forms;
using static Controller.UserController;
using Model;

namespace View
{
    /// <summary>
    /// Page to Login / Register an user
    /// </summary>
    public partial class HomeForm : Form
    {       
        
        // Form constructor     
        public HomeForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// [ButtonClick] Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_button_Click(object sender, EventArgs e)
        {
            Session.CurrentUser.Email = emailLog_textBox.Text.ToString();
            Session.CurrentUser.Password = passwordLog_textBox.Text.ToString();

            // Send info to service
            bool responseStatus = Login(Session.CurrentUser);

            // Check sucess of login
            if (responseStatus) MessageBox.Show("Login Sucessful!");
            else MessageBox.Show("Invalid login!");

        }

        /// <summary>
        /// [ButtonClick] Regist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void join_button_Click(object sender, EventArgs e)
        {
            // Store inputed information 
            Session.CurrentUser.Name = name_textBox.Text.ToString();
            Session.CurrentUser.Email = emailReg_textBox.Text.ToString();
            Session.CurrentUser.Password = passwordReg_textBox.Text.ToString();

            // Send info to service 

            bool responseStatus = Regist(Session.CurrentUser);

            // Check sucess of login
            if (responseStatus) MessageBox.Show("Registered Sucessful! : |)");
            else MessageBox.Show("Invalid regist! =( ");

        }

    }

}
