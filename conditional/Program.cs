using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double ttlBill;
            int custAppr = 50;
            double subTtl;
            double grndTtl;

            Console.Write("How many people will be dining: ");
            int ttlPpl = int.Parse(Console.ReadLine());

            Console.Write("What is the cost per plate: ");
            double cstPsn = double.Parse(Console.ReadLine());

            ttlBill = ttlPpl * cstPsn;
            subTtl = ttlPpl * cstPsn;
            if (subTtl >= custAppr)
            {
                double discount = subTtl * .10;
                grndTtl = subTtl - discount;
                Console.WriteLine("Congradulations your party receives a 10% discount on your total bill ");
                Console.Write("Your total bill is: " + grndTtl);
            }

            else

            {
                double discount = subTtl * .05;
                grndTtl = subTtl - discount;
                Console.WriteLine("Congradulations your party receives a 5% discount on your total bill");
                Console.Write("Your total bill is: " + grndTtl);
            }
          
           
            int age;

            Console.Write("Please enter your age: ");
            age = int.Parse(Console.ReadLine());

            if (age > 0 && age <= 2)
            {
                Console.WriteLine("Still in mamas arms");

            }else if (age >= 3 && age<= 4)
            {
                Console.WriteLine("Preschool Maniac");
            }
            else if (age >= 5 && age <= 11)
            {
                Console.WriteLine("Elementary School");
            }
            else if (age >= 12 && age <= 14)
            {
                Console.WriteLine("Middle School");
            }
            else if (age >= 15 && age <= 18)
            {
                Console.WriteLine("High School");
            }
            else if (age >= 19 && age <= 22)
            {
                Console.WriteLine("College");
            }
            else if (age >= 23 && age <= 65)
            {
                Console.WriteLine("Working for the man");
            }
            else if (age >= 66 && age <= 100)
            {
                Console.WriteLine("Golden Years");
            }else
            {
                Console.WriteLine("The program is for humans");
            }
            */

            Console.Write("Please enter a word that corresponds with a number between 1 - 10: ");
            string number = Console.ReadLine();
            switch (number)
            {
                case "one":
                    Console.WriteLine("The number that corresponds with " + number + " is 1");
                    break;
                case "two":
                    Console.WriteLine("The number that corresponds with " + number + " is 2");
                    break;
                case "three":
                    Console.WriteLine("The number that corresponds with " + number + " is 3");
                    break;
                case "four":
                    Console.WriteLine("The number that corresponds with " + number + " is 4");
                    break;
                case "five":
                    Console.WriteLine("The number that corresponds with " + number + " is 5");
                    break;
                case "six":
                    Console.WriteLine("The number that corresponds with " + number + " is 6");
                    break;
                case "seven":
                    Console.WriteLine("The number that corresponds with " + number + " is 7");
                    break;
                case "eigh":
                    Console.WriteLine("The number that corresponds with " + number + " is 8");
                    break;
                case "nine":
                    Console.WriteLine("The number that corresponds with " + number + " is 9");
                    break;
                case "ten":
                    Console.WriteLine("The number that corresponds with " + number + " is 10");
                    break;
                case "zero":
                    Console.WriteLine("The number that corresponds with " + number + " is 0");
                    break;
                default:
                    Console.WriteLine("The value you enetered is invalid");
                    break;
            
            }
        }
    }
}
