using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryVsList_Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTIONS
            // 1.) O(n)
            // 2.) O(n(n))
            // 3.) Probably by using a dictionary


            // Creates a new file reader, which loads a file of words
            // into both a list and a dictionary
            PracticeExerciseFileReader reader = new PracticeExerciseFileReader();

            // Get the two data structures needed for the exercise
            List<String> wordList = reader.WordList;
            Dictionary<String, bool> wordDictionary = reader.WordDictionary;

            // *********************
            // Put your code between here...

            //String to store user input
            string input;

            do
            {
                string doubleWord;
                Console.WriteLine("Choose a collection to search (\"L\" for List, \"D\" for Dictionary).");
                Console.WriteLine("Enter \"E\" to exit.");
                input = Console.ReadLine().Trim().ToUpper();


                if (input == "L")
                {
                    foreach(string word in wordList)
                    {
                        doubleWord = word + word;
                        bool doesContain = wordList.Contains(doubleWord);
                        if(doesContain == true)
                        {
                            Console.WriteLine(doubleWord);
                        }
                    }
                }
                else if (input == "D")
                {
                    foreach (string word in wordList)
                    {
                        doubleWord = word + word;
                        bool doesContain = wordDictionary.ContainsKey(doubleWord);
                        if (doesContain == true)
                        {
                            wordDictionary["doubleWord"] = true;
                            Console.WriteLine(doubleWord);
                        }
                    }
                    Console.WriteLine();

                    Console.WriteLine("Enter a word to search the dictionary for its doubled form: ");
                    string dictInput = Console.ReadLine().Trim().ToLower();
                    string doubleInput = dictInput + dictInput;
                    bool inputContain = wordDictionary.ContainsKey(doubleInput);
                    if(inputContain == true)
                    {
                        Console.WriteLine("Doubled word found in dictionary!");
                    }
                    else
                    {
                        Console.WriteLine("Doubled word not found.");
                    }
                    Console.WriteLine();
                }
            }
            while (input != "E");




            // ...and here.
            // *********************

        }
    }
}
