using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Horse : Animal, IDomesticated, IRideable
    {
        public void FeedMe()
        {
            Console.WriteLine("Awesome food thank you.");
        }

        public void RideMe()
        {
            Console.WriteLine("Hop on and go somewhere");
        }

        public void TouchMe()
        {
            Console.WriteLine("Scratch me on my back");
        }
    }
}
