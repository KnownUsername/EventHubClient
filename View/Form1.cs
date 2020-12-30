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


namespace View
{
    public partial class Form1 : Form
    {
        public Form1()
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
            #region VISUAL
            ReinitializeButtonsColor();
            eventButton.ForeColor = Color.FromArgb(176,159,3);
            eventButton.BackColor = Color.LightGray;
            #endregion

            #region URIConstruction
            HttpWebRequest request;
            StringBuilder uri;
            string url = "https://localhost:44318/api/event/getFriendlyEvents";

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
                Console.WriteLine("Got it");

                //Console.WriteLine(GetPageAsString(uri.ToString()));

                //DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(ResponseOne));
                //object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                //ResponseOne jsonResponse = (ResponseOne)objResponse;// ou "as Response";

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
