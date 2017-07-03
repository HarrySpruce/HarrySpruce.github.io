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
            this.Result = new System.Windows.Forms.Label();
            this.Entry = new System.Windows.Forms.TextBox();
            this.rateType = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fixedLegFreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.floatingLegFreq = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tradeLengthLabel = new System.Windows.Forms.Label();
            this.tradeLength = new System.Windows.Forms.TextBox();
            this.paymentDates = new System.Windows.Forms.DataGridView();
            this.paymentDates2 = new System.Windows.Forms.DataGridView();
            this.fixedFreqTableLabel = new System.Windows.Forms.Label();
            this.floatingFreqTableLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.floatingRate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Businessdays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessdays2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPayed2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDates2)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.progressBar.Location = new System.Drawing.Point(-1, 731);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(602, 20);
            this.progressBar.TabIndex = 0;
            // 
            // Notional
            // 
            this.Notional.AutoSize = true;
            this.Notional.Location = new System.Drawing.Point(12, 9);
            this.Notional.Name = "Notional";
            this.Notional.Size = new System.Drawing.Size(46, 13);
            this.Notional.TabIndex = 1;
            this.Notional.Text = "Notional";
            // 
            // notionalEntry
            // 
            this.notionalEntry.Location = new System.Drawing.Point(12, 25);
            this.notionalEntry.Name = "notionalEntry";
            this.notionalEntry.Size = new System.Drawing.Size(100, 20);
            this.notionalEntry.TabIndex = 2;
            this.notionalEntry.TextChanged += new System.EventHandler(this.notionalEntry_TextChanged);
            this.notionalEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.notionalEntry_KeyDown);
            this.notionalEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notionalEntry_KeyPress);
            this.notionalEntry.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.notionalEntry_PreviewKeyDown);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(12, 127);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(39, 13);
            this.Result.TabIndex = 7;
            this.Result.Text = "Output";
            // 
            // Entry
            // 
            this.Entry.Location = new System.Drawing.Point(12, 64);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(100, 20);
            this.Entry.TabIndex = 10;
            this.Entry.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // rateType
            // 
            this.rateType.AutoSize = true;
            this.rateType.Location = new System.Drawing.Point(12, 48);
            this.rateType.Name = "rateType";
            this.rateType.Size = new System.Drawing.Size(58, 13);
            this.rateType.TabIndex = 9;
            this.rateType.Text = "Fixed Rate";
            this.rateType.Click += new System.EventHandler(this.label5_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(119, 64);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 11;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 143);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(100, 20);
            this.resultBox.TabIndex = 8;
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
            this.comboBox1.Location = new System.Drawing.Point(121, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fixedLegFreq
            // 
            this.fixedLegFreq.Location = new System.Drawing.Point(12, 182);
            this.fixedLegFreq.Name = "fixedLegFreq";
            this.fixedLegFreq.Size = new System.Drawing.Size(100, 20);
            this.fixedLegFreq.TabIndex = 13;
            this.fixedLegFreq.Text = "0";
            this.fixedLegFreq.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fixed Leg Frequency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Floating Leg Frequency";
            // 
            // floatingLegFreq
            // 
            this.floatingLegFreq.Location = new System.Drawing.Point(12, 221);
            this.floatingLegFreq.Name = "floatingLegFreq";
            this.floatingLegFreq.Size = new System.Drawing.Size(100, 20);
            this.floatingLegFreq.TabIndex = 15;
            this.floatingLegFreq.Text = "0";
            this.floatingLegFreq.TextChanged += new System.EventHandler(this.floatingLegFreq_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.comboBox2.Location = new System.Drawing.Point(120, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(53, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.comboBox3.Location = new System.Drawing.Point(120, 220);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(53, 21);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tradeLengthLabel
            // 
            this.tradeLengthLabel.AutoSize = true;
            this.tradeLengthLabel.Location = new System.Drawing.Point(9, 244);
            this.tradeLengthLabel.Name = "tradeLengthLabel";
            this.tradeLengthLabel.Size = new System.Drawing.Size(115, 13);
            this.tradeLengthLabel.TabIndex = 19;
            this.tradeLengthLabel.Text = "Trade Length - Months";
            // 
            // tradeLength
            // 
            this.tradeLength.Location = new System.Drawing.Point(12, 260);
            this.tradeLength.Name = "tradeLength";
            this.tradeLength.Size = new System.Drawing.Size(100, 20);
            this.tradeLength.TabIndex = 21;
            this.tradeLength.Text = "0";
            // 
            // paymentDates
            // 
            this.paymentDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Businessdays,
            this.amountPayed});
            this.paymentDates.Location = new System.Drawing.Point(119, 260);
            this.paymentDates.Name = "paymentDates";
            this.paymentDates.Size = new System.Drawing.Size(340, 219);
            this.paymentDates.TabIndex = 22;
            this.paymentDates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentDates_CellContentClick);
            // 
            // paymentDates2
            // 
            this.paymentDates2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDates2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.businessdays2,
            this.amountPayed2});
            this.paymentDates2.Location = new System.Drawing.Point(120, 498);
            this.paymentDates2.Name = "paymentDates2";
            this.paymentDates2.Size = new System.Drawing.Size(339, 228);
            this.paymentDates2.TabIndex = 23;
            // 
            // fixedFreqTableLabel
            // 
            this.fixedFreqTableLabel.AutoSize = true;
            this.fixedFreqTableLabel.Location = new System.Drawing.Point(279, 244);
            this.fixedFreqTableLabel.Name = "fixedFreqTableLabel";
            this.fixedFreqTableLabel.Size = new System.Drawing.Size(85, 13);
            this.fixedFreqTableLabel.TabIndex = 24;
            this.fixedFreqTableLabel.Text = "Fixed Frequency";
            // 
            // floatingFreqTableLabel
            // 
            this.floatingFreqTableLabel.AutoSize = true;
            this.floatingFreqTableLabel.Location = new System.Drawing.Point(267, 482);
            this.floatingFreqTableLabel.Name = "floatingFreqTableLabel";
            this.floatingFreqTableLabel.Size = new System.Drawing.Size(97, 13);
            this.floatingFreqTableLabel.TabIndex = 25;
            this.floatingFreqTableLabel.Text = "Floating Frequency";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // floatingRate
            // 
            this.floatingRate.AutoSize = true;
            this.floatingRate.Location = new System.Drawing.Point(12, 88);
            this.floatingRate.Name = "floatingRate";
            this.floatingRate.Size = new System.Drawing.Size(70, 13);
            this.floatingRate.TabIndex = 26;
            this.floatingRate.Text = "Floating Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Enter m to set Frequency to once per month";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Month";
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Month";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // businessdays2
            // 
            this.businessdays2.HeaderText = "Business Days";
            this.businessdays2.Name = "businessdays2";
            // 
            // amountPayed2
            // 
            this.amountPayed2.HeaderText = "Amount Payed";
            this.amountPayed2.Name = "amountPayed2";
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(601, 751);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.floatingRate);
            this.Controls.Add(this.floatingFreqTableLabel);
            this.Controls.Add(this.fixedFreqTableLabel);
            this.Controls.Add(this.paymentDates2);
            this.Controls.Add(this.paymentDates);
            this.Controls.Add(this.tradeLength);
            this.Controls.Add(this.tradeLengthLabel);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.floatingLegFreq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fixedLegFreq);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.Entry);
            this.Controls.Add(this.rateType);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.Result);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label Notional;
        private System.Windows.Forms.TextBox notionalEntry;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox Entry;
        private System.Windows.Forms.Label rateType;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox fixedLegFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox floatingLegFreq;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label tradeLengthLabel;
        private System.Windows.Forms.TextBox tradeLength;
        private System.Windows.Forms.DataGridView paymentDates;
        private System.Windows.Forms.DataGridView paymentDates2;
        private System.Windows.Forms.Label fixedFreqTableLabel;
        private System.Windows.Forms.Label floatingFreqTableLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label floatingRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Businessdays;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessdays2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPayed2;
    }
}

