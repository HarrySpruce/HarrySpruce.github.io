using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trade_Entry_Application
{
    public partial class Form : System.Windows.Forms.Form
    {
        DateTime date = DateTime.Now;
        DateTime utcDate = DateTime.UtcNow;
        DateTime Today = DateTime.Today;
        int day = (int)System.DateTime.Now.DayOfWeek;

        string dayoftheweek;
        string x;
        string currency;
        string FixedLegFreqInterval;
        string floatingLegFreqInterval;
        string currentlyusingfixed;
        string currentlyusingfloat;
        public Form()
        {
            InitializeComponent();
            notionalEntry.Text = notionalEntry.Text + "0";
            Entry.Text = Entry.Text + "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notionalEntry.Focus();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (Entry.Text == "")
            {
                Entry.Text = "0";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (rateType.Text == "Fixed Rate")
            {
                rateType.Text = "Floating Rate";
                bool flip = true;
            }
            else
            {
                rateType.Text = "Fixed Rate";
                bool flip = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (day == 1)
            {
                dayoftheweek = "Monday";
            }
            if (day == 2)
            {
                dayoftheweek = "Tuesday";
            }
            if (day == 3)
            {
                dayoftheweek = "Wednesday";
            }
            if (day == 4)
            {
                dayoftheweek = "Thursday";
            }
            if (day == 5)
            {
                dayoftheweek = "Friday";
            }
            if (day == 6)
            {
                dayoftheweek = "Saturday";
            }
            if (day == 7)
            {
                dayoftheweek = "Sunday";
            }
            string x = tradeLength.Text;
            int i = int.Parse(x);
            for (int l = 1; l <= i; l++)
            {
                decimal floatEntryInt = Convert.ToDecimal(Entry.Text);
                decimal notionalEntryDec = Convert.ToDecimal(notionalEntry.Text);
                decimal output = notionalEntryDec * floatEntryInt;
                string outputstr = Convert.ToString(output).ToString();
                resultBox.Text = output.ToString();
                this.timer1.Start();
                if (notionalEntry.Text == "")
                {
                    Console.WriteLine("Enter Something");
                }
                string newdate = date.ToString();
                DataGridViewRow row = (DataGridViewRow)paymentDates.Rows[0].Clone();
                row.Cells[0].Value = dayoftheweek;
                row.Cells[1].Value = dayoftheweek;
                day = day + 1;
                paymentDates.Rows.Add(row);
                this.timer1.Stop();
            }
        }


        private void notionalEntry_TextChanged(object sender, EventArgs e)
        {
            /*
            decimal notionalEntryDec = Convert.ToDecimal(notionalEntry.Text);
            if (notionalEntry.Text.EndsWith("m")) {
                decimal outputasdecimal = notionalEntryDec * 1000000;
                string output = Convert.ToString(outputasdecimal);
                notionalEntry.Text = output;
            }*/
            if (notionalEntry.Text == "")
            {
                notionalEntry.Text = "0";
                notionalEntry.SelectionLength = notionalEntry.Text.Length;
                Entry.SelectionLength = Entry.Text.Length;
            }
        }

        private void notionalEntry_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void notionalEntry_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void notionalEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar);
            if (e.KeyChar == 'm')
            {
                e.Handled = true;
                double d = double.Parse(notionalEntry.Text);
                d = d * 10000000.0;
                notionalEntry.Text = d.ToString();
                Console.WriteLine(d);
                notionalEntry.SelectionStart = notionalEntry.Text.Length;
            }
            if (e.KeyChar == 'k')
            {
                e.Handled = true;
                double d = double.Parse(notionalEntry.Text);
                d = d * 1000.0;
                notionalEntry.Text = d.ToString();
                Console.WriteLine(d);
                notionalEntry.SelectionStart = notionalEntry.Text.Length;
            }
            Console.WriteLine("{0}", (int)e.KeyChar);
            int asciivalue = (int)e.KeyChar;
            if ((asciivalue < 48 || asciivalue > 57) && asciivalue != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar.Increment(90);
            notionalEntry.SelectionLength = notionalEntry.Text.Length;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "GBP")
            {
                currency = "GBP";
            }
            else if (comboBox1.Text == "USD")
            {
                currency = "USD";
            }
            else if (comboBox1.Text == "CAD")
            {
                currency = "CAD";
            }
            else if (comboBox1.Text == "EUR")
            {
                currency = "EUR";
            }
            else if (comboBox1.Text == "YEN")
            {
                currency = "YEN";
            }
            else if (comboBox1.Text == "RUB")
            {
                currency = "RUB";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Months")
            {
                currentlyusingfixed = "Months";
                FixedLegFreqInterval = "Months";
            }
            if (comboBox2.Text == "Days")
            {
                currentlyusingfloat = "Days";
                FixedLegFreqInterval = "Days";
            }
            if (comboBox2.Text == "Weeks")
            {
                currentlyusingfloat = "Weeks";
                FixedLegFreqInterval = "Weeks";
            }
            if (comboBox2.Text == "Years")
            {
                currentlyusingfloat = "Years";
                FixedLegFreqInterval = "Years";
            }
            fixedLegFreq.Text = fixedLegFreq.Text + " " + FixedLegFreqInterval;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Months")
            {
                currentlyusingfixed = "Months";
                floatingLegFreqInterval = "Months";
            }
            if (comboBox3.Text == "Days")
            {
                floatingLegFreqInterval = "Days";
                currentlyusingfixed = "Days";
            }
            if (comboBox3.Text == "Weeks")
            {
                floatingLegFreqInterval = "Weeks";
                currentlyusingfixed = "Weeks";
            }
            if (comboBox3.Text == "Years")
            {
                floatingLegFreqInterval = "Years";
                currentlyusingfixed = "Years";
            }
            floatingLegFreq.Text = floatingLegFreq.Text + " " + floatingLegFreqInterval;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Add variables that specify the fixedLegFreq
            //Text Replacement for intervals.
            if (fixedLegFreq.Text.EndsWith("d"))
            {
                FixedLegFreqInterval = "Days";
                fixedLegFreq.Text = fixedLegFreq.Text + " " + FixedLegFreqInterval;
                currentlyusingfixed = "Days";
            }
            if (fixedLegFreq.Text.EndsWith("m"))
            {
                FixedLegFreqInterval = "Months";
                fixedLegFreq.Text = fixedLegFreq.Text + " " + FixedLegFreqInterval;
                currentlyusingfixed = "Months";
            }
            if (fixedLegFreq.Text.EndsWith("y"))
            {
                FixedLegFreqInterval = "Years";
                fixedLegFreq.Text = fixedLegFreq.Text + " " + FixedLegFreqInterval;
                currentlyusingfixed = "Years";
            }
            //Removes the m typed before it changes
            if (currentlyusingfixed == "Months")
            {
                fixedLegFreq.Text = fixedLegFreq.Text.Replace("m", "");
                currentlyusingfixed = "Nothing";
            }
            if (currentlyusingfixed == "Days")
            {
                fixedLegFreq.Text = fixedLegFreq.Text.Replace("d", "");
                currentlyusingfixed = "Nothing";
            }
            if (currentlyusingfixed == "Years")
            {
                fixedLegFreq.Text = fixedLegFreq.Text.Replace("y", "");
                currentlyusingfixed = "Nothing";
            }
            else
            {
                currentlyusingfixed = "Nothing";
            }
        }

        private void floatingLegFreq_TextChanged(object sender, EventArgs e)
        {
            if (floatingLegFreq.Text.EndsWith("d"))
            {
                currentlyusingfloat = "Days";
                floatingLegFreqInterval = "Days";
                floatingLegFreq.Text = floatingLegFreq.Text + " " + floatingLegFreqInterval;
            }
            if (floatingLegFreq.Text.EndsWith("m"))
            {
                currentlyusingfloat = "Months";
                floatingLegFreqInterval = "Months";
                floatingLegFreq.Text = floatingLegFreq.Text + " " + floatingLegFreqInterval;
            }
            if (floatingLegFreq.Text.EndsWith("y"))
            {
                currentlyusingfloat = "Years";
                floatingLegFreqInterval = "Years";
                floatingLegFreq.Text = floatingLegFreq.Text + " " + floatingLegFreqInterval;
            }
            //currently using actions
            if (currentlyusingfloat == "Months")
            {
                floatingLegFreq.Text = floatingLegFreq.Text.Replace("m", "");
                currentlyusingfloat = "nothing";
            }
            if (currentlyusingfloat == "Days")
            {
                floatingLegFreq.Text = floatingLegFreq.Text.Replace("d", "");
                currentlyusingfloat = "nothing";
            }
            if (currentlyusingfloat == "Years")
            {
                floatingLegFreq.Text = floatingLegFreq.Text.Replace("y", "");
                currentlyusingfloat = "nothing";
            }
            else
            {
                currentlyusingfloat = "Nothing";
            }
        }
    }
}
