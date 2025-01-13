using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        string userinput = Console.ReadLine();
        int grade = int.Parse(userinput);
        string letter = "";

        //determining letter for each grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
            
        // printing the letter grade
        Console.WriteLine($"Your letter grade is: {letter}");
            
        // checking if the student passed and display the approprite message
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations. You passed the course!");
        }
        else
        {
        Console.WriteLine("Keep working hard. You'll do better next time!");
        }
        
    }
}