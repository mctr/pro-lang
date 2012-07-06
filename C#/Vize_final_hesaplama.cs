using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
class Program
{
static void Main(string[] args)
{
int viz = new int();
int fnl= new int();
double ort = new double();
Console.Write("Ortalamanızı hesaplayıp sonucu söyleyen program \n\n");
Console.Write("Vize notunuzu giriniz:");
viz = Convert.ToInt32(Console.ReadLine());
Console.Write("\nFinal notunuzu giriniz:");
fnl = Convert.ToInt32(Console.ReadLine());
ort = (viz * 0.4) + (fnl * 0.6);
if (fnl < 50)
{
    Console.Write("\nOrtalamanız {0} malesef kaldınız.Çünkü final notunuz 50 ' den düşük..Hayırlısı artık :(", ort);
}
else if (ort >= 60)
{
    Console.Write("Ortalamanız {1} tebrikler geçtiniz..malesef hediyemiz yok:)", ort);
}
else if (ort < 60) 
{
    Console.Write("\nOrtalamanız {0} malesef kaldınız..Hayırlısı artık :(", ort);
}
//Console.Write("\nSonuc = {0}", ort);
Console.ReadKey();
}
}
}
