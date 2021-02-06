using Newtonsoft.Json;
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
using Model;

namespace View
{
    public partial class TeamsForm : Form
    {
        Dictionary<int, Event> userTeams;
        public TeamsForm()
        {
            InitializeComponent();
            userTeams = new Dictionary<int, Event>();
            
            GetTeams(); // Associates user's events into userTeams
            userTeams_dataGridView.DataSource = userTeams; // Link userTeams information into DataGridView of user's teams
        }

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
