using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Implement
{
    class Program
    {
        abstract class Animal
        {
            public abstract void MakeSound();
            public void eating()
            {
                Console.WriteLine("Eating the food...");
            }
        }
        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Woof Woof!..");
            }
        }

        static void Main(string[] args)
        {
            Animal myDog = new Dog();
            myDog.eating();
            myDog.MakeSound();
            Console.ReadLine();
        }
    }
}
