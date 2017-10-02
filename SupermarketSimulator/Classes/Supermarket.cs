///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         Event.cs
//	Description:       The Supermarket class
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
    /// Contains all customer and event details for the simulation, manages data by using Queues and PriorityQueues
    /// </summary>
    public class Supermarket
    {
        Event evnt = new Event();                                                    //The ENTER or LEAVE event for each customer
        public List<Queue<Customer>> RegisterList;                                   //the list that holds each customer queue/"supermarket register"
        public PriorityQueue<Event> EventQueue;                                      //the priority que used to manage customer events
        private static Random R = new Random();                                      //random number used for determining random events
        public int NumCustomers { get; set; }                                        //the number of customers being served that day
        private static double NumExpected { get; set; }                              //the number of customers expected for that day
        public int Arrivals = 0;                                                     //the amount of arrival events proccessed so far
        public int Departures = 0;                                                   //the amount of departure events proccessed so far
        public int LongestQueue = 0;                                                 //the longest register queue experienced thus far
        public string output { get; set; }                                           //the output string containing events from the day
        private static int maxPresent = 0;                                           //the maximum amount of customers within the market for a day
        private static int maxRegisters = 5;                                         //the amount of registers available in the supermarket for that day
        private static int avgMin = 4;                                               //average minutes it takes a customer to check out
        private static int avgSec = 15;                                              //average seconds it takes a customer to check out
        private static int hoursOpen;                                                //amount of hours user specifies we will be open
        private static DateTime timeWeOpen;                                          //The opening time for the supermarket
        private static DateTime timeWeClose;                                         //The amount of time the supermarket will be open for
        public TimeSpan shortest,                                                    //The shortest individual time spent by a customer in line
                        longest,                                                     //The longest individual time spent by a customer in line
                        totalTime;                                                   //The total time spent by customers in line in a day


        /// <summary>
        /// Initializes a new instance of the <see cref="Supermarket"/> class.
        /// </summary>
        public Supermarket ( )
        {
            //initializes data structures
            EventQueue = new PriorityQueue<Event>();
            RegisterList = new List<Queue<Customer>>(maxRegisters);
            for (int i = 0; i < maxRegisters; i++)
                RegisterList.Add(new Queue<Customer>());
            
            //sets opening time to 8 am, closing time to midnight, and NumExpected customers to 600
            timeWeOpen = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 8, 0, 0);
            timeWeClose = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0);
            NumExpected = 600;

            //sets NumCustomers based on random Poisson distribution
            NumCustomers = Poisson(NumExpected);

            //Generate events
            GenerateCustomerEvents ( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Supermarket"/> class.
        /// </summary>
        /// <param name="numCustomers">The number of customers.</param>
        /// <param name="numHoursOpen">The number of hours open.</param>
        /// <param name="numRegisters">The number of registers.</param>
        public Supermarket (int numCustomers, int numHoursOpen, int numRegisters)
        {
            //initializes starting conditions
            NumExpected = numCustomers;
            hoursOpen = numHoursOpen;
            maxRegisters = numRegisters;
            
            //initializes data structures
            EventQueue = new PriorityQueue<Event>();
            RegisterList = new List<Queue<Customer>>(maxRegisters);
            for (int i = 0; i < maxRegisters; i++)
                RegisterList.Add(new Queue<Customer>());

            //sets opening time to 8 am, closing time to midnight, and NumExpected customers to 600
            int day = DateTime.Today.Day;
            int closingTime;
            if(hoursOpen > 15)
            {
                day++;
                closingTime = hoursOpen - 16;
            }
            else
            {
                closingTime = hoursOpen + 8;
            }
            timeWeOpen = new DateTime(DateTime.Today.Year, DateTime.Today.Month, day, 8, 0, 0);
            timeWeClose = new DateTime(DateTime.Today.Year, DateTime.Today.Month, day, closingTime, 0, 0);

            //sets NumCustomers based on random Poisson distribution
            NumCustomers = Poisson(NumExpected);

            //Generate events
            GenerateCustomerEvents();
        }

        /// <summary>
        /// Generates the patron events.
        /// </summary>
        public void GenerateCustomerEvents ( )
        {
            TimeSpan start, interval;
            shortest = new TimeSpan(0, 100000, 0);          //shortest stay
            longest = new TimeSpan(0, 0, 0);                //longest stay
            totalTime = new TimeSpan(0, 0, 0);              //total of all stays used for finding average
            Customer customer;                              //the customer to be associated with the given event
        
            for (int custNum = 1; custNum <= NumCustomers; custNum++)
            {
                //Random start time based on the number of minutes in the hours we are open
                start = new TimeSpan(0, R.Next(hoursOpen * 60), 0);
                //Random (neg exp.) interval with a minumum of two minutes;expected time = 6min 15sec
                interval = new TimeSpan(0, (int)(2.0 + NegExp(avgMin)), avgSec);
                totalTime += interval;

                if (shortest > interval)             //Remember the shortest stay
                    shortest = interval;

                if (longest < interval)              //Remember the longest
                    longest = interval;

                //Creates new customer
                customer = new Customer(start, interval, custNum);
                //Enqueues the arrival event for this customer
                EventQueue.Enqueue(new Event(EVENTTYPE.ENTER, timeWeOpen.Add(start), customer));
            }
        }

        /// <summary>
        /// Does the simulation.
        /// </summary>
        public Event DoSimulation ( )
        {
            maxPresent = 0;
            int current = 0;
            Customer customer1, customer2;
            Event custEvent;
            DateTime exitTime;

          
                //pulls in the customer object from the enter event
                custEvent = EventQueue.Peek();
                customer1 = custEvent.Customer;

                //add the top item to ouput and remove the top item from the queue
                output = EventQueue.Peek() + Environment.NewLine;
                EventQueue.Dequeue();

                //if top event is an arrival, increment number present
                if (custEvent.Type == EVENTTYPE.ENTER)
                {
                    //increment current present and Arrivals count
                    Arrivals++;
                    current++;
                    //if current exceeds max, set new max
                    if (current > maxPresent)
                        maxPresent = current;
 
                    //Enqueues the customer into the first shortest "checkout line" 
                    int capacity = 0;
                    while (capacity > -1)
                    {
                        //steps through checking each register in order
                        for (int i = 0; i < maxRegisters; i++)
                        {
                            //if this register has the current lowest possible, customer joins that 'line'
                            if (RegisterList[i].Count == capacity)
                            {
                                //If no one present at register already, customer begins checking out immediatley
                                if(capacity == 0)
                                {
                                    //Enqueue the departure event for this customer
                                    EventQueue.Enqueue(new Event(EVENTTYPE.LEAVE, timeWeOpen.Add(customer1.ArrivalTime + customer1.ServeTime), customer1));
                                }
                                //enqueue the customer hereand set the customer register number
                                RegisterList[i].Enqueue(customer1);
                                customer1.RegisterNumber = i;

                                //check if this is the new longest line, if so, set LongestQueue
                                if ((capacity + 1) > LongestQueue)
                                {
                                    LongestQueue = capacity++;
                                    LongestQueue++;
                                }
                                //break from for loop and set capacity to negative to exit while loop
                                capacity = -2;
                                break;
                            } 
                        }
                        //else we increment capacity, and search for a register with a line of the new length
                        capacity++;
                    } 
                }
                //If it is not an ENTER event, it must be a LEAVE event
                else
                {
                    //so we decrement the number present currently and increment the Departures count
                    Departures++;
                    current--;
                    int currentReg = customer1.RegisterNumber;

                    //removes the old customer from the register queue and checks to see if there are more customers
                    RegisterList[currentReg].Dequeue();
                    if (RegisterList[currentReg].Count > 0)
                    {
                        //if there is another customer, then we need to Enqueue that customer's exit event
                        customer2 = RegisterList[currentReg].Peek();
                        //to do that, we need the time the person before them left the line
                        exitTime = custEvent.Time;
                        //Enqueue the departure event for this customer
                        EventQueue.Enqueue(new Event(EVENTTYPE.LEAVE, exitTime.Add(customer2.ServeTime), customer2));
                    }
                }
                return custEvent;
        }

        /// <summary>
        /// Generates the end message.
        /// </summary>
        /// <returns></returns>
        public string GenerateEndMessage ()
        {
            //calculates average seconds and minutes from totalTime
            int averageSec = totalTime.Seconds;
            averageSec += (totalTime.Minutes * 60);
            averageSec += (totalTime.Hours * 360);
            averageSec += (totalTime.Days * 86400);
            averageSec = averageSec / NumCustomers;
            int averageMin = averageSec / 60;
            averageSec = averageSec % 60;
            
            //constructs and returns a string containing the ending information
            string endData = String.Format("The average service time for {0} customers was {1}:{2:00}.\nThe minimum service time was {3} and the maximum service time was {4}", NumCustomers, averageMin, averageSec, shortest, longest);
            return endData;
        }

        /// <summary>
        /// Returns a random number according to a Poisson distribution centered around the
        /// given expected value.
        /// </summary>
        /// <param name="ExpectedValue">The expected value within the Poisson distribution.</param>
        /// <returns></returns>
        private static int Poisson(double ExpectedValue)
        {
            //determines limit and sum
            double dLimit = -ExpectedValue;
            double dSum = Math.Log(R.NextDouble());

            //determines iterations required for dSum to exceed the limit
            int Count;
            for (Count = 0; dSum > dLimit; Count++)
                dSum += Math.Log(R.NextDouble());

            //returns that number of iterations
            return Count;
        }

        /// <summary>
        /// Returns a random number according to a Negative Exponential distribution
        /// centered around the given expected value.
        /// </summary>
        /// <param name="ExpectedValue">The expected value.</param>
        /// <returns></returns>
        private static double NegExp(double ExpectedValue)
        {
            return -ExpectedValue * Math.Log(R.NextDouble(), Math.E);
        }

        /// <summary>
        /// Returns a random number according to a Normal distribution centered around the
        /// given expected value.
        /// </summary>
        /// <param name="ExpectedValue">The expected value.</param>
        /// <param name="StdDev">The standard dev.</param>
        /// <returns></returns>
        private static double Normal(double ExpectedValue, double StdDev)
        {
            //using the Box-Muller algorithm...
            double r = Math.Sqrt(-2.0 * Math.Log(R.NextDouble()));
            double Theta = 2.0 * Math.PI * R.NextDouble();
            double Value = r * Math.Sin(Theta);
            return ExpectedValue + StdDev * Value;

        }
    }
}
