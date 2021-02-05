using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Model;

namespace View
{
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
