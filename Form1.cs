using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherAPI.Models;


namespace WeatherAPI
{
    public partial class Form1 : Form
    {
        List<Weather> weather;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();

        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //TextBox Settings
            this.txtZip.MaxLength = 5;
            this.txtZip.Text = "78758";
            this.txtCity.Text = "";
            this.txtClouds.Text = "";
            this.txtFeelLike.Text = "";
            this.txthow.Text = "";
            this.txtLatitude.Text = "";
            this.txtLongitude.Text = "";
            this.txtLow.Text = "";
            this.txtTemperature.Text = "";
            this.txtWinds.Text = "";
            this.txtCity.Enabled = false;
            this.txtClouds.Enabled = false;
            this.txtFeelLike.Enabled = false;
            this.txthow.Enabled = false;
            this.txtLatitude.Enabled = false;
            this.txtLongitude.Enabled = false;
            this.txtLow.Enabled = false;
            this.txtTemperature.Enabled = false;
            this.txtWinds.Enabled = false;
        }

        /*
        private void btnStartLocation_Click(object sender, EventArgs e)
        {
            GEOService myLocation = new GEOService();
            myLocation.GetLocationEvent();
            Console.WriteLine("Enter any key to quit.");
            Console.ReadLine();
        }
        */

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            this.GetWeather(true);
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            this.GetWeather(false);
        }
        private void GetWeather(bool isXML)
        {
            string sZip = this.txtZip.Text.Trim();

            int iZip = Validation(sZip);

            if (iZip == 0)
                return;

            try
            {
               // weather = WeatherService.GetWeather(iZip, isXML);

                this.PopulateWeatherData(weather);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.SetControls();
            }
        }

        private void PopulateWeatherData(List<Weather> weather)
        {
            this.txtCity.Text = weather[0].City;
            this.txtClouds.Text = weather[0].Clouds;
            this.txtFeelLike.Text = weather[0].FeelsLike;
            this.txthow.Text = weather[0].HighTemp;
            this.txtLatitude.Text = weather[0].Latitude;
            this.txtLongitude.Text = weather[0].Longitude;
            this.txtLow.Text = weather[0].LowTemp;
            this.txtTemperature.Text = weather[0].CurrentTemperature;
            this.txtWinds.Text = weather[0].Wind;
        }

        private int Validation(string sZip)
        {
            int iZip = 0;

            bool result = int.TryParse(sZip, out iZip);

            if (!result)
            {
                MessageBox.Show("A numeric value must be entered for zip code!");
                return iZip;
            }
            else if (sZip.Length != 5)
            {
                MessageBox.Show("Zip code must be 5 numbers!");
                iZip = 0;
                return iZip;
            }

            return iZip;
        }
    }
}
