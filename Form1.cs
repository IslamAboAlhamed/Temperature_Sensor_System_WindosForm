using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static DelegateAndEventForm.Form1;

namespace DelegateAndEventForm
{
    public partial class Form1 : Form
    {
        public class TemperatureChangedEventArgs : EventArgs
        {
            public double OldTemperature { get; }
            public double NewTemperature { get; }
            public double Diffrence { get; }

            public TemperatureChangedEventArgs(double OldTemperature, double NewTemperature)
            {
                this.OldTemperature = OldTemperature;
                this.NewTemperature = NewTemperature;
                this.Diffrence = NewTemperature - OldTemperature;
            }

        }
        public class Thermostat
        {

            public event EventHandler<TemperatureChangedEventArgs> ThermostatChanged;

            private double OldTemperature;
            private double CurrentTemperature;

            public void SetTemperature(double NewTemperature)
            {

                if (CurrentTemperature != NewTemperature)
                {
                    OldTemperature = CurrentTemperature;
                    CurrentTemperature = NewTemperature;
                    onTemperatureChange(OldTemperature, NewTemperature);
                }

            }

            private void onTemperatureChange(double OldTemperature, double NewTemperature)
            {
                OnTemperatureChange(new TemperatureChangedEventArgs(OldTemperature, NewTemperature));
            }

            protected virtual void OnTemperatureChange(TemperatureChangedEventArgs e)
            {
                ThermostatChanged?.Invoke(this, e);
            }
        }

        public Thermostat thermostat1  = new Thermostat();
        int NumberTemperature = 0;

        public Form1()
        {
            InitializeComponent();
            thermostat1.ThermostatChanged += HandelTemperatureChange;

        }

  
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            thermostat1.SetTemperature(Convert.ToInt32( guna2TextBox1.Text));
            NumberTemperature = Convert.ToInt32(guna2TextBox1.Text);
        }
        private void HandelTemperatureChange(
                                    object sender,
                    TemperatureChangedEventArgs e)
        {
            string message =
                $"Old Temperature: {e.OldTemperature}°C | " +
                $"New Temperature: {e.NewTemperature}°C | " +
                $"Difference: {e.Diffrence}°C";

            guna2RadialGauge1.Value = Convert.ToInt32(e.NewTemperature);

            label3.Text = $"{e.NewTemperature}C°";
            if (guna2RadialGauge1.Value > 0 && guna2RadialGauge1.Value < 39)
            {
                label3.ForeColor = Color.Green;
                guna2RadialGauge1.ProgressColor = Color.Green;
                guna2RadialGauge1.ProgressColor2 = Color.LawnGreen;
            }

            if (guna2RadialGauge1.Value > 40)
            {
                label3.ForeColor = Color.Gold;
                guna2RadialGauge1.ProgressColor = Color.Yellow;
            }

            if (guna2RadialGauge1.Value > 70)
            {
                label3.ForeColor = Color.DarkRed;
                guna2RadialGauge1.ProgressColor = Color.Red;
                guna2RadialGauge1.ProgressColor2 = Color.DarkRed;
            }

            listBox1.Items.Insert(0, message);
            NumberTemperature =Convert.ToInt32( e.NewTemperature);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            NumberTemperature++;
            thermostat1.SetTemperature(NumberTemperature);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (NumberTemperature != 0)
            {
                NumberTemperature--;
                thermostat1.SetTemperature(NumberTemperature);
            }

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label3.Text = "0C°";
            NumberTemperature = 0;
            guna2RadialGauge1.Value = 0;
        }
    }
}
