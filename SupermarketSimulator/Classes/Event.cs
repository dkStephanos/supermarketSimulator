///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         Event.cs
//	Description:       The Event class
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
    public enum EVENTTYPE { ENTER, LEAVE };        //enumeration used with event class

    /// <summary>
    /// Contains information neccessary for the creation of events that occur within the supermarket simulation.
    /// </summary>
    public class Event : IComparable
    {
        //Properties
        public EVENTTYPE Type { get; set; }
        public DateTime Time { get; set; }
        public Customer Customer { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        public Event ( )
        {
            Type = EVENTTYPE.ENTER;
            Time = DateTime.Now;
            Customer = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        /// <param name="type">The type of event.</param>
        /// <param name="time">The time of the event.</param>
        /// <param name="patron">The patron number.</param>
        public Event (EVENTTYPE type, DateTime time, Customer customer)
        {
            Type = type;
            Time = time;
            Customer = customer;
        }

        /// <summary>
        /// Returns a string that represents this instance.
        /// </summary>
        /// <returns>
        /// A string that represents this instance.
        /// </returns>
        public override string ToString()
        {
            String str = "";

            str += String.Format("Customer {0} ", Customer.CustomerNum);
            str += Type + "'s";
            str += String.Format(" at {0}", Time.ToShortTimeString());
            
            return str;
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has these meanings: Value Meaning Less than zero This instance precedes <paramref name="obj" /> in the sort order. Zero This instance occurs in the same position in the sort order as <paramref name="obj" />. Greater than zero This instance follows <paramref name="obj" /> in the sort order.
        /// </returns>
        /// <exception cref="System.ArgumentException">The argument is not an Event object</exception>
        public int CompareTo (Object obj)
        {
            if (!(obj is Event))
                throw new ArgumentException("The argument is not an Event object");

            Event e = (Event)obj;
            return (e.Time.CompareTo(Time));
        }
    }
}
