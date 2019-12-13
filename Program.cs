using System;
using System.Collections.Generic;

namespace Bakery
{ 
    public class Program
    {

        static void Main()
        { 

            Console.WriteLine("Welcome to Pierre's Bakery! Or as we like to say, Bienvenue! We have loaves of bread for $5 each and pastries for $2 each. We are running a Christmas special for the month of December where our loaves of bread are buy 2 get 1 free and our pastries are 3 for $5!");
            Console.WriteLine("Please enter the number of loaves you would like to purchase today: ['0' to skip to pastries]");
            string stringBread = Console.ReadLine();
            int numBread = int.Parse(stringBread);
            Console.WriteLine("How many pastries would you like? ['0' to skip to checkout]");                string stringPastries = Console.ReadLine();
            int numPastries = int.Parse(stringPastries);

            Bread breads = new Bread(numBread, 5);  
            Pastry pastries = new Pastry(numPastries, 2); 

            int breadCost = breads.CalculateCost();
            int pastryCost = pastries.CalculateCost(); 
            int total = (breadCost + pastryCost);
            string stringTotal = total.ToString();
            Console.WriteLine("Your total comes out to: $"+ stringTotal);

        }
    }
}