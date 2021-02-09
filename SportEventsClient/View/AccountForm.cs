/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [VIEW]
 * AccountForm -> Page to check and edit account informations
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */

using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Page to check and edit account informations
    /// </summary>
    public partial class AccountForm : Form
    {
        Dictionary<User, Account> userInfo;

        public AccountForm()
        {
            InitializeComponent();
            userInfo = new Dictionary<User, Account>();
            
            //GetAccountInfo(); // associates user info into dictionaty userInfo
            //SetTextBoxValues(); // displays user info on screen
        }

        /// <summary>
        /// Retrieves info from user (Account and User classes) through service
        /// </summary>
        void GetAccountInfo()
        {
            #region URIConstruction
            HttpWebRequest request;
            StringBuilder uri;
            string url = "https://localhost:44318/api/"; // add rest of link

            uri = new StringBuilder();
            uri.Append(url);
            #endregion

            // RequestPreparation
            request = WebRequest.Create(uri.ToString()) as HttpWebRequest;

            #region RequestSend
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)     //via GET
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                // Storage of requested Json
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string content = reader.ReadToEnd();

                // Deserialization of received Json
                userInfo = JsonConvert.DeserializeObject<Dictionary<User, Account>>(content);
            }
            #endregion
        }

        /// <summary>
        /// Displays user information, from userInfo, on screen
        /// </summary>
        void SetTextBoxValues()
        {
            User receivedUser = new User();
            receivedUser = userInfo.Keys.First();

            Account receivedAccount = new Account();
            receivedAccount = userInfo[receivedUser];

            /*       Information display               */

            //      User
            name_textBox.Text = receivedUser.Name;
            email_textBox.Text = receivedUser.Email;

            //      Account
            address_textBox.Text = receivedAccount.Address;
            shippingAddress_textBox.Text = receivedAccount.ShippingAddress;
            bankId_textBox.Text = receivedAccount.BankId;

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // Permits user to edit values
            foreach (TextBox textBox in ActiveForm.Controls)
            {
                textBox.ReadOnly = false;
            }

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            User editedUser = new User();
            Account editedAccount = new Account();

            editedUser.Id = Session.CurrentUser.Id;
        }
    }
}
