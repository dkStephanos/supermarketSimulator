///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         Customer.cs
//	Description:       The Customer class
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Chris Harris, harriscr1@goldmail.etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Saturday, April 16, 2015
//	Copyright:         Chris Harris, 2015
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using SupermarketSimulator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSimulator.Classes
{
    /// <summary>
    /// Contains information and methods neccesary to create and manage customer objects.
    /// </summary>
    public class Customer
    {
        public static Random R = new Random();                 //random number used for determining random events
        public TimeSpan ArrivalTime { get; set; }                    //the time at which the customer will arive
        public TimeSpan ServeTime { get; set; }                      //the time required to serve the customer
        public int CustomerNum { get; set; }                    //the number assigned to the customer for tracking purposes
        public int RegisterNumber;                      //the number of the register the customer is in line for, -1 if not in line

    
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="custNum">The customer number.</param>
        public Customer (TimeSpan arrivalTime, TimeSpan serveTime, int custNum)
        {
            ArrivalTime = arrivalTime;
            ServeTime = serveTime;
            CustomerNum = custNum;
            RegisterNumber = -1;
        }
         
    }
}
