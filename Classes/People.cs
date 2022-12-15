using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class People
    {
        public int age;
        public string name;
        public double weight;
        public double longer;


        public People() {
            Console.WriteLine("Пустой экземпляр объекта успешно создан");
        }

        public People(int age, string name, double weight, double longer)
        {
            this.age = age;
            this.name = name;
            this.weight = weight;
            this.longer = longer;

            Console.WriteLine($"Hello, my name is {name}. My age is - {age}. Weight - {weight}кг!");
        }

        ~People() { }

        public void Deconstruct(out int age, out string name) {
            age = this.age;
            name = this.name;
        }

            
    }
}
