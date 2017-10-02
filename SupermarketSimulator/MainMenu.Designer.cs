///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         MainMenu.Designer.cs
//	Description:       The designer class for the Main Menu form.
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Chris Harris, harriscr1@goldmail.etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Saturday, April 16, 2015
//	Copyright:         Chris Harris, 2015
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace SupermarketSimulator
{
    partial class MainMenu
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
            this.lblCustomers = new System.Windows.Forms.Label();
            this.txtCustomers = new System.Windows.Forms.TextBox();
            this.btnStep1 = new System.Windows.Forms.Button();
            this.btnStep2 = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.btnStep3 = new System.Windows.Forms.Button();
            this.txtLanes = new System.Windows.Forms.TextBox();
            this.lblLanes = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(12, 14);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(281, 13);
            this.lblCustomers.TabIndex = 0;
            this.lblCustomers.Text = "How many customers are expected to be served in a day?";
            // 
            // txtCustomers
            // 
            this.txtCustomers.Location = new System.Drawing.Point(15, 31);
            this.txtCustomers.Name = "txtCustomers";
            this.txtCustomers.Size = new System.Drawing.Size(301, 20);
            this.txtCustomers.TabIndex = 1;
            this.txtCustomers.Text = "600";
            this.txtCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCustomers.Enter += new System.EventHandler(this.txtCustomers_Enter);
            this.txtCustomers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomers_KeyPress);
            // 
            // btnStep1
            // 
            this.btnStep1.Location = new System.Drawing.Point(338, 29);
            this.btnStep1.Name = "btnStep1";
            this.btnStep1.Size = new System.Drawing.Size(75, 23);
            this.btnStep1.TabIndex = 2;
            this.btnStep1.Text = "Next";
            this.btnStep1.UseVisualStyleBackColor = true;
            this.btnStep1.Click += new System.EventHandler(this.btnStep1_Click);
            // 
            // btnStep2
            // 
            this.btnStep2.Enabled = false;
            this.btnStep2.Location = new System.Drawing.Point(338, 79);
            this.btnStep2.Name = "btnStep2";
            this.btnStep2.Size = new System.Drawing.Size(75, 23);
            this.btnStep2.TabIndex = 5;
            this.btnStep2.Text = "Next";
            this.btnStep2.UseVisualStyleBackColor = true;
            this.btnStep2.Click += new System.EventHandler(this.btnStep2_Click);
            // 
            // txtHours
            // 
            this.txtHours.Enabled = false;
            this.txtHours.Location = new System.Drawing.Point(15, 81);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(301, 20);
            this.txtHours.TabIndex = 4;
            this.txtHours.Text = "16";
            this.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHours.Enter += new System.EventHandler(this.txtHours_Enter);
            this.txtHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHours_KeyPress);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(12, 64);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(208, 13);
            this.lblHours.TabIndex = 3;
            this.lblHours.Text = "How many hours is the supermarket open?";
            // 
            // btnStep3
            // 
            this.btnStep3.Enabled = false;
            this.btnStep3.Location = new System.Drawing.Point(338, 129);
            this.btnStep3.Name = "btnStep3";
            this.btnStep3.Size = new System.Drawing.Size(75, 23);
            this.btnStep3.TabIndex = 8;
            this.btnStep3.Text = "Next";
            this.btnStep3.UseVisualStyleBackColor = true;
            this.btnStep3.Click += new System.EventHandler(this.btnStep3_Click);
            // 
            // txtLanes
            // 
            this.txtLanes.Enabled = false;
            this.txtLanes.Location = new System.Drawing.Point(15, 131);
            this.txtLanes.Name = "txtLanes";
            this.txtLanes.Size = new System.Drawing.Size(301, 20);
            this.txtLanes.TabIndex = 7;
            this.txtLanes.Text = "4";
            this.txtLanes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLanes.Enter += new System.EventHandler(this.txtLanes_Enter);
            this.txtLanes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLanes_KeyPress);
            // 
            // lblLanes
            // 
            this.lblLanes.AutoSize = true;
            this.lblLanes.Location = new System.Drawing.Point(12, 114);
            this.lblLanes.Name = "lblLanes";
            this.lblLanes.Size = new System.Drawing.Size(154, 13);
            this.lblLanes.TabIndex = 6;
            this.lblLanes.Text = "How many lanes will be in use?";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 212);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(425, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(410, 17);
            this.lblDate.Spring = true;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(72, 174);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(222, 174);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(130, 23);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "Run Simulation";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 234);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnStep3);
            this.Controls.Add(this.txtLanes);
            this.Controls.Add(this.lblLanes);
            this.Controls.Add(this.btnStep2);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.btnStep1);
            this.Controls.Add(this.txtCustomers);
            this.Controls.Add(this.lblCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supermarket Simulator - Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.TextBox txtCustomers;
        private System.Windows.Forms.Button btnStep1;
        private System.Windows.Forms.Button btnStep2;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Button btnStep3;
        private System.Windows.Forms.TextBox txtLanes;
        private System.Windows.Forms.Label lblLanes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
    }
}

