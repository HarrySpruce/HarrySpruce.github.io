﻿namespace Trade_Entry_Application
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedFreqTableLabel = new System.Windows.Forms.Label();
            this.floatingFreqTableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.progressBar.Location = new System.Drawing.Point(1, 465);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(470, 20);
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
            this.Result.Location = new System.Drawing.Point(12, 87);
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
            this.resultBox.Location = new System.Drawing.Point(12, 103);
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
            this.fixedLegFreq.Location = new System.Drawing.Point(12, 142);
            this.fixedLegFreq.Name = "fixedLegFreq";
            this.fixedLegFreq.Size = new System.Drawing.Size(100, 20);
            this.fixedLegFreq.TabIndex = 13;
            this.fixedLegFreq.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fixed Leg Frequency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Floating Leg Frequency";
            // 
            // floatingLegFreq
            // 
            this.floatingLegFreq.Location = new System.Drawing.Point(12, 181);
            this.floatingLegFreq.Name = "floatingLegFreq";
            this.floatingLegFreq.Size = new System.Drawing.Size(100, 20);
            this.floatingLegFreq.TabIndex = 15;
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
            this.comboBox2.Location = new System.Drawing.Point(118, 141);
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
            this.comboBox3.Location = new System.Drawing.Point(118, 179);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(53, 21);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // tradeLengthLabel
            // 
            this.tradeLengthLabel.AutoSize = true;
            this.tradeLengthLabel.Location = new System.Drawing.Point(9, 204);
            this.tradeLengthLabel.Name = "tradeLengthLabel";
            this.tradeLengthLabel.Size = new System.Drawing.Size(115, 13);
            this.tradeLengthLabel.TabIndex = 19;
            this.tradeLengthLabel.Text = "Trade Length - Months";
            // 
            // tradeLength
            // 
            this.tradeLength.Location = new System.Drawing.Point(12, 220);
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
            this.Date});
            this.paymentDates.Location = new System.Drawing.Point(123, 204);
            this.paymentDates.Name = "paymentDates";
            this.paymentDates.Size = new System.Drawing.Size(244, 106);
            this.paymentDates.TabIndex = 22;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Month";
            this.Column1.Name = "Column1";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView1.Location = new System.Drawing.Point(124, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 106);
            this.dataGridView1.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Month";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // fixedFreqTableLabel
            // 
            this.fixedFreqTableLabel.AutoSize = true;
            this.fixedFreqTableLabel.Location = new System.Drawing.Point(283, 188);
            this.fixedFreqTableLabel.Name = "fixedFreqTableLabel";
            this.fixedFreqTableLabel.Size = new System.Drawing.Size(85, 13);
            this.fixedFreqTableLabel.TabIndex = 24;
            this.fixedFreqTableLabel.Text = "Fixed Frequency";
            // 
            // floatingFreqTableLabel
            // 
            this.floatingFreqTableLabel.AutoSize = true;
            this.floatingFreqTableLabel.Location = new System.Drawing.Point(271, 313);
            this.floatingFreqTableLabel.Name = "floatingFreqTableLabel";
            this.floatingFreqTableLabel.Size = new System.Drawing.Size(97, 13);
            this.floatingFreqTableLabel.TabIndex = 25;
            this.floatingFreqTableLabel.Text = "Floating Frequency";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 486);
            this.Controls.Add(this.floatingFreqTableLabel);
            this.Controls.Add(this.fixedFreqTableLabel);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "Form";
            this.Text = "Interest Rate Trade Swap Application";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label fixedFreqTableLabel;
        private System.Windows.Forms.Label floatingFreqTableLabel;
    }
}

