using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int count = 0;
        decimal average = 0.0000M;
        int largest = 0;
        int smallest = 10000;
        int i = 1;
        Console.WriteLine("Enter a list of numbers. Enter 0 when finished.");
        while (i != 0)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
                i = number;
                numbers.Sort();
                string result = string.Join(", ", numbers);
               // Console.WriteLine(result);
                count++;
                sum = sum + i;
                average = (decimal)sum / count;
                if (i > largest)
                {
                    largest = i;
                }
                if (i < smallest && i > 0)
                {
                    smallest = i;
                }
            }
            else
            {
                Console.WriteLine($"The sum is: {sum}");
               // Console.WriteLine($"Count: {count}");
                Console.WriteLine($"The average is: {average:F4}");
                Console.WriteLine($"THe largest number is: {largest}");
                Console.WriteLine($"The smallest positive number is: {smallest}");
                Console.WriteLine($"The sorted list is: ");
                foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }
                i = 0;
            }       
        }
        
    }
 }
