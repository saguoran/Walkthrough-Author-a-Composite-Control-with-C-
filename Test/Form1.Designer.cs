﻿namespace Test
{
    partial class Form1
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
            this.ctlAlarmClock1 = new ctlClockLib.ctlAlarmClock();
            this.lblTest = new System.Windows.Forms.Label();
            this.dtpTest = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ctlAlarmClock1
            // 
            this.ctlAlarmClock1.AlarmSet = false;
            this.ctlAlarmClock1.AlarmTime = new System.DateTime(((long)(0)));
            this.ctlAlarmClock1.ClockBackColor = System.Drawing.Color.Empty;
            this.ctlAlarmClock1.ClockForeColor = System.Drawing.Color.Empty;
            this.ctlAlarmClock1.Location = new System.Drawing.Point(4, 22);
            this.ctlAlarmClock1.Name = "ctlAlarmClock1";
            this.ctlAlarmClock1.Size = new System.Drawing.Size(345, 211);
            this.ctlAlarmClock1.TabIndex = 0;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(12, 66);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(71, 13);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "(blank space)";
            // 
            // dtpTest
            // 
            this.dtpTest.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTest.Location = new System.Drawing.Point(12, 32);
            this.dtpTest.Name = "dtpTest";
            this.dtpTest.Size = new System.Drawing.Size(156, 20);
            this.dtpTest.TabIndex = 2;
            this.dtpTest.ValueChanged += new System.EventHandler(this.dtpTest_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 256);
            this.Controls.Add(this.dtpTest);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.ctlAlarmClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctlClockLib.ctlAlarmClock ctlAlarmClock1;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.DateTimePicker dtpTest;
    }
}

