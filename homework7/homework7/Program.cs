using System;
using System.Linq;
using System.Security.Cryptography;

namespace Week7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //მოცემულია კვადრატი და კვადრატში ჩახატული წრე . ამ წრეში
            //ჩახატულია კიდევ ერთი სხვა კვადრატი.
            //დაწერეთ პროგრამა რომელიც იპოვის სხვაობას დიდი და პატარა კვადრატის
            //ფართობებს შორის.
            Console.WriteLine("task 1: ");
            Console.WriteLine("Enter Radius: ");
            int radius = int.Parse(Console.ReadLine());
            var S1 = radius * radius * 2;
            var S2 = radius * 2 * radius * 2;
            var subtraction = S2- S1;
            Console.WriteLine($"Difference between two squares is: {subtraction}");
            #endregion

            #region Task 2
            //დაწერეთ პროგრამა რომელიც შეამოწმებს ამოუვიდა თუ არა იუზერს ჯეკპოტი
            Console.WriteLine("task 2: ");
            Console.WriteLine("Enter number of Jackpot symbols");
            int size = int.Parse(Console.ReadLine());
            char[] input = new char[size];
            Console.WriteLine($"Enter {size} characters");
            for (int i = 0; i < size; i++)
            {
                input[i] = char.Parse(Console.ReadLine());
            }
            bool allIdentical = input.Skip(1).All(c => c == input[0]);
            if (allIdentical)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            #endregion

            #region Task 3
            //დაწერეთ პროგრამა რომელიც დათვლის ჯამში რამდენი ქულა დააგროვა საფეხბურთო გუნდმა
            //Input: [won - 3, tie - 1, lose - 1]
            Console.WriteLine("task 3: ");
            int[] results = { 3, 1, 0 };
            int won = 3;
            int tie = 1;
            int lose = 0;
            int totalScore = results[0] * won + results[1] * tie + results[2] * lose;
            Console.WriteLine($"Total score: {totalScore}");
            #endregion

            #region Task 4

            //დაწერეთ პროგრამა რომელიც დათვლის თანამშრომლის შემოსავალს 1 კვირის განმავლობაში.
            Console.WriteLine("task 4: ");
            int[] whours = { 5, 8, 8, 8, 8, 8, 8 };
            int stime = 8;
            int spay = 10;
            int overtimepay = 5;
            int totalpay = 0;
            for(int i = 0; i < whours.Length-2; i++) 
            {
                if (whours[i] <= stime)
                    totalpay += whours[i]*spay;
                else
                    totalpay += whours[i]*spay + (whours[i] - stime)*overtimepay;
            }
            for(int i = whours.Length-2; i < whours.Length; i++)
            {
                totalpay+= whours[i]*spay*2;
            }
            Console.WriteLine(totalpay);
            #endregion

            #region Task 5
            //გიორგი მარათონისთვის ემზადება ის ყოველ დღიურად ვარჯიშობს.შეამოწმეთ აქვს თუ არა გიორგის პროგრესი, ყოველ დღიურად და გამოიტანეთ იმ დღეების რაოდენობა როდესაც მან შედეგი გააუმჯობესა.
            Console.WriteLine("task 5: ");
            Console.WriteLine("(-------------): ");
            #endregion

            #region Task 6
            //დაწერეთ პროგრამა რომელიც ამობეჭდავს N სიგრძის მქონდე ელემენტს მასივიდან.
     
            Console.WriteLine("task 6: ");
            int N = 7;
            string[] arr = { "Hello", "World" , "Programming", "communication" };
            var result = arr.Where(s => s.Length >= N).ToArray();
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
            #endregion

           
        }
    }
}