using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        // объкет -> класс(экземпляр объекта) -> переменная (экземпляр класса)

        static void Main(string[] args)
        {
            People p = new People();

            p.name = "Test";
            p.age = 10;
            p.weight = 10;
            p.longer = 10;

            People p2 = new People(27, "Igor", 50, 150);

            //(int age, string name) = p2;  Синтаксический сахар

            //if(i < n) z ++;
            //  else z--;

            int i = 3,  j = 4;
            int z = 0;
            z = (i < j) ? z++ : z--; // Синтаксический сахар условия if else (тернарная операция)

            string name;
            int age;

            p2.Deconstruct(out age, out name);

            Console.WriteLine(name);
            Console.WriteLine(age);

            Console.ReadKey();
        }

    }

}
