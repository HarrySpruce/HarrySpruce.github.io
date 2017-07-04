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
        int daynum = (int)System.DateTime.Now.DayOfWeek;
        int daynum2 = (int)System.DateTime.Now.DayOfWeek;

        bool Businessday;
        bool Businessday2;
        string dayoftheweek;
        string dayoftheweek2;
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
            paymentDates.Rows.Clear();
            paymentDates.Refresh();
            paymentDates2.Rows.Clear();
            paymentDates2.Refresh();
            decimal test = Decimal.Parse(Entry.Text) * Decimal.Parse(notionalEntry.Text);
            string x = Convert.ToString(test);
            int fixedFreq = int.Parse(fixedLegFreq.Text);
            int floatFreq = int.Parse(floatingLegFreq.Text);
            int fixedNumberOfPayments = (int.Parse(tradeLength.Text) / fixedFreq);
            int floatingNumberOfPayments = (int.Parse(tradeLength.Text) / floatFreq);
            DateTime fixedPaymentDate = DateTime.Now;
            DateTime floatingPaymentDate = DateTime.Now;
            daynum = fixedPaymentDate.Day;

            for (int l = 0; l < fixedNumberOfPayments; l++)
            {
                daynum++;
                daynum2++;
                if (daynum == 1)
                {
                    dayoftheweek = "Monday";
                    Businessday = true;
                }
                else if (daynum == 2)
                {
                    dayoftheweek = "Tuesday";
                    Businessday = true;
                }
                else if (daynum == 3)
                {
                    dayoftheweek = "Wednesday";
                    Businessday = true;
                }
                else if (daynum == 4)
                {
                    dayoftheweek = "Thursday";
                    Businessday = true;
                }
                else if (daynum == 5)
                {
                    dayoftheweek = "Friday";
                    Businessday = true;
                }
                else if (daynum == 6)
                {
                    dayoftheweek = "Saturday";
                    Businessday = false;
                }
                else if (daynum == 7)
                {
                    dayoftheweek = "Sunday";
                    Businessday = false;
                    daynum = 1;
                }
                else
                {
                    daynum = 0;
                    dayoftheweek = "null";
                    Businessday = false;
                    date = getNextBusinessDay(date);
                }

                Console.WriteLine("I iterated " + l + " Amount of times");
                Console.WriteLine("Test");

                fixedPaymentDate = fixedPaymentDate.AddMonths(fixedFreq);

                string newDate = date.ToString();
                DataGridViewRow row = (DataGridViewRow)paymentDates.Rows[0].Clone();

                row.Cells[0].Value = fixedPaymentDate;
                row.Cells[1].Value = Businessday;
                row.Cells[2].Value = x;
                row.Cells[3].Value = dayoftheweek;
                row.Cells[4].Value = currency;
                string currentdate = System.DateTime.Today.ToShortDateString();
                paymentDates.Rows.Add(row);
            }
            daynum2 = 1;

            for (int d = 0; d < floatingNumberOfPayments; d++)
            {
                daynum2 = daynum2 + 1;
                if (daynum2 == 1)
                {
                    dayoftheweek2 = "Monday";
                    Businessday2 = true;
                }
                else if (daynum2 == 2)
                {
                    dayoftheweek2 = "Tuesday";
                    Businessday2 = true;
                }
                else if (daynum2 == 3)
                {
                    dayoftheweek2 = "Wednesday";
                    Businessday2 = true;
                }
                else if (daynum2 == 4)
                {
                    dayoftheweek2 = "Thursday";
                    Businessday2 = true;
                }
                else if (daynum2 == 5)
                {
                    dayoftheweek2 = "Friday";
                    Businessday2 = true;
                }
                else if (daynum2 == 6)
                {
                    dayoftheweek2 = "Saturday";
                    Businessday2 = false;
                }
                else if (daynum2 == 7)
                {
                    dayoftheweek2 = "Sunday";
                    Businessday2 = false;
                    daynum2 = 1;
                }
                else
                {
                    daynum2 = 1;
                    dayoftheweek2 = "null";
                    Businessday2 = false;
                }
                DataGridViewRow row2 = (DataGridViewRow)paymentDates2.Rows[0].Clone();
                floatingPaymentDate = floatingPaymentDate.AddMonths(floatFreq);
                int floatLegFreqStringInt = int.Parse(floatingLegFreq.Text);
                row2.Cells[0].Value = floatingPaymentDate;
                row2.Cells[1].Value = Businessday2;
                row2.Cells[2].Value = dayoftheweek2;
                row2.Cells[3].Value = currency;
                paymentDates2.Rows.Add(row2);
            }
        }

        private bool isBusinessDay(DateTime date)
        {
            int dayNum = (int)System.DateTime.Now.DayOfWeek;
            
            return (dayNum >= (int)DayOfWeek.Monday && dayNum <= (int)DayOfWeek.Friday);
        }

        private DateTime getNextBusinessDay(DateTime nonBusinessDay)
        {
            return nonBusinessDay;
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
        }

        private void floatingLegFreq_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void paymentDates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}