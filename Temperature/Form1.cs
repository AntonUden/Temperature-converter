using System;
using System.Windows.Forms;

namespace Temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            update();
        }


        public void update()
        {
            String type = "?°";
            if (toCelcius.Checked)
            {
                type = "°C";
                infoLabel.Text = "Temperature in °F";
            }
            else
            {
                type = "°F";
                infoLabel.Text = "Temperature in °C";
            }
            try
            {
                Double inputValue = double.Parse(input.Text);
                Double result = 0;
                if (toCelcius.Checked)
                {
                    result = 5.0 / 9.0 * (inputValue - 32);
                }
                else
                {
                    result = ((9.0 / 5.0) * inputValue) + 32;
                }
                output.Text = "Temperature: " + result + " " + type;
            }
            catch (Exception ex)
            {
                output.Text = "Temperature: ? " + type;
            }
        }

        private void toFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void toCelcius_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
