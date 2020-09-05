using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog fido = new Dog(false, 25);

            fido.Greet();
            fido.Talk();
            fido.Sing();
            fido.Fetch("Stick");

            fido.TouchMe();
            fido.FeedMe();

            Console.WriteLine(fido.ToString());
            Console.WriteLine();

            Robin red = new Robin();
            red.Talk();
            red.Sing();


            Console.ReadKey();

        }
    }
}
