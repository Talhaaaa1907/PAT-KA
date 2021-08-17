using System;

namespace PATİKA_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adınızı Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Yaşınızı Giriniz:");
            string age = Console.ReadLine();
            Console.WriteLine("Adınız: " +name +" " + "Soyadınız: "+ surname +" " + "Yaşınız: "+age);
            Console.ReadLine();
            
        }
    }
}
