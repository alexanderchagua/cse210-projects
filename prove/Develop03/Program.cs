
using System;
class Program
{
    static void Main(string[] args){
        Console.Clear();
        Random ran = new Random();
        string scripture = "Wherefore, there must be afaith; and if there must be faith there must also be hope; and if there must be hope there must also be charity.";


        string[] scrip = scripture.Split(",");
        List<string> asd = new List<string>(scrip);
        List<int> indexTracker = new List<int>();
        string value = "";
        int rn = 0;
        int indexUse = 24;
        int i = 0;

        do{
            Console.Clear();
            Console.WriteLine("moroni 10:20"+ string.Join("",asd));
            Console.WriteLine("\n PRESS ENTER TO CONTINUE OR TYPE 'QUIT TO FINSH");

            value = Console.ReadLine();
            if( value == "" || value == null ){
                while(i<2){

    
                {
                string randonport = asd[ran.Next(0,asd.Count())];
                i++;};

                rn = ran.Next(0, asd.Count());

                int aux = asd[rn].Length;
                string str = new string('_', aux);
                asd[rn] = str;

                indexUse = rn;
                indexTracker.Add(indexUse);

            }
        }
    }while(value != "quit");
    
    
    }}