using System;

public class relaxationMethods{
     private string _time = "";
     private string _msgWelcome = "";
     private string _msgFinal = "";
    public string _animacion  = "";

    public string _RandomList  = "";

    public relaxationMethods(string time){
        _time = time;
    }

    public relaxationMethods(string welcome, string Final ){
        _msgWelcome = welcome;
        _msgFinal = Final;

    }
    

    public  void generRndList(){
        Random random = new Random();
        int index = random.Next( _RandomList.Count );
        string randomString = _RandomList[ index ];
   
    }

    public void MensajeBienvenida(string welcome){
        Console.WriteLine(welcome);
    }

    public void MensajeFinal(string Final){
        Console.WriteLine(Final);
    }
    

}