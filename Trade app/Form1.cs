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

        bool Businessday;
        string dayoftheweek;
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
            decimal test = Decimal.Parse(Entry.Text) * Decimal.Parse(notionalEntry.Text);
            resultBox.Text = Convert.ToString(test);
            int fixedFreq = int.Parse(fixedLegFreq.Text);
            int floatFreq = int.Parse(floatingLegFreq.Text);
            int fixedNumberOfPayments = (int.Parse(tradeLength.Text) / fixedFreq);
            int floatingNumberOfPayments = (int.Parse(tradeLength.Text) / floatFreq);
            DateTime fixedPaymentDate = DateTime.Now;
            DateTime floatingPaymentDate = DateTime.Now;
            day = fixedPaymentDate.Day;
            if (day == 1)
            {
                dayoftheweek = "Monday";
                Businessday = true;
            }
            else if (day == 2)
            {
                dayoftheweek = "Tuesday";
                Businessday = true;
            }
            else if (day == 3)
            {
                dayoftheweek = "Wednesday";
                Businessday = true;
            }
            else if (day == 4)
            {
                dayoftheweek = "Thursday";
                Businessday = true;
            }
            else if (day == 5)
            {
                dayoftheweek = "Friday";
                Businessday = true;
            }
            else
            {
                dayoftheweek = "null";
                Businessday = false;
            }

            for (int l = 0; l < fixedNumberOfPayments; l++)
            {
                Console.WriteLine("I iterated " + l + " Amount of times");
                Console.WriteLine("Test");

                fixedPaymentDate = fixedPaymentDate.AddMonths(fixedFreq);

                string newDate = date.ToString();
                DataGridViewRow row = (DataGridViewRow)paymentDates.Rows[0].Clone();

                row.Cells[0].Value = fixedPaymentDate;
                row.Cells[1].Value = Businessday;
                row.Cells[2].Value = resultBox.Text;
                string currentdate = System.DateTime.Today.ToShortDateString();
                paymentDates.Rows.Add(row);
            }

            for (int d = 0; d < floatingNumberOfPayments; d++)
                {
                DataGridViewRow row2 = (DataGridViewRow)paymentDates2.Rows[0].Clone();
                floatingPaymentDate = floatingPaymentDate.AddMonths(floatFreq);
                int floatLegFreqStringInt = int.Parse(floatingLegFreq.Text);
                row2.Cells[0].Value = floatingPaymentDate;
                row2.Cells[1].Value = Businessday;
                row2.Cells[2].Value = resultBox.Text;
                paymentDates2.Rows.Add(row2);
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
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            floatingLegFreq.Text = floatingLegFreq.Text + " " + floatingLegFreqInterval;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Add variables that specify the fixedLegFreq
            //Text Replacement for intervals.
            if (fixedLegFreq.Text.EndsWith("M"))
            {
                int k = DateTime.DaysInMonth(System.DateTime.Now.Year, System.DateTime.Now.Month);
                Console.WriteLine(k);
            }
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void paymentDates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}