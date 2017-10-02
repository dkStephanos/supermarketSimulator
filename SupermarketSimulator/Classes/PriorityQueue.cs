///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         PriorityQueue.cs
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

namespace SupermarketSimulator
{
    /// <summary>
    /// Implements the Priority Queue data structure by using a linked list.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PriorityQueue<T> : IPriorityQueue<T>
        where T : IComparable
    {
        //Fields and properties
        private Node top;                       //reference to the top of the Priority Queue
        public int Count { get; set; }          //number of items in the Priority Queue

        /// <summary>
        /// Enqueues the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Enqueue(T item)
        {
            if (Count == 0)
            {
                top = new Node(item, null);
            }
            else
            {
                Node current = top;
                Node previous = null;

                //Search for the first node in the linked structure that is smaller in priority that item
                while (current != null && current.Item.CompareTo(item) >= 0)
                {
                    previous = current;
                    current = current.Next;
                }

                //Have found the place to insert the new node
                Node newNode = new Node(item, current);

                //if there is a previous node, set it to link to the new node
                if (previous != null)
                {
                    previous.Next = newNode;
                }
                else
                {
                    top = newNode;
                }
            }
            Count++;        //Add 1 to the number of nodes in the priority queue
        }

        /// <summary>
        /// Dequeues this instance.
        /// </summary>
        /// <exception cref="System.InvalidOperationException">Cannot remove from empty queue.</exception>
        public void Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Cannot remove from empty queue.");
            }
            else
            {
                Node oldNode = top;
                top = top.Next;
                Count--;
                oldNode = null;     //do this so the removed node can be garbage collected
            }
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            top = null; //set the top to null, all exisiting nodes will be garbage collected
        }

        /// <summary>
        /// Peeks this instance.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.InvalidOperationException">Cannot obtain top of empty priority queue.</exception>
        public T Peek()
        {
            if (!IsEmpty())
            {
                return top.Item;
            }
            else
            {
                throw new InvalidOperationException("Cannot obtain top of empty priority queue.");
            }
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Count == 0;
        }

        /// <summary>
        /// The node required to implement a Priority Queue
        /// </summary>
        private class Node
        {
            //Properties
            public T Item { get; set; }
            public Node Next { get; set; }

            /// <summary>
            /// Initializes a new instance of the Node class.
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="link">The link.</param>
            public Node(T value, Node link)
            {
                Item = value;
                Next = link;
            }
        }
    }
}
