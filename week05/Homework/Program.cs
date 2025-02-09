using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Prosper", "Algebra");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Panashe", "Geometry", "5", "10-12");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Zvidzai", "Chimurenga 1", "Pakatangira Chimurenga");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}