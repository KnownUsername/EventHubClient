/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [VIEW]
 * TeamsForm -> Page to check user's current teams
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
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Page to check user's current teams
    /// </summary>
    public partial class TeamsForm : Form
    {
        Dictionary<int, Event> userTeams; // holds team's id + corresponding event  (check this!!)
        public TeamsForm()
        {
            InitializeComponent();
            userTeams = new Dictionary<int, Event>();
            
            GetTeams(); // Associates user's events into userTeams
            userTeams_dataGridView.DataSource = userTeams; // Link userTeams information into DataGridView of user's teams
        }

        // In development !
        /// <summary>
        /// Retrieves user's events from service, and allocates on user variable
        /// </summary>
        void GetTeams()
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
                userTeams = JsonConvert.DeserializeObject<Dictionary<int,Event>>(content);
            }
            #endregion
        }

    }
}
