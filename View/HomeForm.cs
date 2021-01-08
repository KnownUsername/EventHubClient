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
using BusinessObjects;
using Newtonsoft.Json;
using System.Net.Http;

namespace View
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();


        }

        private void home_Click(object sender, EventArgs e)
        {
            ReinitializeButtonsColor();
            homeButton.ForeColor = Color.Blue;
            homeButton.BackColor = Color.LightGray;

            
        }

        private void eventButton_Click(object sender, EventArgs e)
        {
            List<Event> events = new List<Event>();

            #region VISUAL
            ReinitializeButtonsColor();
            eventButton.ForeColor = Color.FromArgb(176, 159, 3);
            eventButton.BackColor = Color.LightGray;

            Events_dataGridView.Visible = true;
            #endregion

            #region URIConstruction
            HttpWebRequest request;
            StringBuilder uri;
            string url = "https://localhost:44318/events/getFriendlyEvents";

            uri = new StringBuilder();
            uri.Append(url);
            #endregion

            #region RequestPreparation
            request = WebRequest.Create(uri.ToString()) as HttpWebRequest;
            #endregion

            #region RequestSend

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)     //via GET
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    string message = String.Format("GET falhou. Recebido HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                MessageBox.Show("All right!");

    
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string content = reader.ReadToEnd();

                //MessageBox.Show(content);

                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Event));

                //Event myDeserializedClass = (Event)jsonSerializer.ReadObject(response.GetResponseStream());
                //Event myDeserializedClass = (Event)jsonSerializer.ReadObject(response.GetResponseStream());
                //Event myDeserializedClass = (Event)jsonSerializer.ReadObject(response.GetResponseStream());
               // Event eventTest = JsonConvert.DeserializeObject<Event>(content);
                events = JsonConvert.DeserializeObject<List<Event>>(content);
                Events_dataGridView.DataSource = events;
            }

            #endregion

        }
        private void aboutButton_Click(object sender, EventArgs e)
        {
            ReinitializeButtonsColor();
            aboutButton.ForeColor = Color.Green;
            aboutButton.BackColor = Color.LightGray;
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            ReinitializeButtonsColor();
            accountButton.ForeColor = Color.IndianRed;
            accountButton.BackColor = Color.LightGray;
        }



        public void ReinitializeButtonsColor()
        {
            
           foreach (Button button in groupBox1.Controls.OfType<Button>())
            {
                button.ForeColor = Color.White;
                button.BackColor = Color.Black;
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}
