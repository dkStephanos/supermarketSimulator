///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         SupermarketGUI.Designer.cs
//	Description:       The designer for the supermarket gui.
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Chris Harris, harriscr1@goldmail.etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Saturday, April 16, 2015
//	Copyright:         Chris Harris, 2015
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace SupermarketSimulator
{
    /// <summary>
    /// 
    /// </summary>
    partial class SupermarketGUI
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.OutputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.LongestQueueLabel = new System.Windows.Forms.Label();
            this.EventsProccLabel = new System.Windows.Forms.Label();
            this.ArriveLabel = new System.Windows.Forms.Label();
            this.DepartLabel = new System.Windows.Forms.Label();
            this.LongestQueueBox = new System.Windows.Forms.TextBox();
            this.EventsProccBox = new System.Windows.Forms.TextBox();
            this.ArrivalsBox = new System.Windows.Forms.TextBox();
            this.DepartureBox = new System.Windows.Forms.TextBox();
            this.NewSimBtn = new System.Windows.Forms.Button();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.Reg1List = new System.Windows.Forms.ListBox();
            this.Reg2List = new System.Windows.Forms.ListBox();
            this.Reg3List = new System.Windows.Forms.ListBox();
            this.Reg4List = new System.Windows.Forms.ListBox();
            this.Reg5List = new System.Windows.Forms.ListBox();
            this.Reg6List = new System.Windows.Forms.ListBox();
            this.Reg1lbl = new System.Windows.Forms.Label();
            this.Reg2lbl = new System.Windows.Forms.Label();
            this.Reg3lbl = new System.Windows.Forms.Label();
            this.Reg4lbl = new System.Windows.Forms.Label();
            this.Reg5lbl = new System.Windows.Forms.Label();
            this.Reg6lbl = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(551, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(229, 17);
            this.toolStripStatusLabel1.Text = "Created by Chris Harris and Koi Stephanos";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(307, 17);
            this.lblDate.Spring = true;
            this.lblDate.Text = "toolStripStatusLabel2";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 262);
            this.OutputBox.Multiline = true;
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputBox.Size = new System.Drawing.Size(527, 80);
            this.OutputBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Output";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(365, 233);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 40;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.Run_Click);
            // 
            // LongestQueueLabel
            // 
            this.LongestQueueLabel.AutoSize = true;
            this.LongestQueueLabel.Location = new System.Drawing.Point(9, 23);
            this.LongestQueueLabel.Name = "LongestQueueLabel";
            this.LongestQueueLabel.Size = new System.Drawing.Size(80, 13);
            this.LongestQueueLabel.TabIndex = 41;
            this.LongestQueueLabel.Text = "Longest Queue";
            // 
            // EventsProccLabel
            // 
            this.EventsProccLabel.AutoSize = true;
            this.EventsProccLabel.Location = new System.Drawing.Point(9, 73);
            this.EventsProccLabel.Name = "EventsProccLabel";
            this.EventsProccLabel.Size = new System.Drawing.Size(102, 13);
            this.EventsProccLabel.TabIndex = 42;
            this.EventsProccLabel.Text = "Events Proccessed ";
            // 
            // ArriveLabel
            // 
            this.ArriveLabel.AutoSize = true;
            this.ArriveLabel.Location = new System.Drawing.Point(9, 119);
            this.ArriveLabel.Name = "ArriveLabel";
            this.ArriveLabel.Size = new System.Drawing.Size(41, 13);
            this.ArriveLabel.TabIndex = 43;
            this.ArriveLabel.Text = "Arrivals";
            // 
            // DepartLabel
            // 
            this.DepartLabel.AutoSize = true;
            this.DepartLabel.Location = new System.Drawing.Point(12, 164);
            this.DepartLabel.Name = "DepartLabel";
            this.DepartLabel.Size = new System.Drawing.Size(59, 13);
            this.DepartLabel.TabIndex = 44;
            this.DepartLabel.Text = "Departures";
            // 
            // LongestQueueBox
            // 
            this.LongestQueueBox.BackColor = System.Drawing.SystemColors.Control;
            this.LongestQueueBox.Location = new System.Drawing.Point(117, 27);
            this.LongestQueueBox.Name = "LongestQueueBox";
            this.LongestQueueBox.ReadOnly = true;
            this.LongestQueueBox.Size = new System.Drawing.Size(39, 20);
            this.LongestQueueBox.TabIndex = 45;
            this.LongestQueueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EventsProccBox
            // 
            this.EventsProccBox.BackColor = System.Drawing.SystemColors.Control;
            this.EventsProccBox.Location = new System.Drawing.Point(117, 70);
            this.EventsProccBox.Name = "EventsProccBox";
            this.EventsProccBox.ReadOnly = true;
            this.EventsProccBox.Size = new System.Drawing.Size(39, 20);
            this.EventsProccBox.TabIndex = 46;
            this.EventsProccBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ArrivalsBox
            // 
            this.ArrivalsBox.BackColor = System.Drawing.SystemColors.Control;
            this.ArrivalsBox.Location = new System.Drawing.Point(117, 116);
            this.ArrivalsBox.Name = "ArrivalsBox";
            this.ArrivalsBox.ReadOnly = true;
            this.ArrivalsBox.Size = new System.Drawing.Size(39, 20);
            this.ArrivalsBox.TabIndex = 47;
            this.ArrivalsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DepartureBox
            // 
            this.DepartureBox.BackColor = System.Drawing.SystemColors.Control;
            this.DepartureBox.Location = new System.Drawing.Point(117, 161);
            this.DepartureBox.Name = "DepartureBox";
            this.DepartureBox.ReadOnly = true;
            this.DepartureBox.Size = new System.Drawing.Size(39, 20);
            this.DepartureBox.TabIndex = 48;
            this.DepartureBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NewSimBtn
            // 
            this.NewSimBtn.Location = new System.Drawing.Point(446, 233);
            this.NewSimBtn.Name = "NewSimBtn";
            this.NewSimBtn.Size = new System.Drawing.Size(91, 23);
            this.NewSimBtn.TabIndex = 49;
            this.NewSimBtn.Text = "New Simulation";
            this.NewSimBtn.UseVisualStyleBackColor = true;
            this.NewSimBtn.Click += new System.EventHandler(this.NewSimBtn_Click);
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Location = new System.Drawing.Point(15, 207);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultsLabel.TabIndex = 50;
            // 
            // Reg1List
            // 
            this.Reg1List.FormattingEnabled = true;
            this.Reg1List.Location = new System.Drawing.Point(188, 70);
            this.Reg1List.Name = "Reg1List";
            this.Reg1List.Size = new System.Drawing.Size(53, 95);
            this.Reg1List.TabIndex = 51;
            // 
            // Reg2List
            // 
            this.Reg2List.FormattingEnabled = true;
            this.Reg2List.Location = new System.Drawing.Point(247, 70);
            this.Reg2List.Name = "Reg2List";
            this.Reg2List.Size = new System.Drawing.Size(53, 95);
            this.Reg2List.TabIndex = 52;
            // 
            // Reg3List
            // 
            this.Reg3List.FormattingEnabled = true;
            this.Reg3List.Location = new System.Drawing.Point(306, 70);
            this.Reg3List.Name = "Reg3List";
            this.Reg3List.Size = new System.Drawing.Size(53, 95);
            this.Reg3List.TabIndex = 53;
            // 
            // Reg4List
            // 
            this.Reg4List.FormattingEnabled = true;
            this.Reg4List.Location = new System.Drawing.Point(365, 70);
            this.Reg4List.Name = "Reg4List";
            this.Reg4List.Size = new System.Drawing.Size(53, 95);
            this.Reg4List.TabIndex = 54;
            // 
            // Reg5List
            // 
            this.Reg5List.FormattingEnabled = true;
            this.Reg5List.Location = new System.Drawing.Point(424, 70);
            this.Reg5List.Name = "Reg5List";
            this.Reg5List.Size = new System.Drawing.Size(53, 95);
            this.Reg5List.TabIndex = 55;
            // 
            // Reg6List
            // 
            this.Reg6List.FormattingEnabled = true;
            this.Reg6List.Location = new System.Drawing.Point(483, 70);
            this.Reg6List.Name = "Reg6List";
            this.Reg6List.Size = new System.Drawing.Size(53, 95);
            this.Reg6List.TabIndex = 56;
            // 
            // Reg1lbl
            // 
            this.Reg1lbl.AutoSize = true;
            this.Reg1lbl.Location = new System.Drawing.Point(188, 33);
            this.Reg1lbl.Name = "Reg1lbl";
            this.Reg1lbl.Size = new System.Drawing.Size(55, 13);
            this.Reg1lbl.TabIndex = 57;
            this.Reg1lbl.Text = "Register 1";
            // 
            // Reg2lbl
            // 
            this.Reg2lbl.AutoSize = true;
            this.Reg2lbl.Location = new System.Drawing.Point(244, 33);
            this.Reg2lbl.Name = "Reg2lbl";
            this.Reg2lbl.Size = new System.Drawing.Size(55, 13);
            this.Reg2lbl.TabIndex = 58;
            this.Reg2lbl.Text = "Register 2";
            // 
            // Reg3lbl
            // 
            this.Reg3lbl.AutoSize = true;
            this.Reg3lbl.Location = new System.Drawing.Point(303, 33);
            this.Reg3lbl.Name = "Reg3lbl";
            this.Reg3lbl.Size = new System.Drawing.Size(55, 13);
            this.Reg3lbl.TabIndex = 59;
            this.Reg3lbl.Text = "Register 3";
            // 
            // Reg4lbl
            // 
            this.Reg4lbl.AutoSize = true;
            this.Reg4lbl.Location = new System.Drawing.Point(362, 33);
            this.Reg4lbl.Name = "Reg4lbl";
            this.Reg4lbl.Size = new System.Drawing.Size(55, 13);
            this.Reg4lbl.TabIndex = 60;
            this.Reg4lbl.Text = "Register 4";
            // 
            // Reg5lbl
            // 
            this.Reg5lbl.AutoSize = true;
            this.Reg5lbl.Location = new System.Drawing.Point(421, 33);
            this.Reg5lbl.Name = "Reg5lbl";
            this.Reg5lbl.Size = new System.Drawing.Size(55, 13);
            this.Reg5lbl.TabIndex = 61;
            this.Reg5lbl.Text = "Register 5";
            // 
            // Reg6lbl
            // 
            this.Reg6lbl.AutoSize = true;
            this.Reg6lbl.Location = new System.Drawing.Point(480, 33);
            this.Reg6lbl.Name = "Reg6lbl";
            this.Reg6lbl.Size = new System.Drawing.Size(55, 13);
            this.Reg6lbl.TabIndex = 62;
            this.Reg6lbl.Text = "Register 6";
            // 
            // SupermarketGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 376);
            this.Controls.Add(this.Reg6lbl);
            this.Controls.Add(this.Reg5lbl);
            this.Controls.Add(this.Reg4lbl);
            this.Controls.Add(this.Reg3lbl);
            this.Controls.Add(this.Reg2lbl);
            this.Controls.Add(this.Reg1lbl);
            this.Controls.Add(this.Reg6List);
            this.Controls.Add(this.Reg5List);
            this.Controls.Add(this.Reg4List);
            this.Controls.Add(this.Reg3List);
            this.Controls.Add(this.Reg2List);
            this.Controls.Add(this.Reg1List);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.NewSimBtn);
            this.Controls.Add(this.DepartureBox);
            this.Controls.Add(this.ArrivalsBox);
            this.Controls.Add(this.EventsProccBox);
            this.Controls.Add(this.LongestQueueBox);
            this.Controls.Add(this.DepartLabel);
            this.Controls.Add(this.ArriveLabel);
            this.Controls.Add(this.EventsProccLabel);
            this.Controls.Add(this.LongestQueueLabel);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SupermarketGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supermarket Simulator - Simulation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Supermarket_FormClosing);
            this.Load += new System.EventHandler(this.Simulator_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.TextBox OutputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label LongestQueueLabel;
        private System.Windows.Forms.Label EventsProccLabel;
        private System.Windows.Forms.Label ArriveLabel;
        private System.Windows.Forms.Label DepartLabel;
        private System.Windows.Forms.TextBox LongestQueueBox;
        private System.Windows.Forms.TextBox EventsProccBox;
        private System.Windows.Forms.TextBox ArrivalsBox;
        private System.Windows.Forms.TextBox DepartureBox;
        private System.Windows.Forms.Button NewSimBtn;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.ListBox Reg1List;
        private System.Windows.Forms.ListBox Reg2List;
        private System.Windows.Forms.ListBox Reg3List;
        private System.Windows.Forms.ListBox Reg4List;
        private System.Windows.Forms.ListBox Reg5List;
        private System.Windows.Forms.ListBox Reg6List;
        private System.Windows.Forms.Label Reg1lbl;
        private System.Windows.Forms.Label Reg2lbl;
        private System.Windows.Forms.Label Reg3lbl;
        private System.Windows.Forms.Label Reg4lbl;
        private System.Windows.Forms.Label Reg5lbl;
        private System.Windows.Forms.Label Reg6lbl;
    }
}