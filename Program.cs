using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Methods
{
    internal class Program
    {
        static float Abs(float x) // mutlak değer
        {
            return x < 0 ? -x : x; // 0dan küçükse -ile çarp getir değilse direk
        }
        static int Sum(params int[] sayılar)
        { // istediğimiz kadar sayı toplayabiliriz params anahtar kelimesini kullanarak, kullanıcıların metoda değişken sayıda argüman geçirebilmesini sağlayabiliriz.

            int toplam = 0;

            foreach (int sayı in sayılar) 
            {
                toplam += sayı;            
            }

            return toplam;
        }


        static float Carpma(float x, float y) //kaç argüman olacağını biz belirliyoruz
        {
            return x * y;
        }
        static int Toplama(int x, int y) 
        { 
            return x + y;
        
        }
        static void Country(string country = "Turkey") // eğer kullanıcı değer girmezse default yani belirli bir değer atıyorruz
        {
            Console.WriteLine("Nerelisiniz? Türkiyeyse boş bırakın:");
            string inputCountry = Console.ReadLine();

            if (!string.IsNullOrEmpty(inputCountry))
            {
                country = inputCountry;
            }

            Console.WriteLine($"I am from {country}");
        }

        static void Otoyolhızın(int speed=40) // default değer var urda da
        {
            Console.WriteLine($"hızınız: {speed}");
        }

        static void MyInfo(string name,string surname,int age) // argümanları belirliyoruz
        {
            Console.WriteLine($"My full name is {name} {surname} and ı am {age} years old");
        }
        static void Greet(string ad) // tek argüman string name
        {
            Console.WriteLine($"Hello my name is {ad}");
        }

        static void Mymethod()  // herhangi bir argüman almadan çalışıyor methodumuz
        {
            Console.WriteLine("hello world");
        }
        static void Main(string[] args) // kodlarımızı çağırdığımız alan
        {
            Mymethod();
            Mymethod();
            Mymethod();
            Mymethod();
            Greet("ali");
            MyInfo("raman", "yeşil", 30);
            Country();
            Otoyolhızın(80);
            Console.WriteLine(Toplama(5, 6));
            Console.WriteLine(Carpma(3.3f, 6));

            Console.WriteLine(Sum(7,8,9));
            Console.WriteLine(Abs(-3));

            Console.ReadLine();
        }
    }
}
