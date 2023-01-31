using System;

public class Fraction
{
    private int _top;
    private int _bottom; 

   public Fraction()
   {
    _top = 1;
    _bottom = 1;

   }
   public Fraction(int number)
   {
    _top = number;
    _bottom = 1;
   }
   public Fraction(int number1, int number2)
   {
    _top =  number1;
    _bottom = number2;
   }

 public string GetFractionString()
{
 string write = $"{_top}/{_bottom}";
 return write;
 }

  public double GetDecimalValue()
 {
   return (double)_top / (double)_bottom; 
 }
}

