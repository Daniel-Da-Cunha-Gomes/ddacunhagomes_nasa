using Newtonsoft.Json.Linq;
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

namespace WindowsFormsApp1
{
    public partial class Form1Date : Form
    {
        public Form1Date()
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
                string date = (string)data["date"];
                string explication = (string)data["explanation"];
                string imgUrl = (string)data["url"];

                Console.WriteLine("titre: " + titre);
                Console.WriteLine("Date: " + date);
                Console.WriteLine("explication: " + explication);
                Console.WriteLine("Image URL: " + imgUrl);

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
                string titre = (string)data["title"];
                string date = (string)data["date"];
                string explication = (string)data["explanation"];
                string imgUrl = (string)data["url"];

                Console.WriteLine("titre: " + titre);
                Console.WriteLine("Date: " + date);
                Console.WriteLine("explication: " + explication);
                Console.WriteLine("Image URL: " + imgUrl);

                label1.Text = explication;
            }
        }
    }
}
