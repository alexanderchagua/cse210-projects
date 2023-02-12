using System;
class Program
{
    static void Main(string[] args){
        Scripture scr = new Scripture("moroni 10:20","Wherefore, there must be afaith; and if there must be faith there must also be hope; and if there must be hope there must also be charity.");
        Console.WriteLine(scr.Getscriture());


        Rndscripture myrdn = new Rndscripture();
        myrdn._name = "BOOK IS:";

        myrdn._scriture.Add(scr);

        myrdn.Display();

    }

    
    }