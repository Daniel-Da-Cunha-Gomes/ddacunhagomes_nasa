using Newtonsoft.Json.Linq;
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
using WindowsFormsApp1;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form2Date : Form
    {
        public Form2Date()
        {
            InitializeComponent();
        }

        private void Label2()
        {
            
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string apiClef = "iiagg5zZv2MSjDkyu6X4QinV2cUEaXCP0eKNy7Br";
            string url = $"https://api.nasa.gov/planetary/apod?api_key={apiClef}";

            using (WebClient client1 = new WebClient())
            {
                string json = client1.DownloadString(url);
                JObject data = JObject.Parse(json);
                string titre = (string)data["title"];
                Console.WriteLine("titre: " + titre);

                label2.Text = titre;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string apiClef = "iiagg5zZv2MSjDkyu6X4QinV2cUEaXCP0eKNy7Br";
            string url = $"https://api.nasa.gov/planetary/apod?api_key={apiClef}";

            using (WebClient client1 = new WebClient())
            {
                string json = client1.DownloadString(url);
                JObject data = JObject.Parse(json);
                string explication = (string)data["explanation"];
                Console.WriteLine("explication: " + explication);
                label1.Text = explication;
            }
        }
    }
}
