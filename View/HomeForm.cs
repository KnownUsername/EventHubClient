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

namespace View
{
    public partial class HomeForm : Form
    {          
        
        User currentUser = new User();
        string token;
        
        public HomeForm()
        {
            InitializeComponent();
  

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            currentUser.Email = emailLog_textBox.Text.ToString();
            currentUser.Password = emailReg_textBox.Text.ToString();

            // Send info to service
            TryLogin(currentUser);

            

        }

        private void join_button_Click(object sender, EventArgs e)
        {
            currentUser.Name = name_textBox.Text.ToString();
            currentUser.Email = emailReg_textBox.Text.ToString();
            currentUser.Password = passwordReg_textBox.Text.ToString();

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

            // Associar o token ao header do objeto do tipo HttpClient
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);         

            // Converte objeto para formato Json
            string jsonString = JsonSerializer.Serialize(user);
            var stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");   //Header

            // Espera o resultado
            HttpResponseMessage response = await client.PostAsync(url, stringContent);  //Post
            //var response = client.PostAsync(url, stringContent);  //Post

            string result = response.Content.ReadAsStringAsync().Result;
            //string result = response.Result.ToString();

             //Verifica se o retorno é 200
            if (response.IsSuccessStatusCode)
            {
               MessageBox.Show("Done!");
                return true;
            }

            return false;
        }


    }
}
