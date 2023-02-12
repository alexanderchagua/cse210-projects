using System;
class Program
{
    static void Main(string[] args){
        Console.Clear();
        Random ran = new Random();
        string scripture = "se conoce como la vida antes de la muertes pero esto esta bien";


        string[] scrip = scripture.Split(",");
        List<string> asd = new List<string>(scrip);
        List<int> indexTracker = new List<int>();
        string value = "";
        int rn = 0;
        int indexUsados = 24;
        int i = 0;

        do{
            Console.Clear();
            Console.WriteLine("2 nefi 2:8"+ string.Join("",asd));
            Console.WriteLine("\n PRESS ENTER TO CONTINUE OR TYPE 'QUIT TO FINSH");

            value = Console.ReadLine();
            if( value == "" || value == null ){
                while(i<2){
                string randonport = asd[ran.Next(0,asd.Count())];
                i++;};

                rn = ran.Next(0, asd.Count());

                int aux = asd[rn].Length;
                string str = new string('_', aux);
                asd[rn] = str;

                indexUsados = rn;
                indexTracker.Add(indexUsados);

            }
        }while(value != "quit");
    }
    
    
    }