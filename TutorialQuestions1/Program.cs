using System.Text.RegularExpressions;
using System.Linq;

namespace TutorialQuestions1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Write a C# console application that prompts the user to enter their name and age. Validate the input and store them in variables using implicit variable declaration (var).
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            var age = Console.ReadLine();

            // Regex pattern to check if the name contains a number or special character
            string pattern = @"[\d\W_]";
            //[\d\W_]: This pattern matches any digit (\d) or non-word character (\W), including underscores (_).

            // Check if the name matches the pattern

            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine("Invalid name: Name should not contain numbers or special characters.");
            }
            else
            {
                Console.WriteLine("Valid name: Name does not contain numbers or special characters.");
            }

            //2.Develop a C# program that calculates the average grade for a set of students. Create a collection of grades (e.g., array, list) and use implicit variable declaration (var) for iteration and calculation.
            int [] grade = {10, 45, 60, 98, 69, 72, 99};
            var avg = Queryable.Average(grade.AsQueryable());//Using the linq Avergae Method.
            avg = Math.Round(avg, 2);
            Console.WriteLine("Class average is: " + avg);

            //3.Instructions: Write a C# program to generate the Fibonacci sequence up to a specified number of terms. Store the sequence in a collection and utilize implicit variable declaration (var) where appropriate.
            long a = 0, b = 1, c = 0;
            Console.WriteLine("Enter the number of terms you would like to reach: ");
            int iterations  = int.Parse(Console.ReadLine());

            Console.WriteLine("1");
            for(int i = 0; i < iterations; i++) 
            {
                
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }

            //4.Create a C# program that takes a string input from the user, performs string manipulation operations (e.g., reversing, converting case), and displays the result. Use implicit variable declaration (var) for string variables.
            Console.WriteLine("Enter a string for manipulation: ");

            var inputString = Console.ReadLine();

            // Display the original input string
            Console.WriteLine("Original String: " + inputString);

            // Perform string manipulation operations
            var reversedString = ReverseString(inputString);
            var upperCaseString = inputString.ToUpper();
            var lowerCaseString = inputString.ToLower();

            // Display the manipulated strings
            Console.WriteLine("Reversed String: " + reversedString);
            Console.WriteLine("Uppercase String: " + upperCaseString);
            Console.WriteLine("Lowercase String: " + lowerCaseString);

            // Method to reverse the input string
            static string ReverseString(string input)
            {
                // Convert the input string to a character array
                var charArray = input.ToCharArray();

                // Reverse the character array
                Array.Reverse(charArray);

                // Convert the character array back to a string
                var reversedString = new string(charArray);

                // Return the reversed string
                return reversedString;
            }

            //5.Develop a C# program that sorts a list of numbers in ascending order. Utilize implicit variable declaration (var) when declaring variables to store sorted results or during sorting algorithm implementations.
            // Define an array of unsorted numbers
            int [] numbers = { 5, 2, 9, 1, 7 };

            // Display the original unsorted array
            Console.WriteLine("Original Array:");
            DisplayArray(numbers);

            // Sort the array in ascending order
            Array.Sort(numbers);

            // Display the sorted array
            Console.WriteLine("\nSorted Array:");
            DisplayArray(numbers);

            static void DisplayArray(int[] array)
            {
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
