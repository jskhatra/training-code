using System.Collections.Generic;
using System.Text;

namespace PizzaStore.Domain.Models
{

    public class Pizza
    {
      // STATE
      // fields
      //properties
      string imageUrl = "";

      double diameter = 0;

      public string Size = "";

      public List<string> Toppings = new List<string>();
      public string Crust = "";

    // PROPERTIES 
    public string SizeP { get; }

    // METHODS
      void AddToppings(string topping)
      {
          Toppings.Add(topping);
      }

      public override string ToString()
      {
          var sb = new StringBuilder();

          foreach(var t in Toppings)
          {
            sb.Append(t + ", ");
          }
          return $"{Crust} {Size} {sb}";
      }

      public Pizza(string size, string crust, List<string> toppings)
      {
          SizeP = size;
          Crust = crust;
          Toppings.AddRange(toppings);
      }
    }
}