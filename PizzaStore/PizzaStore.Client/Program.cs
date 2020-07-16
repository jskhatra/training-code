using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
  class Program
  {
    static void Main()
    {
      Welcome();
    }

    static void Welcome()
    {
      System.Console.WriteLine("Welcome to PizzaWorld!");
      System.Console.WriteLine("Best Pizza in the world!");

      string[] cart1 = { "", "", "" };  // initial values
      string[] cart2 = new string[3];  // default values
      string[] cart3 = new[] { "", "", "" };  // initial values, custom data types

      // list
      List<string> cart4 = new List<string> { "", "", "" }; // initial values
      List<string> cart5 = new List<string>(); // default values
      List<Pizza> cart6 = new List<Pizza>();

      //Menu(cart2);
      Menu2(cart6);
    }

    static void Menu(string[] cart)
    {
      var exit = false;
      var number = 0;

      do
      {
        if (number < cart.Length)
        {
          System.Console.WriteLine("Select 1 for Cheese Pizza");
          System.Console.WriteLine("Select 2 for Pepperoni Pizza");
          System.Console.WriteLine("Select 3 for Pineapple Pizza");
          System.Console.WriteLine("Select 4 for Custom Pizza");
          System.Console.WriteLine("Select 5 fto Display Cart");
          System.Console.WriteLine("Select 6 to Exit");

          int select;

          int.TryParse(Console.ReadLine(), out select);

          switch (select)
          {
            case 1:
              cart[number] = "cheese";
              number += 1;
              System.Console.WriteLine("added Cheese Pizza");
              break;
            case 2:
              cart[number] = "pepperoni";
              System.Console.WriteLine("Added Pepperoni Pizza");
              number += 1;
              break;
            case 3:
              cart[number] = "pineapple";
              System.Console.WriteLine("Added Pineapple Pizza");
              number += 1;
              break;
            case 4:
              cart[number] = "custom";
              System.Console.WriteLine("Added Custom");
              number += 1;
              break;
            case 5:
              DisplayCart(cart);
              break;
            case 6:
              System.Console.WriteLine("Exiting...");
              exit = true;
              break;
          }
        }
        else
        {
          DisplayCart(cart);
          exit = true;
        }
      } while (!exit);
    }

    static void Menu2(List<Pizza> cart)
    {
      var exit = false;
      var number = 0;
      var startup = new PizzaStore.Client.Startup();

      do
      {
        System.Console.WriteLine("Select 1 for Cheese Pizza");
        System.Console.WriteLine("Select 2 for Pepperoni Pizza");
        System.Console.WriteLine("Select 3 for Pineapple Pizza");
        System.Console.WriteLine("Select 4 for Custom Pizza");
        System.Console.WriteLine("Select 5 fto Display Cart");
        System.Console.WriteLine("Select 6 to Exit");

        int select;

        int.TryParse(Console.ReadLine(), out select);

        switch (select)
        {
          case 1:
            cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"Cheese"}));
            number += 1;
            System.Console.WriteLine("added Cheese Pizza");
            break;
          case 2:
            cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"Pepperoni"}));
            System.Console.WriteLine("Added Pepperoni Pizza");
            number += 1;
            break;
          case 3:
            cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"Pineapple"}));
            System.Console.WriteLine("Added Pineapple Pizza");
            number += 1;
            break;
          case 4:
            cart.Add(startup.CreatePizza("L", "Stuffed", new List<string>{"Custom"}));
            System.Console.WriteLine("Added Custom");
            number += 1;
            break;
          case 5:
            DisplayCart2(cart);
            break;
          case 6:
            System.Console.WriteLine("Exiting...");
            exit = true;
            break;
        }
      } while (!exit);
    }
    static void DisplayCart(string[] cart)
    {
      foreach (var pizza in cart)
      {
        System.Console.WriteLine(pizza);
      }

      for (var i = 0; i < cart.Length - 1; i += 1)
      {
        System.Console.WriteLine(cart[i]);
      }
    }

    static void DisplayCart2(List<Pizza> cart)
    {
      foreach (var pizza in cart)
      {
        System.Console.WriteLine(pizza);
      }

    }


  }
}
