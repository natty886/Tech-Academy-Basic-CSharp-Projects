using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6PartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART 1
            //
            //A one-dimensional array of strings.
            //string[] petNames = { "Charlie ", "Jewelie ", "Spike ", "Luna " };


            //Ask the user to input some text.
            //Console.WriteLine("Add your Pet's name.");
            //string petName = Console.ReadLine();


            //A loop that iterates through each string in the array and adds the user's text input to the end of each string. 
            //for (int i = 0; i < petNames.Length; i++)
            //{
            //    petNames[i] += petName;
            //}


            //A second loop that prints off each string in the array.
            // for (int i = 0; i < petNames.Length; i++)
            //{
            //        Console.WriteLine(petNames[i]);
            //    }
            //Console.ReadLine();


            //PART 2
            //
            //An infinite loop.
            //Console.WriteLine("Press Enter to take a ride on the loop! (Or 'stop' to quit.)");


            //while (true)
            //{
            //    Console.WriteLine("Woo Hoo!");
            //    string input = Console.ReadLine();
                  //Fixed the infinite loop by entering 'stop'.
            //if (input == "stop")
            //{
            //    Console.WriteLine("That was fun!");
            //    break;
            //}
            //Console.ReadLine();
            //}
            //Console.ReadLine();


            //PART 3
            //
            //A loop where the comparison is determined by "<".
            //int i = 1;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //A loop where the comparison is determined by "<".
            //int n = 2;
            //while (n <= 10)
            //{
            //    Console.WriteLine(n);
            //    n++;
            //}


            //PART 4
            //
            //A list of strings where each item in the list is unique.
            List<string> list = new List<string>();
            list.Add("Yo");
            list.Add("Hola");
            list.Add("Konichiwa");
            list.Add("Salut");

            //Ask user to input text to search list.
            Console.WriteLine("Enter the text you want to search for:");
            string searchText = Console.ReadLine();

            //A loop iterates through the list then displays list item index.
            bool found = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == searchText)
                {
                    Console.WriteLine("Found! at " + i);
                    found = true;
                    break;
                }
            }

            //If text isn't on list displays message. 
            if (!found)
            {
                Console.WriteLine("The text was not found.");
            }


            //PART 5
            //
            //A list of strings where two items are identical. Ask user to search list.
            List<string> part5List = new List<string>();
            part5List.Add("A ver");
            part5List.Add("A ver");
            part5List.Add("A mover");
            part5List.Add("La colita");
            
            Console.WriteLine("Enter the text you want to search for:");
            string searchText2 = Console.ReadLine();

            //A loop iterates through the list then displays list item index. Remove break statements.
            bool found2 = false;
            for (int i = 0; i < part5List.Count; i++)
            {
                if (part5List[i] == searchText2)
                {
                    Console.WriteLine("Found! at " + i);
                    found2 = true;
                }
            }

            //Add code if text isn't on list displays message. 
            if (!found2)
            {
               Console.WriteLine("The text was not found.");
            }


            //PART 6 
            //
            //A list of strings where two items are identical.
            List<string> part6List = new List<string>() { "Booga", "Booga", "Oooga", "Wooga" };
 
            List<string> blankList = new List<string>();

            //foreach loop evaluating each item showing the string and whether or not it has already appeared in the list
            foreach (string item in part6List)
            {
                if (blankList.Contains(item))
                { 
                    Console.WriteLine(item + " has appeared already.");
                }

                else
                {
                    Console.WriteLine(item + " has not appeared yet.");
                }

                blankList.Add(item);
            }
            Console.ReadLine();
        }   
            
    }
    
}
