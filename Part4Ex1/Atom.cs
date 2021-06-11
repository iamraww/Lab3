using System;
using System.Xml;

namespace Part4Ex1
{
    public class Atom
    {
        public int Number { get; set; }
        public string Symbol { get; set; }
        public string FullName { get; set; }
        public float Weight { get; set; }

        public bool Accept()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter atomic number :");
                    if (int.TryParse(Console.ReadLine(), out var number))
                    {
                        Number = number;
                        if (Number == 0)
                        {
                            return false;
                        }
                    }
                    break;
                }

                Console.WriteLine("Enter symbol :");
                Symbol = Console.ReadLine();
                Console.WriteLine("Enter full name :");
                FullName = Console.ReadLine();
                while (true)
                {
                    Console.WriteLine("Enter atomic weight :");
                    if (int.TryParse(Console.ReadLine(), out var number))
                    {
                        Weight = number;
                        break;
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Display()
        {
            Console.WriteLine($"{Number} {Symbol} {FullName} {Weight}");
        }
    }
}