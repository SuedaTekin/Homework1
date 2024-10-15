using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Homework1
{
    static void Main()
    {
        Console.WriteLine("Lütfen TC kimlik numarasını giriniz:");
        string tcKimlikNo = Console.ReadLine();

        if (TcKimlikNoKontrol(tcKimlikNo))
        {
            string ilkBesKarakter = TcKimlikNoIlkBesKarakter(tcKimlikNo);
            Console.WriteLine("TC kimlik numarasının ilk 5 karakteri: " + ilkBesKarakter);
        }
        else
        {
            Console.WriteLine("Geçersiz TC kimlik numarası.");
        }
    }
    static bool TcKimlikNoKontrol(string tcKimlikNo)
    {
        if (tcKimlikNo.Length !=11)
        {
            return false;
        }
        if(!tcKimlikNo.All(char.IsDigit))
        {
            return false;
        }
        return true;
    }
    static string TcKimlikNoIlkBesKarakter(string tcKimlikNo)
    {
        return tcKimlikNo.Substring(0, 5);
    }
}
