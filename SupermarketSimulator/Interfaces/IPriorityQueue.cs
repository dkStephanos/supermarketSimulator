///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         IPriorityQueue.cs
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
    public interface IPriorityQueue<T> : IContainer<T> 
                                 where T : IComparable
    {
        //Inserts item based on its priority
        void Enqueue(T item);

        //Removes first item in the queue
        void Dequeue();

        //Query
        T Peek();
    }
}
