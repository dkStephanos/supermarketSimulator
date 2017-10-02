///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         Supermarket.cs
//	Description:       The Supermarket class
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Chris Harris, harriscr1@goldmail.etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Saturday, April 16, 2015
//	Copyright:         Chris Harris, 2015
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupermarketSimulator.Classes;
using System.Threading;

namespace SupermarketSimulator
{
    /// <summary>
    /// The form that displays our simulation.
    /// </summary>
    public partial class SupermarketGUI : Form
    {

        Supermarket market;                             //market for use in simulation
        /// <summary>
        /// Default constructor
        /// </summary>
        public SupermarketGUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Simulator_Load(object sender, EventArgs e)
        {
            //Display the current date
            lblDate.Text = DateTime.Now.ToLongDateString();

            //set the icon of the form from the resources
            this.Icon = SupermarketSimulator.Properties.Resources.supermarket;

            //creates the supermarket class and initializes fields
            market = new Supermarket(MainMenu.Customers, MainMenu.Hours, MainMenu.Lanes);
            OutputBox.Clear();
            OutputBox.Text = "Customer Events:" + Environment.NewLine;
            LongestQueueBox.Clear();
            ArrivalsBox.Clear();
            DepartureBox.Clear();
            EventsProccBox.Clear();
            AcceptButton = btnRun;
            //determines how many lanes we want open, and closes the excess lanes
            int numLanes = MainMenu.Lanes;
            while(true)
            {
                if(numLanes < 6)
                {
                    Reg6lbl.Hide();
                    Reg6List.Hide();
                }
                if(numLanes < 5)
                {
                    Reg5lbl.Hide();
                    Reg5List.Hide();
                }
                if (numLanes < 4)
                {
                    Reg4lbl.Hide();
                    Reg4List.Hide();
                }
                if (numLanes < 3)
                {
                    Reg3lbl.Hide();
                    Reg3List.Hide();
                }
                if (numLanes < 2)
                {
                    Reg2lbl.Hide();
                    Reg2List.Hide();
                }
                    break;
            }
           
        }

        /// <summary>
        /// Event handler for the form closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Supermarket_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Exit the application
            Application.Exit();
            //displays a goodbye message whenever exiting the program
            MessageBox.Show("Thank you for using my program!!!", "Farwell!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Handles the Click event of the Run control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Run_Click(object sender, EventArgs e)
        {
            ResultsLabel.Text = "";     //clears the old results
            int totalEvents;            //holds the total events proccessed 
            Event evnt;                 //the event that occurs each time through the loop
            Customer cust;              //the customer that occurs each time through the loop
            //proccess the events outputting data to GUI fields as collected
            while (market.EventQueue.Count > 0)
            {
                evnt = market.DoSimulation();
                cust = evnt.Customer;
                int register = cust.RegisterNumber;
                int custId = cust.CustomerNum;
                if (evnt.Type == EVENTTYPE.ENTER)
                {
                   switch(register)
                   {
                       case 0:
                           Reg1List.Items.Add(custId);
                           Reg1List.Refresh();
                           break;
                       case 1:
                           Reg2List.Items.Add(custId);
                           Reg2List.Refresh();
                           break;
                       case 2:
                           Reg3List.Items.Add(custId);
                           Reg3List.Refresh();
                           break;
                       case 3:
                           Reg4List.Items.Add(custId);
                           Reg4List.Refresh();
                           break;
                       case 4:
                           Reg5List.Items.Add(custId);
                           Reg5List.Refresh();
                           break;
                       case 5:
                           Reg6List.Items.Add(custId);
                           Reg6List.Refresh();
                           break;
                   }
                }
                else
                {
                    switch (register)
                    {
                        case 0:
                            Reg1List.Items.Remove(custId);
                            Reg1List.Refresh();
                            break;
                        case 1:
                            Reg2List.Items.Remove(custId);
                            Reg2List.Refresh();
                            break;
                        case 2:
                            Reg3List.Items.Remove(custId);
                            Reg3List.Refresh();
                            break;
                        case 3:
                            Reg4List.Items.Remove(custId);
                            Reg4List.Refresh();
                            break;
                        case 4:
                            Reg5List.Items.Remove(custId);
                            Reg5List.Refresh();
                            break;
                        case 5:
                            Reg6List.Items.Remove(custId);
                            Reg6List.Refresh();
                            break;
                    }
                }
                OutputBox.Text += market.output;
                OutputBox.Refresh();
                LongestQueueBox.Text = market.LongestQueue.ToString();
                LongestQueueBox.Refresh();
                ArrivalsBox.Text = market.Arrivals.ToString();
                ArrivalsBox.Refresh();
                DepartureBox.Text = market.Departures.ToString();
                DepartureBox.Refresh();
                totalEvents = market.Arrivals + market.Departures;
                EventsProccBox.Text = totalEvents.ToString();
                EventsProccBox.Refresh();
                
            }
            //generates statistics and outputs them to results label
            string endData = market.GenerateEndMessage();
            ResultsLabel.Text = endData;

            //finally sets new simulation as the acceptbutton
            AcceptButton = NewSimBtn;
            btnRun.Enabled = false;

            //slows thread to view easier
            Thread.Sleep(100);
        }

        /// <summary>
        /// Handles the Click event of the NewSimBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NewSimBtn_Click(object sender, EventArgs e)
        {
            //creates and shows a new main menu, hiding the old simulation window
            MainMenu main = new MainMenu();
            this.Hide();
            main.Show();
        }
    }
}
