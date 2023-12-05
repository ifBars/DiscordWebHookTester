using System;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace DiscordWebHookTester
{
    public partial class Form1 : Form
    {
        bool useJson = false;
        string payload = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendMs(textBox1.Text, textBox2.Text);
        }

        static void SendMs(string message, string apiKey)
        {
            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/json");
            string payload = "{\"content\": \"" + message + "\"}";
            client.UploadData(apiKey, Encoding.UTF8.GetBytes(payload));
        }
    }
}