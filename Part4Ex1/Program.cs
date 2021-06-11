using System;

namespace Part4Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var atoms = new Atom[10];
            var count = 0;
            Console.WriteLine("Atomic Information");
            Console.WriteLine("==================");
            while (true)
            {
                if (count >= 10)
                {
                    break;
                }

                var atom = new Atom();
                var result = atom.Accept();
                if (result)
                {
                    atoms[count] = atom;
                    count++;
                } else if (atom.Number == 0)
                {
                    break;
                }
            }

            Console.WriteLine("No Sym Name Weight");
            Console.WriteLine("------------------------------------");
            for (int i = 0; i < count; i++)
            {
                atoms[count].Display();
            }
        }
    }
}