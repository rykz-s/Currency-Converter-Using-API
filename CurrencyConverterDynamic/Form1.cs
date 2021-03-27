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
using Newtonsoft.Json;

namespace CurrencyConverterDynamic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double getRate(string fromCurrency, string toCurrency)
        {
            var json = "";
            string rate = "";
            try
            {
                string url = string.Format("https://free.currconv.com/api/v7/convert?q={0}_{1}&compact=ultra&apiKey=0c68165c1e1edd98f429", fromCurrency.ToUpper(), toCurrency.ToUpper());
                string key = string.Format("{0}_{1}", fromCurrency.ToUpper(), toCurrency.ToUpper());

                json = new WebClient().DownloadString(url);
                dynamic stuff = JsonConvert.DeserializeObject(json);
                rate = stuff[key];
            }
            catch
            {
                rate = "0";
            }

            return double.Parse(rate);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (usdRadioButton.Checked == true)
            {
                //radioButtonLabel.Text = "Choose One!";
                //radioButtonLabel.ForeColor = Color.Black;

                if (string.IsNullOrEmpty(inputBox.Text))
                {
                    inputBoxLabel.Text = "Insert number in IDR!";
                    inputBoxLabel.ForeColor = Color.Red;
                }
                else
                {
                    inputBoxLabel.Text = "IDR";
                    inputBoxLabel.ForeColor = Color.Black;

                    double rate = getRate(inputBoxLabel.Text, usdRadioButton.Text);
                    double coba = double.Parse(inputBox.Text);
                    double output = rate*coba;

                    resultBox.Text = output.ToString();
                    //resultBoxLabel.Text = usdRadioButton.Text;
                }
            }

            else if (jpyRadioButton.Checked == true)
            {
                //radioButtonLabel.Text = "Choose One!";
                //radioButtonLabel.ForeColor = Color.Black;

                if (string.IsNullOrEmpty(inputBox.Text))
                {
                    inputBoxLabel.Text = "Insert number in IDR!";
                    inputBoxLabel.ForeColor = Color.Red;
                }
                else
                {
                    inputBoxLabel.Text = "IDR";
                    inputBoxLabel.ForeColor = Color.Black;

                    double rate = getRate(inputBoxLabel.Text, jpyRadioButton.Text);
                    double output = double.Parse(inputBox.Text) * rate;

                    resultBox.Text = output.ToString();
                  //  resultBoxLabel.Text = jpyRadioButton.Text;
                }
            }
            else if (eurRadioButton.Checked == true)
            {
                //radioButtonLabel.Text = "Choose One!";
                //radioButtonLabel.ForeColor = Color.Black;

                if (string.IsNullOrEmpty(inputBox.Text))
                {
                    inputBoxLabel.Text = "Insert number in IDR!";
                    inputBoxLabel.ForeColor = Color.Red;
                }
                else
                {
                    inputBoxLabel.Text = "IDR";
                    inputBoxLabel.ForeColor = Color.Black;

                    double rate = getRate(inputBoxLabel.Text, eurRadioButton.Text);
                    double output = double.Parse(inputBox.Text) * rate;

                    resultBox.Text = output.ToString();
                  //  resultBoxLabel.Text = eurRadioButton.Text;
                }
            }

            else
            {
                //radioButtonLabel.Text = "Select one, please!";
                //radioButtonLabel.ForeColor = Color.Red;
            }

        }
    }
}
