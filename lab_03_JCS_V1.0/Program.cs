// CS 1400 Project 03
// Investigating Data Types in C#
// Using the Console class
// Author Jonathan Spalding
// Date: 1/14/2016
//--------------------------------------
using System;
using static System.Console;

namespace lab_03_JCS_V1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge = 0;
            double userMoney = 0;
            string myName = "Hal";
            string userName = "";

            WriteLine($"Hello, my name is {myName}");
            //System.Threading.Thread.Sleep(1000);
            WriteLine("Please Write your name: ");

            userName = ReadLine();

            WriteLine($"Hello {userName}, how old are you?");

            userAge = int.Parse(ReadLine());

            userAge = userAge + 1;

            WriteLine("How much money do you have?");

            userMoney = double.Parse(ReadLine());

            WriteLine($"Thank you {userName}. You are almost {userAge} years old and you have {userMoney:c}.");


            WriteLine("Press any key to continue.");
            ReadKey(true);
        }
    }
}
