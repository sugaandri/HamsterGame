using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnimalClasses
{

    class Animal
    {
        public static void Main(string[] args)
        {
            Animal hamster = new Animal();
            hamster.name = "Vurr";
            hamster.weight = 0.3;
            hamster.lifespan = 10;
            hamster.age = 2;
            hamster.PrintBasicInfo();
            

            for (int i = 0; i < 10; i++) 
            {
                hamster.Eat();
                
                if(hamster.weight >= 0.7)
                {
                    while (hamster.weight >= 0.5)
                    {
                        hamster.Exercise();
                    }
                }
                hamster.PrintLifespan();
                Console.WriteLine("\n");
            }

            Console.WriteLine("YOUR HAMSTER DIED!!! We are sorry, we can't help him :| ");
        }

        public string name;
        public int age = 0;
        public double weight = 0;
        public int lifespan = 0;

        public void PrintBasicInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }

        public void PrintLifespan()
        {
            lifespan--;
            Console.WriteLine($"Lifespan: {lifespan}");
        }

        public void Eat()
        {
            Console.WriteLine("Nom, nom");
            weight += 0.2;
        }

        public void Exercise()
        {
            Console.WriteLine("Run, run");
            weight -= 0.1;
        } 
    }

}
