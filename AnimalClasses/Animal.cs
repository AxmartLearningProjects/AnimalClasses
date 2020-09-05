using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    abstract class Animal
    {

        public bool IsAlive { get; set; }
        public int Weight { get; set; }

        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }

        public Animal(bool isAlive, int weight)
        {
            Console.WriteLine("Animal Constructor");

            IsAlive = isAlive;
            Weight = weight;

        }

        public void Greet()
        {
            Console.WriteLine("Animal says hello");
        }

        public void Talk()
        {
            Console.WriteLine("Animal is talking");
        }

        public void Sing()
        {
            Console.WriteLine("Animal is singing");
        }

        public string ToString()
        {

            return $"Status : {IsAlive}  Weight : {Weight}";

        }


    }
}
