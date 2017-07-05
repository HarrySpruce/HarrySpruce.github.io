namespace Trade_Entry_Application
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Notional = new System.Windows.Forms.Label();
            this.notionalEntry = new System.Windows.Forms.TextBox();
            this.fixedRateTB = new System.Windows.Forms.TextBox();
            this.fixedOrFloat = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fixedLegFreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.floatingLegFreq = new System.Windows.Forms.TextBox();
            this.tradeLengthLabel = new System.Windows.Forms.Label();
            this.tradeLength = new System.Windows.Forms.TextBox();
            this.paymentDates = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Businessdays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myCurrencyFixed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDates2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessdays2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPayedFloat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myCurrencyFloat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedFreqTableLabel = new System.Windows.Forms.Label();
            this.floatingFreqTableLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.testbutton = new System.Windows.Forms.Button();
            this.Blotter = new System.Windows.Forms.DataGridView();
            this.tradeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlotterNotional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedRateBlotter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedLegFreqBlotter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floatingLegFreqBlotter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradeLengthBlotter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDates2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blotter)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.progressBar.Location = new System.Drawing.Point(3, 850);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1101, 28);
            this.progressBar.TabIndex = 0;
            // 
            // Notional
            // 
            this.Notional.AutoSize = true;
            this.Notional.Location = new System.Drawing.Point(24, 72);
            this.Notional.Name = "Notional";
            this.Notional.Size = new System.Drawing.Size(46, 13);
            this.Notional.TabIndex = 12;
            this.Notional.Text = "Notional";
            // 
            // notionalEntry
            // 
            this.notionalEntry.Location = new System.Drawing.Point(24, 88);
            this.notionalEntry.Name = "notionalEntry";
            this.notionalEntry.Size = new System.Drawing.Size(100, 20);
            this.notionalEntry.TabIndex = 0;
            this.notionalEntry.TextChanged += new System.EventHandler(this.notionalEntry_TextChanged);
            this.notionalEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notionalEntry_KeyPress);
            // 
            // fixedRateTB
            // 
            this.fixedRateTB.Location = new System.Drawing.Point(24, 127);
            this.fixedRateTB.Name = "fixedRateTB";
            this.fixedRateTB.Size = new System.Drawing.Size(100, 20);
            this.fixedRateTB.TabIndex = 1;
            this.fixedRateTB.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // fixedOrFloat
            // 
            this.fixedOrFloat.AutoSize = true;
            this.fixedOrFloat.Location = new System.Drawing.Point(24, 111);
            this.fixedOrFloat.Name = "fixedOrFloat";
            this.fixedOrFloat.Size = new System.Drawing.Size(58, 13);
            this.fixedOrFloat.TabIndex = 11;
            this.fixedOrFloat.Text = "Fixed Rate";
            this.fixedOrFloat.Click += new System.EventHandler(this.label5_Click);
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.Silver;
            this.calculate.Location = new System.Drawing.Point(141, 127);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(60, 21);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GBP",
            "USD",
            "CAD",
            "EUR",
            "YEN",
            "RUB"});
            this.comboBox1.Location = new System.Drawing.Point(141, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fixedLegFreq
            // 
            this.fixedLegFreq.Location = new System.Drawing.Point(27, 166);
            this.fixedLegFreq.Name = "fixedLegFreq";
            this.fixedLegFreq.Size = new System.Drawing.Size(100, 20);
            this.fixedLegFreq.TabIndex = 3;
            this.fixedLegFreq.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fixed Leg Frequency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Floating Leg Frequency";
            // 
            // floatingLegFreq
            // 
            this.floatingLegFreq.Location = new System.Drawing.Point(27, 205);
            this.floatingLegFreq.Name = "floatingLegFreq";
            this.floatingLegFreq.Size = new System.Drawing.Size(100, 20);
            this.floatingLegFreq.TabIndex = 4;
            this.floatingLegFreq.Text = "0";
            // 
            // tradeLengthLabel
            // 
            this.tradeLengthLabel.AutoSize = true;
            this.tradeLengthLabel.Location = new System.Drawing.Point(24, 228);
            this.tradeLengthLabel.Name = "tradeLengthLabel";
            this.tradeLengthLabel.Size = new System.Drawing.Size(115, 13);
            this.tradeLengthLabel.TabIndex = 19;
            this.tradeLengthLabel.Text = "Trade Length - Months";
            // 
            // tradeLength
            // 
            this.tradeLength.Location = new System.Drawing.Point(27, 244);
            this.tradeLength.Name = "tradeLength";
            this.tradeLength.Size = new System.Drawing.Size(100, 20);
            this.tradeLength.TabIndex = 5;
            this.tradeLength.Text = "0";
            // 
            // paymentDates
            // 
            this.paymentDates.BackgroundColor = System.Drawing.Color.White;
            this.paymentDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Businessdays,
            this.amountPayed,
            this.day,
            this.myCurrencyFixed});
            this.paymentDates.Location = new System.Drawing.Point(551, 270);
            this.paymentDates.Name = "paymentDates";
            this.paymentDates.Size = new System.Drawing.Size(544, 228);
            this.paymentDates.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Payment Date";
            this.Column1.Name = "Column1";
            // 
            // Businessdays
            // 
            this.Businessdays.HeaderText = "Business Days";
            this.Businessdays.Name = "Businessdays";
            // 
            // amountPayed
            // 
            this.amountPayed.HeaderText = "Amount Payed";
            this.amountPayed.Name = "amountPayed";
            // 
            // day
            // 
            this.day.HeaderText = "Day";
            this.day.Name = "day";
            // 
            // myCurrencyFixed
            // 
            this.myCurrencyFixed.HeaderText = "Currency";
            this.myCurrencyFixed.Name = "myCurrencyFixed";
            // 
            // paymentDates2
            // 
            this.paymentDates2.BackgroundColor = System.Drawing.Color.White;
            this.paymentDates2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDates2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.businessdays2,
            this.amountPayedFloat,
            this.day2,
            this.myCurrencyFloat});
            this.paymentDates2.Location = new System.Drawing.Point(3, 270);
            this.paymentDates2.Name = "paymentDates2";
            this.paymentDates2.Size = new System.Drawing.Size(551, 228);
            this.paymentDates2.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Payment Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // businessdays2
            // 
            this.businessdays2.HeaderText = "Business Days";
            this.businessdays2.Name = "businessdays2";
            // 
            // amountPayedFloat
            // 
            this.amountPayedFloat.HeaderText = "Amount Payed";
            this.amountPayedFloat.Name = "amountPayedFloat";
            // 
            // day2
            // 
            this.day2.HeaderText = "Day";
            this.day2.Name = "day2";
            // 
            // myCurrencyFloat
            // 
            this.myCurrencyFloat.HeaderText = "Currency";
            this.myCurrencyFloat.Name = "myCurrencyFloat";
            // 
            // fixedFreqTableLabel
            // 
            this.fixedFreqTableLabel.AutoSize = true;
            this.fixedFreqTableLabel.Font = new System.Drawing.Font("Impact", 11.25F);
            this.fixedFreqTableLabel.Location = new System.Drawing.Point(649, 248);
            this.fixedFreqTableLabel.Name = "fixedFreqTableLabel";
            this.fixedFreqTableLabel.Size = new System.Drawing.Size(110, 19);
            this.fixedFreqTableLabel.TabIndex = 24;
            this.fixedFreqTableLabel.Text = "Fixed Frequency";
            // 
            // floatingFreqTableLabel
            // 
            this.floatingFreqTableLabel.AutoSize = true;
            this.floatingFreqTableLabel.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floatingFreqTableLabel.Location = new System.Drawing.Point(177, 248);
            this.floatingFreqTableLabel.Name = "floatingFreqTableLabel";
            this.floatingFreqTableLabel.Size = new System.Drawing.Size(128, 19);
            this.floatingFreqTableLabel.TabIndex = 25;
            this.floatingFreqTableLabel.Text = "Floating Frequency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 26F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(286, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 43);
            this.label3.TabIndex = 27;
            this.label3.Text = "Interest Rate Swaps Trade Entry";
            // 
            // testbutton
            // 
            this.testbutton.Location = new System.Drawing.Point(141, 163);
            this.testbutton.Name = "testbutton";
            this.testbutton.Size = new System.Drawing.Size(75, 23);
            this.testbutton.TabIndex = 28;
            this.testbutton.Text = "test";
            this.testbutton.UseVisualStyleBackColor = true;
            this.testbutton.Click += new System.EventHandler(this.testbutton_Click);
            // 
            // Blotter
            // 
            this.Blotter.BackgroundColor = System.Drawing.Color.White;
            this.Blotter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Blotter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tradeID,
            this.tradeDate,
            this.BlotterNotional,
            this.fixedRateBlotter,
            this.fixedLegFreqBlotter,
            this.floatingLegFreqBlotter,
            this.tradeLengthBlotter,
            this.rateType});
            this.Blotter.Location = new System.Drawing.Point(3, 568);
            this.Blotter.Name = "Blotter";
            this.Blotter.Size = new System.Drawing.Size(845, 254);
            this.Blotter.TabIndex = 29;
            this.Blotter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Blotter_CellContentClick);
            // 
            // tradeID
            // 
            this.tradeID.HeaderText = "Trade Id";
            this.tradeID.Name = "tradeID";
            this.tradeID.ReadOnly = true;
            // 
            // tradeDate
            // 
            this.tradeDate.HeaderText = "Trade Date/Trade Time";
            this.tradeDate.Name = "tradeDate";
            // 
            // BlotterNotional
            // 
            this.BlotterNotional.HeaderText = "Notional";
            this.BlotterNotional.Name = "BlotterNotional";
            // 
            // fixedRateBlotter
            // 
            this.fixedRateBlotter.HeaderText = "Fixed Rate";
            this.fixedRateBlotter.Name = "fixedRateBlotter";
            // 
            // fixedLegFreqBlotter
            // 
            this.fixedLegFreqBlotter.HeaderText = "Fixed Leg Frequency";
            this.fixedLegFreqBlotter.Name = "fixedLegFreqBlotter";
            // 
            // floatingLegFreqBlotter
            // 
            this.floatingLegFreqBlotter.HeaderText = "Floating Leg Frequency";
            this.floatingLegFreqBlotter.Name = "floatingLegFreqBlotter";
            // 
            // tradeLengthBlotter
            // 
            this.tradeLengthBlotter.HeaderText = "Trade Length - Months";
            this.tradeLengthBlotter.Name = "tradeLengthBlotter";
            // 
            // rateType
            // 
            this.rateType.HeaderText = "Rate Type";
            this.rateType.Name = "rateType";
            // 
            // book
            // 
            this.book.Location = new System.Drawing.Point(12, 520);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(75, 23);
            this.book.TabIndex = 30;
            this.book.Text = "BOOK";
            this.book.UseVisualStyleBackColor = true;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "LIBOR",
            "EIBOR",
            "EURIBOR",
            "HELIBOR",
            "HIBOR",
            "MIBOR(Moscow inter-bank offer rate)",
            "MIBOR(Mumbai inter-bank offer rate)",
            "OIS",
            "RIGIBOR",
            "SAIBOR",
            "SIOR",
            "SIBOR",
            "SSOR",
            "SIOR",
            "TED spread",
            "TIBOR"});
            this.comboBox2.Location = new System.Drawing.Point(141, 204);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(75, 21);
            this.comboBox2.TabIndex = 31;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1104, 872);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.book);
            this.Controls.Add(this.Blotter);
            this.Controls.Add(this.testbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.floatingFreqTableLabel);
            this.Controls.Add(this.fixedFreqTableLabel);
            this.Controls.Add(this.paymentDates2);
            this.Controls.Add(this.paymentDates);
            this.Controls.Add(this.tradeLength);
            this.Controls.Add(this.tradeLengthLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.floatingLegFreq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fixedLegFreq);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.fixedRateTB);
            this.Controls.Add(this.fixedOrFloat);
            this.Controls.Add(this.notionalEntry);
            this.Controls.Add(this.Notional);
            this.Controls.Add(this.progressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Interest Rate Trade Swap Application";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDates2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blotter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label Notional;
        private System.Windows.Forms.TextBox notionalEntry;
        private System.Windows.Forms.TextBox fixedRateTB;
        private System.Windows.Forms.Label fixedOrFloat;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox fixedLegFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox floatingLegFreq;
        private System.Windows.Forms.Label tradeLengthLabel;
        private System.Windows.Forms.TextBox tradeLength;
        private System.Windows.Forms.DataGridView paymentDates;
        private System.Windows.Forms.DataGridView paymentDates2;
        private System.Windows.Forms.Label fixedFreqTableLabel;
        private System.Windows.Forms.Label floatingFreqTableLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Businessdays;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn myCurrencyFixed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessdays2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPayedFloat;
        private System.Windows.Forms.DataGridViewTextBoxColumn day2;
        private System.Windows.Forms.DataGridViewTextBoxColumn myCurrencyFloat;
        private System.Windows.Forms.Button testbutton;
        private System.Windows.Forms.DataGridView Blotter;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlotterNotional;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedRateBlotter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedLegFreqBlotter;
        private System.Windows.Forms.DataGridViewTextBoxColumn floatingLegFreqBlotter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tradeLengthBlotter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateType;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

