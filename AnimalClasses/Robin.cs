using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Robin : Animal , IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I have to fly away , bye");
        }

        public void Sing()
        {
            Console.WriteLine("Chirp Chirp");

        }

    }
}
