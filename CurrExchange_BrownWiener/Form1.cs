using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CurrExchange_BrownWiener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.2;
        Random rnd = new Random();
        double init_priceUSD, init_priceEUR;
        int days = 0;

        //CONSTANTS
        Double miu = 0.874; //miu
        Double stdvt = 0.3224; //standard deviation
        Double deltaT = 0.38; // t1-t0

        Double wienerProcess()
        {
            double randnum = 1 + k * (rnd.NextDouble() - 0.5);
            double exp = Math.Exp(-(randnum * randnum) / 2);
            return exp / Math.Sqrt(2 * Math.PI);
        }

        Double calculateNewPrice(Double initprice)
        {
            var a = ((miu - stdvt * stdvt / 2) * deltaT) + (stdvt * wienerProcess());
            var exponent = Math.Exp(a);
            return initprice * exponent;
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                days = 0;
                timer1.Stop();
            }
            else
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                timer1.Start();
                init_priceUSD = (double)valueUSD.Value;
                init_priceEUR = (double)valueEUR.Value;
                chart1.Series[0].SmartLabelStyle.CalloutLineAnchorCapStyle = LineAnchorCapStyle.None;
                chart1.Series[1].SmartLabelStyle.CalloutLineAnchorCapStyle = LineAnchorCapStyle.None;
                chart1.Series[0].Points.AddXY(0, init_priceUSD);
                chart1.Series[1].Points.AddXY(0, init_priceEUR);
            }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            days++;
            init_priceUSD = init_priceUSD * (1 + k * (rnd.NextDouble() - 0.5));
            init_priceEUR = init_priceEUR * (1 + k * (rnd.NextDouble() - 0.5));

            init_priceUSD = calculateNewPrice(init_priceUSD);
            init_priceEUR = calculateNewPrice(init_priceEUR);

            chart1.Series[0].Points.AddXY(days, (Math.Round(init_priceUSD, 2)));
            chart1.Series[1].Points.AddXY(days, (Math.Round(init_priceEUR, 2)));
            lbDays.Text = days.ToString();
            lbUSD.Text = (Math.Round(init_priceUSD, 2)).ToString("C", CultureInfo.GetCultureInfo("en-US"));
            lbEUR.Text = (Math.Round(init_priceEUR, 2)).ToString() + " \u20AC";
        }

    }
}
