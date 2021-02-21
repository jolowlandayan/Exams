using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            //BubbleSorting(arr);
            //var result = ShiftingElementsToLeft(arr);
            //var result = ShiftingElementsToRight(arr);
            //foreach (var res in result)
            //{
            //    Console.WriteLine(res);
            //    Console.ReadKey();
            //}

            //PalindromeValidation("Racecar");
            //var word = "pato";
            //var result = PalindromeRecursion(word);
            //if (result)
            //    Console.WriteLine($"The word {word} is a palindrome");
            //else
            //    Console.WriteLine($"The word {word} is not a palindrome");



            Console.ReadKey();
        }

        public static List<int> BubbleSorting(int[] listOfSort)
        {
            int temp = 0;
            List<int> sorted = new List<int>();

            for (int p = 0; p <= listOfSort.Length - 2; p++)
            {
                for (int i = 0; i <= listOfSort.Length - 2; i++)
                {
                    if (listOfSort[i] > listOfSort[i + 1])
                    {
                        temp = listOfSort[i + 1];
                        listOfSort[i + 1] = listOfSort[i];
                        listOfSort[i] = temp;
                    }
                }
            }

            for (int i = 0; i < listOfSort.Length; i++)
            {
                Console.Write(listOfSort[i] + " ");
                sorted.Add(listOfSort[i]);
            }

            return sorted;
        }

        public static List<int> ShiftingElementsToLeft(int[] numbers)
        {
            int size = numbers.Length;
            int[] shiftedNumbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                shiftedNumbers[i] = numbers[(i + 1) % size];
            }

            return shiftedNumbers.ToList();
        }

        public static void PalindromeValidation(string word)
        {
            string reverseString = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseString += word[i].ToString();
            }

            if (reverseString.ToLower() == word.ToLower())
                Console.WriteLine($"The word {word} is a palindrome");
            else
                Console.WriteLine($"The word {word} is not a palindrome");

            Console.ReadKey();
        }

        public static bool PalindromeRecursion(string word)
        {
            if (word.Length <= 1)
            {
                return true;
            }
           
            else
            {
                if (word[0] != word[word.Length - 1])
                {
                    return false;
                }
                else
                {
                    return PalindromeRecursion(word.Substring(1, word.Length - 2));
                }
            }
        }

        public static void Fibonacci(int len)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            Console.WriteLine($"{a}, {b}");

            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }

        public static void FibonacciRecursion(int a, int b, int counter, int len)
        {
            if(counter <= len)
            {
                Console.WriteLine(a);
                FibonacciRecursion(b, a + b, counter++, len);
            }
        }
    }
}
