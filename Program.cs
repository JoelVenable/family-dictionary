using System;
using System.Collections.Generic;

namespace family_dictionary
{
  class Program
  {
    static void Main(string[] args)
    {
      var myFamily = new Dictionary<string, Dictionary<string, string>>() {
                {"sister", new Dictionary<string, string>() {
                    {"name", "Krista"},
                    {"age", "42"}
                }},
                 {"mother", new Dictionary<string, string>() {
                    {"name", "Cathie"},
                    {"age", "70"}
                }}
            };

      foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
      {
        Console.WriteLine($"{(familyMember.Value["name"])} is my {familyMember.Key} and is {(familyMember.Value["age"])} years old");
      }
    }
  }
}
