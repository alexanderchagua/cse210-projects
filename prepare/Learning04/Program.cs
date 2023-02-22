using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment asig = new Assignment("alexander","multiplicar");

        Console.WriteLine(asig.GetSummary());


        MathsAssignment math = new MathsAssignment("ALEXANDER CHAGUA", "FRACTION","7.8", "7.2");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment write = new WritingAssignment("alexander chagua","travel","my new world");
        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInformation());
    }
}