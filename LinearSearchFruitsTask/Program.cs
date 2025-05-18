namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

                string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

                Console.WriteLine("Enter the fruit you want to find?");
                string userInput = Console.ReadLine();

                int i = 0;
                bool found = false;

                while (i < fruits.Length)
                {
                    if (fruits[i] == userInput)
                    {
                        found = true;
                    }
                    i++;
                }

                if (found == true)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }
    // Your program should:
    // Ask the user what word they would like to find
    // Output the message True if the word is found
    // Output the message False if the word is not found

    // You must write your own linear search routine and not use any built-in fuctions available in C#
    // You should use meaningful variable names
