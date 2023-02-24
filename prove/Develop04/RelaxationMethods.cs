using System;

public class RelaxationMethods{
     private DateTime _time = new DateTime();
     private Random _RandomList = new Random();
     private string _msgWelcome;
     private string _msgEnd;
    private string _animacion;
    private object ramdom;

    public RelaxationMethods(string msgwelcome, string msgEnd){
       
        _msgWelcome = msgwelcome;
        _msgEnd = msgEnd;
    }
    public string getShowWelcomeMessage(){
        return _msgWelcome;
    }
    public string getShowEndMessage(){
        return _msgEnd;
    }


    public string ShowAnimation(){
        return _animacion;
    }

    public List<string> Getrlist(){
        List<string> ramdom = new List<string>();
       
      return ramdom;
    }
 
     public strin tMenu(){
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing  activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");  
     }   
        
        
        }

 

   



   
