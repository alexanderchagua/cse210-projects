using System;

public class Scripture{

private string _books;
private string _ver;


    public Scripture()
    {
    }

    public Scripture(string book, string verone){
        _books = book;
        _ver = verone;
};


 public string Getscriture()
{
 string write = $"{_books}:{_ver}";
 return write;
 }

    internal void Display()
    {
        throw new NotImplementedException();
    }
}
