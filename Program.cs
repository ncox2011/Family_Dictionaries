using System;
using System.Collections.Generic;

namespace family_dictionary
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Faith"},
                {"age", "32"}
            });
            myFamily.Add("dad", new Dictionary<string, string>(){
                {"name", "Tim"},
                {"age", "51"}
            });
            myFamily.Add("sister-law", new Dictionary<string, string>(){
                {"name", "Jenny"},
                {"age", "23"}
            });
            myFamily.Add("son", new Dictionary<string, string>(){
                {"name", "Julien"},
                {"age", "8"}
            });
            myFamily.Add("daughter", new Dictionary<string, string>(){
                {"name", "Jackie"},
                {"age", "6"}
            });

            foreach (KeyValuePair<string, Dictionary<string,string>> person in myFamily)
            {
                Console.WriteLine($"{person.Value["name"]} is my {person.Key} and is {person.Value["age"]} years old!");
            }
        }
    }
}
