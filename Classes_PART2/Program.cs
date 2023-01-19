using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_PART2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal= new Animal();

            Dog dog = new Dog(false, false, 4);



            Corgi corgi = new Corgi();

            animal.isEatMeat = false;
            dog.lenght = 10;

            corgi.hvost = true;
        }

        //Animal -> Dog -> Corgi

        class Animal { 
            public bool shrest { get; set; }
            public decimal weight { get; set; }
            public decimal lenght { get; set; }
            public int countLap { get; set; }
            public bool isEatMeat { get; set; }

            public Animal() { }
            public Animal(bool sherst, int lap) { 
                this.shrest = sherst;
                this.countLap = lap;
            }
        }

        class Evolution { 
            bool isPeticantrop { get; set; }
        }

        class Dog : Animal {
            
            public bool hvost { get; set; }

            public Dog() { }
            public Dog(bool hvost, bool sherst, int lap) : base(sherst, lap) {
                this.hvost = hvost;
            }
        }

        class Cat : Animal { 
            public bool may { get; set; }

            public Cat() { }
        }

        class Corgi : Dog {
            int ushi { get; set; }
        }


        sealed class User {
            public static string loginUser = "123";
            public static string passwordUser = "123";
        }

        //class IMUser : User {
        //    private string login { get; set; }
        //    private string password { get; set; }
        //    void Kraja() {
        //        login = loginUser;
        //        password = passwordUser;
        //        /// Выписка в файл
        //    }
        //}


        /*
         Задачка 

            У нас есть класс транспорт
            У него есть метод побибикать -> Вывод слова БИП!
            у него есть переменные - кол-во колес, кол-во сидений
            
            Есть класс машина, наследуется от транспорта. Побибикай в машине.
            Метод - спустило колесо
            
            Есть класс лайнер, наследуется от транспорта. Есть параметр наименование
        
            Выведи, что ЭТОТ(Имя) лайнер не бибикает, а гудит
         
         */
    }
}
