using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal() { nombre = "Perro", patas = 4 };
            Animal animalClone = animal.Clone() as Animal;
            animalClone.nombre = "gato";
            Console.WriteLine(animal.nombre);
        }
    }
}
