using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle yazınız:");
            string girdi = Console.ReadLine();
            ArrayList sesliDizi = new ArrayList{'a','e','ı','i','o','ö','u','ü'};
            ArrayList girdininSeslileri = new ArrayList();

            foreach(char c in girdi){
                foreach(char sesli in sesliDizi){
                    if(c == sesli){
                        girdininSeslileri.Add(c);
                    }
                }
            }

            girdininSeslileri.Sort();
            foreach(var sesli in girdininSeslileri){
                Console.WriteLine(sesli);
                
            }
            Console.ReadLine();
        }
    }
}
