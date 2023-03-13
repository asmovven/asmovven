using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
            public class Izdel
            {
            public string Name { get; set; }
            public string Shifr { get; set; }
            public int Kolvo { get; set; }
        public Izdel(string name, string shifr, int kolvo)
        {
            Name = name;
            Shifr = shifr;
            Kolvo = kolvo;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Создаем экземпляр класса Check с помощью конструктора с параметрами
            //Izdel izdel = new Izdel("Stul", "123xx4", 100);

            //// Выводим информацию о чеке
            //Console.WriteLine("Name: " + izdel.Name);
            //Console.WriteLine("Shifr: " + izdel.Shifr);
            //Console.WriteLine("Kolvo: " + izdel.Kolvo);
            
            //Console.ReadKey();

        }
    }
}