using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        while (true)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            
            if (int.TryParse(userInput, out int number))
            {
                if (number == 0)
                {
                    break;
                }
                
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        double average = (double)sum / numbers.Count;
        
        int max = numbers[0]; 
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}