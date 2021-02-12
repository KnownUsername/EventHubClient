/*
 * Authors: João Rodrigues and Daniel Leonard
 * Project: Practical Work, implementing services
 * Current Solution: Client of services for sport events
 * 
 * [VIEW]
 * EventsForm -> Shows event's location, on GoogleMaps
 * 
 * Subject: Integration of Informatic Systems
 * Degree: Graduation on Engineering of Informatic Systems
 * Lective Year: 2020/21
 */

using Model;
using System.Net;
using System.Windows.Forms;
using static Controller.EventController;

namespace View
{
    /// <summary>
    /// Shows event's location, on GoogleMaps
    /// </summary>
    public partial class LocationForm : Form
    {
        // Form constructor
        public LocationForm(string eventName, string eventLocal)
        {
            InitializeComponent();
            maps_webBrowser.ScriptErrorsSuppressed = true; // takes out script errors' pop ups

            // Assign of event name on form
            eventName_label.Text = eventName;

            Location localLocation = new Location();
            localLocation = GetCoordinates(eventLocal); // assign of event's coordenates
            LoadBrowserPage(localLocation); // Open maps on web browser

        }

        /// <summary>
        /// Loads Maps on event's location
        /// </summary>
        /// <param name="location"></param>
        private void LoadBrowserPage(Location location)
        {
            //          URL Search's Header
            string queryAddress = "http://maps.google.com/maps?q=";

            //          Encode of fields
            string encodedLatitude = WebUtility.UrlEncode(location.Latitude.ToString());
            string encodedLongitude = WebUtility.UrlEncode(location.Longitude.ToString());

            string fullUrl = queryAddress + encodedLatitude + "+" + encodedLongitude; // junction of base url with query 
            maps_webBrowser.Navigate(fullUrl); // redirects to builded url          
        }


        private void return_button_Click(object sender, System.EventArgs e)
        {
            EventsForm eventsForm = new EventsForm();

            GeneralForm auxForm = new GeneralForm();
            auxForm = GetGeneralForm();

            auxForm.ChangePanelView(eventsForm);
        }

        /// <summary>
        /// Auxiliar method, to get the current GeneralForm running
        /// </summary>
        /// <returns></returns>
        public GeneralForm GetGeneralForm()
        {
            GeneralForm desiredForm = new GeneralForm();

            // Cicle through all forms open
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType().Equals(typeof(GeneralForm))) // Check if GeneralForm type
                {
                    desiredForm = (GeneralForm)openForm; // Object atribution
                    break;
                }
            }

            return desiredForm;
        }
    }
}
