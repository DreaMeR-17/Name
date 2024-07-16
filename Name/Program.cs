using System;

namespace Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol;

            string name;
            string middleLine;
            string frame = "";

            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();

            Console.WriteLine("Введите символ для рамки: ");
            symbol = Console.ReadKey(true).KeyChar;

            middleLine = symbol + name + symbol;

            for (int i = 0; i < middleLine.Length; i++)
            {
                frame += symbol;
            }

            Console.WriteLine(frame + "\n" + middleLine + "\n" + frame);
        }
    }
}
