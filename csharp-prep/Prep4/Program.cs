using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int sum = 0;
        int new_number = -1;
        do 
        {
            Console.Write("Enter number: ");
            string number_str = Console.ReadLine();
            new_number = int.Parse(number_str);
            if (new_number != 0)
            {
                numbers.Add(new_number);
            }
            
        } while (new_number != 0);

        foreach (int number in numbers)
        {
            sum += number;
        }

        float average = ((float)sum) / numbers.Count;

        int max = 0;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}