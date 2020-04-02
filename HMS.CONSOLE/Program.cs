using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using HMS.CONSOLE.Data;
using HMS.CONSOLE.Models;

namespace HMS.CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int result = -1;
            while (result != 9)
            {
                result = MainMenu();
            }
        }

        static int MainMenu()
        {
            int result = -1;
            ConsoleKeyInfo cki;
            bool cont = false;

            do
            {

                Console.Clear();

            } while (!cont);

            return 0;
        }

        static void WriteHeader(string headerText)
        {
            Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + headerText.Length / 2) + "}", headerText));
        }

        static bool ValidateYorN(string entry)
        {
            bool result = false;
            if (entry.ToLower() == "y" || entry.ToLower() == "n")
            {
                result = true;
            }
            return result;
        }

    }

}
    
