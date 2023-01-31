using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Классы;

namespace Классы
{
    public class Tel
    {

        public int day;
        public int dayz
        {
             get {
                while (day <= 0 || day >= 8)
                {
                    Console.WriteLine("Введите правильно день недели разговора");
                    day = int.Parse(Console.ReadLine());
                }
                return day; 
             }
             set { day = value; }
             
        }
        
        public double time;
        public double cost;
        public double Cost()
        {
            
            Console.WriteLine("Введите день недели разговора");
            day = int.Parse(Console.ReadLine());
            dayz = day;
            Console.WriteLine("Введите время разговора");
            time = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите стоимость за 1 минуту");
            cost = double.Parse(Console.ReadLine());
            double itog;
            if (dayz == 6 || dayz == 7) itog = time * cost * 0.9;
            else itog = time * cost;
            return itog;
        }
    }
    
    public class Sq
    {
        public void Nums()
        {
            int x;
            for (int i = 1; i <= 10; i++)
            {
                x = (int)Math.Pow(i, 2);
                Console.WriteLine($"{i} - {x}");
                Wait pr = new Wait();
                pr.Vivod(x);
            }
        }
    }
    public class Wait
    {
        public void Vivod(int sr)
        {
            if (sr > 25) Console.WriteLine("Квадрат числа больше 25!");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tel t = new Tel();
                Console.WriteLine(t.Cost());
                Sq square = new Sq();
                square.Nums();
            }
            catch 
            {
                Console.WriteLine("Можно вводить только числа");
            }























            Console.ReadKey();

        }
    }
}

