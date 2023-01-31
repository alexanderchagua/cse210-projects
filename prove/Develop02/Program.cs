using System;
using System.IO;


class Program
  {
    static void Main(string[] args)
    {
    var random = new Random();
    var list = new List<string>{ "How was your day?", "What do you think about your job?", "What do you think of the people you met today?", "What did you learn from the scriptures today?",
                          "What thoughts about family went through your mind today?"
                           };

    int index = random.Next(list.Count);
    var Writes = new List<string>();
    int option = 0;
    do 
    {     Journal journal1 = new Journal();
            journal1._journeyChoice = "Please select one of the following choices:";
            journal1._Option1 = "1.- Write";
            journal1._Option2 = "2.- Display";
            journal1._Option3 = "3.- Save";
            journal1._Option4 = "4.- Load";
            journal1._Option5 = "5.- Quit";

            journal1.Question();
            

            
            Console.Write("What would you like to do?");
            option = Convert.ToInt16(Console.ReadLine());
            
            switch(option){
                case 1:
                    Console.WriteLine(list[index]);
                    DateTime date1 = DateTime.Now;
                    string dateText = date1.ToShortDateString();
                    journal1._Option1 = Convert.ToString(Console.ReadLine());
                    Writes.Add(Convert.ToString(dateText));
                    Writes.Add(journal1._Option1);
                    break;

                case 2:
                    foreach (string i in Writes) 
                    Console.WriteLine(i);
                    break;
                
                case 3:
                    Console.WriteLine("What is the filename?");

                    string casa = "journal.txt";

                    using (StreamWriter outputFile = new StreamWriter(casa,append:true))
                    {   foreach(string line in Writes){outputFile.WriteLine($"{line}");}
                             // You can add text to the file with the WriteLine method
                    
    
                    // You can use the $ and include variables just like with Console.WriteLine
                    
                        };
                    break;
                case 4:
                    string filename = "journal.txt";
string[] lines = File.ReadAllLines(filename);

foreach (string line in lines)
{
    string[] parts = line.Split(",");

    string firstName = parts[0];
    string lastName = parts[1];
}                   
                
            
                
       
                    break;
                case 5:
                    Console.WriteLine("opcion quit");
                    break;
                default:
                    Console.WriteLine("this  is not   one option");
                    break;
      }}
      while (option != 5);}}
    


