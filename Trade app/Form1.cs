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
        int ID;
        string Security;

        int dayNum = 0;
        string currency;

        public Form()
        {
            InitializeComponent();
            notionalEntry.Text = notionalEntry.Text + "0";
            fixedRateTB.Text = fixedRateTB.Text + "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notionalEntry.Focus();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (fixedRateTB.Text == "")
            {
                fixedRateTB.Text = "0";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (fixedOrFloat.Text == "Fixed Rate")
            {
                fixedOrFloat.Text = "Floating Rate";
            }
            else
            {
                fixedOrFloat.Text = "Fixed Rate";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            paymentDates.Rows.Clear();
            paymentDates.Refresh();
            paymentDates2.Rows.Clear();
            paymentDates2.Refresh();

            //decimal test = Decimal.Parse(notionalEntry.Text) / 100 * Decimal.Parse(fixedRateTB.Text) * Decimal.Parse(fixedNumberOfPayments);


            int fixedFreq = int.Parse(fixedLegFreq.Text);
            int floatFreq = int.Parse(floatingLegFreq.Text);

            int fixedNumberOfPayments = (int.Parse(tradeLength.Text) / fixedFreq);
            int floatingNumberOfPayments = (int.Parse(tradeLength.Text) / floatFreq);

            // Calculate Fixed Payment
            float fixedPayment = (float.Parse(fixedRateTB.Text)/ 100 * float.Parse(notionalEntry.Text)) / 12 * float.Parse(fixedLegFreq.Text);

            DateTime fixedPaymentDate = DateTime.Now;
            DateTime floatingPaymentDate = DateTime.Now;

            for (int l = 0; l < fixedNumberOfPayments; l++)
            {
                fixedPaymentDate = fixedPaymentDate.AddMonths(fixedFreq);
                DataGridViewRow row = (DataGridViewRow)paymentDates.Rows[0].Clone();

                if(isBusinessDay(fixedPaymentDate) == false)
                {
                    fixedPaymentDate = getNextBusinessDay(fixedPaymentDate);
                }

                row.Cells[0].Value = fixedPaymentDate.ToShortDateString();
                row.Cells[1].Value = isBusinessDay(fixedPaymentDate);
                row.Cells[2].Value = fixedPayment;
                row.Cells[3].Value = fixedPaymentDate.DayOfWeek;
                row.Cells[4].Value = currency;
                paymentDates.Rows.Add(row);
            }

            for (int d = 0; d < floatingNumberOfPayments; d++)
            {
                floatingPaymentDate = floatingPaymentDate.AddMonths(floatFreq);
                DataGridViewRow row2 = (DataGridViewRow)paymentDates2.Rows[0].Clone();

                if (isBusinessDay(floatingPaymentDate) == false)
                {
                   floatingPaymentDate = getNextBusinessDay(floatingPaymentDate);
                }
                row2.Cells[0].Value = floatingPaymentDate.ToShortDateString();
                row2.Cells[1].Value = isBusinessDay(floatingPaymentDate);
                row2.Cells[3].Value = floatingPaymentDate.DayOfWeek;
                row2.Cells[4].Value = currency;
                paymentDates2.Rows.Add(row2);
            }
        }

        private bool isBusinessDay(DateTime date)
        {
            dayNum = (int)date.DayOfWeek;

            return (dayNum >= (int)DayOfWeek.Monday && dayNum <= (int)DayOfWeek.Friday);
        }

        private DateTime getNextBusinessDay(DateTime nonBusinessDay)
        {
            if(nonBusinessDay.DayOfWeek == DayOfWeek.Saturday)
            {
                nonBusinessDay = nonBusinessDay.AddDays(2);
            }
            else if (nonBusinessDay.DayOfWeek == DayOfWeek.Sunday)
            {
                nonBusinessDay = nonBusinessDay.AddDays(1);
            }

            return nonBusinessDay;
        }

        private void notionalEntry_TextChanged(object sender, EventArgs e)
        {
            if (notionalEntry.Text == "")
            {
                notionalEntry.Text = "0";
                notionalEntry.SelectionLength = notionalEntry.Text.Length;
                fixedRateTB.SelectionLength = fixedRateTB.Text.Length;
            }
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
            if (e.KeyChar == 'b')
            {
                e.Handled = true;
                double d = double.Parse(notionalEntry.Text);
                d = d * 1000000000;
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            floatingLegFreq.Text = floatingLegFreq.Text;
        }
        

        private void testbutton_Click(object sender, EventArgs e)
        {
            notionalEntry.Text = "1000";
            fixedRateTB.Text = "5";
            floatingLegFreq.Text = "2";
            fixedLegFreq.Text = "4";
            tradeLength.Text = "96";
            comboBox1.Text = "GBP";
            comboBox2.Text = "LIBOR";
        }

        private void book_Click(object sender, EventArgs e)
        {
            ID++;
            DataGridViewRow row3 = (DataGridViewRow)Blotter.Rows[0].Clone();
            row3.Cells[0].Value = ID;
            row3.Cells[1].Value = DateTime.Now; 
            row3.Cells[2].Value = notionalEntry.Text;
            row3.Cells[3].Value = fixedRateTB.Text;
            row3.Cells[4].Value = fixedLegFreq.Text;
            row3.Cells[5].Value = floatingLegFreq.Text;
            row3.Cells[6].Value = tradeLength.Text;
            row3.Cells[7].Value = Security;
            Blotter.Rows.Add(row3);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            Security = comboBox2.Text;
        }

        private void Blotter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Blotter.CellDoubleClick)
            {

            }
        }
    }
}