///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         MainMenu.cs
//	Description:       The menu to gather the information needed for the simulation
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

namespace SupermarketSimulator
{
    /// <summary>
    /// Form that contains options for simulation, leads to simulation form.
    /// </summary>
    public partial class MainMenu : Form
    {
        //Declare and initialize the variables
        public static int Customers, Hours, Lanes = 0;

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the form load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenu_Load(object sender, EventArgs e)
        {
            //Display the current date
            lblDate.Text = DateTime.Now.ToLongDateString();

            //set the icon of the form from the resources
            this.Icon = SupermarketSimulator.Properties.Resources.supermarket;
        }

        /// <summary>
        /// Event handler for exiting the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit the application
            Application.Exit();
        }

        /// <summary>
        /// Event handler to obtain the amount of customers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStep1_Click(object sender, EventArgs e)
        {
            if(txtCustomers.Text == "")
            {
                //If the text box is empty
                MessageBox.Show("Please enter the number of customers to be served!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Enable and disable controls
                txtHours.Enabled = true;
                btnStep2.Enabled = true;

                txtCustomers.Enabled = false;
                btnStep1.Enabled = false;
            }
        }

        /// <summary>
        /// Event handler to obtain the hours of operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStep2_Click(object sender, EventArgs e)
        {
            int numHours = Int32.Parse(txtHours.Text);
            if(txtHours.Text == "")
            {
                //If the text box is empty
                MessageBox.Show("Please enter the hours of operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(numHours > 39)
            {
                //if user tries to enter hours open over 39 hours
                MessageBox.Show("Hours Open must be between 1 - 39!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Enable and disable controls
                txtLanes.Enabled = true;
                btnStep3.Enabled = true;

                txtHours.Enabled = false;
                btnStep2.Enabled = false;
            }
        }

        /// <summary>
        /// Event handler to obtain the number of lanes in use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStep3_Click(object sender, EventArgs e)
        {
            int numRegisters = Int32.Parse(txtLanes.Text);
            if(txtLanes.Text == "")
            {
                //If the text box is empty
                MessageBox.Show("Please enter the number of lanes in use!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(numRegisters > 6 || numRegisters < 1)
            {
                //If number of registers is out of bounds
                MessageBox.Show("The number of registers must be between 1 - 6!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLanes.Clear();
            }
            else
            {
                //Enable and disable controls
                txtLanes.Enabled = false;
                btnStep3.Enabled = false;
                //enables run simulation button and makes current accept button
                btnRun.Enabled = true;
                btnRun.Focus();
                AcceptButton = btnRun;
            }
            
        }

        /// <summary>
        /// Event handler to begin the simulation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {
            //Create and initialize the variables
            Customers = Int32.Parse(txtCustomers.Text);
            Hours = Int32.Parse(txtHours.Text);
            Lanes = Int32.Parse(txtLanes.Text);

            //Create the SupermarketGUI object and start the simulation
            SupermarketGUI market = new SupermarketGUI();
            this.Hide();
            market.Show();
        }

        /// <summary>
        /// Method created to allow numbers to be inputted only
        /// </summary>
        /// <param name="e"></param>
        public static void NumbersOnly(KeyPressEventArgs e)
        {
            //Checking if the input is either a control key or a number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// Event handler for KeyPress on txtCustomers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCustomers_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Call the method passing the keypress event argument
            NumbersOnly(e);
        }

        /// <summary>
        /// Event handler for KeyPress on txtHours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Call the method passing the keypress event argument
            NumbersOnly(e);
        }

        /// <summary>
        /// Event handler for KeyPress on txtLanes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLanes_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Call the method passing the keypress event argument
            NumbersOnly(e);
        }

        /// <summary>
        /// Handles the Enter event of the txtCustomers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtCustomers_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnStep1;
        }

        /// <summary>
        /// Handles the Enter event of the txtHours control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtHours_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnStep2;
        }

        /// <summary>
        /// Handles the Enter event of the txtLanes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtLanes_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnStep3;
        }
    }
}