﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Basic Calculator!");
            var stay = true;

            do
            {

            Console.WriteLine("Menu");
            System.Console.WriteLine("Press 1 for Addition.");
            System.Console.WriteLine("Press 2 for Subtraction.");
            System.Console.WriteLine("Press 3 for Multiplication");
            System.Console.WriteLine("Press 4 for Division");
            System.Console.WriteLine("Press 5 for Exit");

            var choice = Console.ReadLine();

            switch(choice)
            {
              case "1":
                // var input1 = (double)Console.ReadLine(); // explicit casting with exception
                // var input2 = Console.ReadLine() as double; // explicit casting , will return null

                var input1 = double.Parse(Console.ReadLine()); // explicit parsing with 0
                double input2;
                double.TryParse(Console.ReadLine(), out input2); // explicit parsing with boolean exception

                Add(input1, input2);
                break;

                case "2":
                  double input3;
                  double input4;

                  if(double.TryParse(Console.ReadLine(), out input3))
                  {
                      System.Console.WriteLine("valid");
                  }
                  else
                  {
                    System.Console.WriteLine("not valid");
                  }

                  if(double.TryParse(Console.ReadLine(), out input4))
                  {
                      System.Console.WriteLine("valid");
                  }
                  else
                  {
                    System.Console.WriteLine("not valid");
                  }

                Subtract(input3, input4);
                break;

                case "3":
                double input5;
                  double input6;

                  if(double.TryParse(Console.ReadLine(), out input5))
                  {
                      System.Console.WriteLine("valid");
                  }
                  else
                  {
                    System.Console.WriteLine("not valid");
                  }

                  if(double.TryParse(Console.ReadLine(), out input6))
                  {
                      System.Console.WriteLine("valid");
                  }
                  else
                  {
                    System.Console.WriteLine("not valid");
                  }

                Multiply(input5, input6);
                break;

                default:
                stay = false;
                break;
            }
        } while (stay);
    }

        static void Add(double operand1, double operand2)
        {
          System.Console.WriteLine($"your answer is: {operand1 + operand2}");
        }

        static void Subtract(double operand1, double operand2)
        {
          System.Console.WriteLine($"your answer is: {operand1 - operand2}");
        }
        
        static void Multiply(double operand1, double operand2)
        {
          System.Console.WriteLine($"your answer is: {operand1 * operand2}");
        }

        static void Division(double operand1, double operand2)
        {
          System.Console.WriteLine($"your answer is: {operand1 / operand2}");
        }
    }
}
