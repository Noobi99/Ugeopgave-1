using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ugeopgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laver en ny liste, skal instantieres med en node
            var list = new LinkedList(new Node(){Data = 10}); // 0

            // Tilføjer nogle nodes
            list.Add(20); // 1
            list.Add(30); // 2 
            list.Add(40); // 3
            list.Add(50); // 4

            // Fjerner og får det nye element på plads 3
            list.Remove(3);
            var result = list.Get(3);
            Console.WriteLine(result);

            // Længden printes
            var length = list.GetCount();
            Console.WriteLine("Length: " + length);

            // IsEmpty metode bruges
            //Console.WriteLine(list.IsEmpty());

            // InsertAt metode bruges
            list.InsertAt(0, 37);
            Console.WriteLine(list.Get(0));

            Console.ReadLine();
        }
    }
}