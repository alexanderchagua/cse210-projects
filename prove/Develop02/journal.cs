using System;

public class Journal{    
    
    public string _journeyChoice;
    public string _Option1;
    public string _Option2;
    public string _Option3;
    public string _Option4;
    public string _Option5;

    public void Question(){
        Console.WriteLine($"{_journeyChoice}");
        Console.WriteLine($"{_Option1}");
        Console.WriteLine($"{_Option2}");
        Console.WriteLine($"{_Option3}");
        Console.WriteLine($"{_Option4}");
        Console.WriteLine($"{_Option5}");
        }
}