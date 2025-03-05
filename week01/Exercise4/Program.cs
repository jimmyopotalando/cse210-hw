using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        
        
        double average = (numbers.Count > 0) ? (double)sum / numbers.Count : 0;

        
        int largestNumber = int.MinValue;
        foreach (int num in numbers)
        {
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }

        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

        
        
        int smallestPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        
        numbers.Sort();

        
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }

        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
