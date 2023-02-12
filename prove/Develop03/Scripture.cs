using System;

public class Scripture{

private string _book;
private string _ver;

private string _paragra;


    public Scripture(string book, string verone){

        _book = book;
        _ver = verone;
}
    public Scripture(string book, string vertwo){

        _book = book;
        _ver = vertwo;
}


 public string Getscriture()
{
 string write = $"{_book}:{_ver}";
 return write;
 }




}
