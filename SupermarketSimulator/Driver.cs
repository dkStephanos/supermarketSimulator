///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Project 4
//	File Name:         Event.cs
//	Description:       The Driver class
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketSimulator
{
    /// <summary>
    /// Implements the Supermarket classes in a GUI interface.
    /// </summary>
    static class Driver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new MainMenu());
        }
    }
}
