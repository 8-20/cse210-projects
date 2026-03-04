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
        while (i != 0)
        {
            Console.WriteLine("Enter a list of numbers. Enter 0 when finished.");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            i = number;
            numbers.Sort();
            string result = string.Join(", ", numbers);
            Console.WriteLine(result);
            count++;
            sum = sum + i;
            average = (decimal) sum / count;
            if (i > largest)
            {
                largest = i;
            }
            if (i < smallest && i > 0)
            {
                smallest = i;
            }
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Count: {count}");
            Console.WriteLine($"Average: {average:F4}");
            Console.WriteLine($"Largest: {largest}");
            Console.WriteLine($"Smallest: {smallest}");
        }
        
    }
 }
