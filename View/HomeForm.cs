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
using Entities.EntitiesService;
using System.IdentityModel.Tokens.Jwt;

namespace View
{

    public partial class HomeForm : Form
    {          
             
        public HomeForm()
        {
            InitializeComponent();

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Session.CurrentUser.Email = emailLog_textBox.Text.ToString();
            Session.CurrentUser.Password = emailReg_textBox.Text.ToString();

            // Send info to service
            TryLogin(Session.CurrentUser);

            

        }

        private void join_button_Click(object sender, EventArgs e)
        {
            Session.CurrentUser.Name = name_textBox.Text.ToString();
            Session.CurrentUser.Email = emailReg_textBox.Text.ToString();
            Session.CurrentUser.Password = passwordReg_textBox.Text.ToString();

            // Send info to service 
            
        }

        /// <summary>
        /// Tries to login 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private async Task<bool> TryLogin(User user)
        {
            string url = "https://localhost:44318/api/user/login";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);

            //Definir tipo de resultado: JSON
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Converte objeto para formato Json
            string jsonString = JsonSerializer.Serialize(user);
            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");   //Header

            // Espera o resultado
            HttpResponseMessage response = await client.PostAsync(url, stringContent);  //Post
            //var response = client.PostAsync(url, stringContent);  //Post

            Session.Token = response.Content.ReadAsStringAsync().Result;

            //Verifica se o retorno é 200
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Done!");
                return true;
            }

            return false;
        }

    }

    /// <summary>
    /// Current Session 
    /// </summary>
    public static class Session
    {
        static User currentUser;
        static string token;

        public static User CurrentUser
        {
            get => currentUser; set => currentUser = value;
        }
        public static string Token { get => token; set => token = value; }

    }
}
