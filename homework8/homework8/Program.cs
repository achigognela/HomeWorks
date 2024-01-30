using System;
using System.Collections.Generic;
using System.Linq;

namespace Week8
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        //1.დაწერეთ ფუნქცია რომელიც პარამეტრად მიიღებს a, b, n
        //a.a - მინიმალური რიცხვი
        //b.b - მაქსიმალური რიცხვი
        //c.n - ხარისხი რომელშიც უნდა ავიყვანოთ რიცხვები
        //იპოვეთ ყველა რიცხვი a - &gt; b შუალედში რომლის n ხარისხი
        //მოთავსებულია ამ ინტერვალში

        static void Task1(int a, int b, int n)
        {

            var counter = 0;
            for (int i = Convert.ToInt32(Math.Pow(a, 1.0 / n)); i <= Convert.ToInt32(Math.Pow(b, 1.0 / n)); i++)
            {
                if (Math.Pow(i, n) >= a && Math.Pow(i, n) <= b)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        //2.დაეხმარეთ პატარა ნიკუშას წინდების წყვილების პოვნაში.წყვილები
        //აღნიშნულია ორი ერთნაირი სიმბოლოთი.
        static void Task2(string a)
        {

            Dictionary<char, int> sockCount = new Dictionary<char, int>();

            foreach (char sock in a)
            {
                if (sockCount.ContainsKey(sock))
                {
                    sockCount[sock]++;
                }
                else
                {
                    sockCount[sock] = 1;
                }
            }

            int pairCount = 0;

            foreach (var count in sockCount.Values)
            {
                pairCount += count / 2;
            }

            Console.WriteLine(pairCount);
        }
        //3.დაწერეთ ფუნქცია რომელიც დააბრუნებს ყველა გრძელ საერთო
        //ბოლოსართს ორ სტრინგს შორის .
        static string Task3(string str1, string str2)
        {

            int minLength = Math.Min(str1.Length, str2.Length);
            string maxsuffix = "";
            for (int i = 1; i <= minLength; i++)
            {
                if (str1[str1.Length - i] == str2[str2.Length - i])
                {
                    maxsuffix = str1[str1.Length - i] + maxsuffix;
                }
                else
                    break;
            }

            return maxsuffix;
        }
        //4.დაწერეთ ფუნქცია რომელიც მიიღებს Generic ტიპის ლისტს, შეამოწმებს
        //გადაცემული ლისტის ტიპს და შემოწმების შემდეგ ჩაატარებს შემდეგ ოპერაციებს.
        //თუ გადაეცემა სტრინგების ლისტი -დაბეჭდავს ყველა სტრინგს UpperCase - ში
        //თუ გადაეცემა ნებისმიერი რიცხვითი ტიპის მასივი(int) -დაითვლის მათ ჯამს
        //თუ გადაეცემა Bool - გამოიტანს ლისტის პირველ, ბოლო და შუაში მყოფ ელემენტს.
        static void Task4<T>(List<T> inputList)
        {


            Console.WriteLine($"Input List Type: {typeof(T)}");

            if (typeof(T) == typeof(string))
            {
                // Case 1: List of strings
                List<string> stringList = inputList.Cast<string>().ToList();
                stringList.ForEach(s => Console.WriteLine(s.ToUpper()));
            }
            else if (typeof(T) == typeof(int))
            {
                // Case 2: List of ints
                List<int> intList = inputList.Cast<int>().ToList();
                int sum = intList.Sum();
                Console.WriteLine($"Sum of Integers: {sum}");
            }
            else if (typeof(T) == typeof(bool))
            {
                // Case 3: List of bools
                List<bool> boolList = inputList.Cast<bool>().ToList();
                Console.WriteLine($"First Element is {boolList.First()}");
                Console.WriteLine($"Last Element is {boolList.Last()}");
                Console.WriteLine($"Middle Element is {boolList[boolList.Count / 2]}");
            }
            else
            {
                Console.WriteLine("Unsupported type. Please provide a list of strings, ints, or bools.");
            }

            Console.WriteLine();
        }
        //5.რეკურსია
        //დაწერეთ ფუნქცია რომელიც დაბეჭდავს რიცხვში შემავალ ყოველ სიმბოლოს.
        static string Task5(string a)
        {
            
            if (string.IsNullOrEmpty(a))
            {
                return string.Empty;
            }

            int firstDigit = int.Parse(a[0].ToString());
            string remainingDigits = a.Substring(1);

            if (string.IsNullOrEmpty(remainingDigits))
            {
                return firstDigit.ToString();
            }
            else
            {
                return firstDigit + " - " + Task5(remainingDigits);
            }

        }
       
        }
    }
