///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         IContainer.cs
//	Description:       The Supermarket class
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Chris Harris, harriscr1@goldmail.etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Saturday, April 16, 2015
//	Copyright:         Chris Harris, 2015
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketSimulator
{
    public interface IContainer<T>
    {
        //removes all object from the container
        void Clear ( );
        //return true if the container is empty
        bool IsEmpty();
        //Returns the number of entries in the container
        int Count { get; set; }
    }
}
