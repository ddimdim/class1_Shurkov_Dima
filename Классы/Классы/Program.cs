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

    public class Wait
    {
        delegate int schet(int i, int j);
        public class Sq
        {

            public double kvad()
            {
                for (int i = 1; i <= 10; i++)
                {
                    return (Math.Pow(i, 2));
                }

            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Tel t = new Tel();
            Console.WriteLine(t.Cost());
            //Sq sq = new Sq();
            //Console.WriteLine(sq.sq());



































            Console.ReadKey();

        }
    }
}

