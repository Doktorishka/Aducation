using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        int a = 0;
        // объкет -> класс(экземпляр объекта) -> переменная (экземпляр класса)

        static void Main(string[] args)// "Name", "Age"
        {
            #region Comment
            //People p = new People();

            //p.name = "Test";
            //p.age = 10;
            //p.weight = 10;
            //p.longer = 10;

            //People p2 = new People(27, "Igor", 50, 150);

            ////(int age, string name) = p2;  Синтаксический сахар

            ////if(i < n) z ++;
            ////  else z--;

            //int i = 3,  j = 4;
            //int z = 0;
            //z = (i < j) ? z++ : z--; // Синтаксический сахар условия if else (тернарная операция)

            //string name;
            //int age;

            //p2.Deconstruct(out age, out name);

            //Console.WriteLine(name);
            //Console.WriteLine(age);
            #endregion

            double area1, perimetr1, area2, perimetr2;

            Pryamoygolnik p = new Pryamoygolnik();
            Pryamoygolnik p2 = new Pryamoygolnik(10, 15);

            p.height = 20;
            p.width = 6;

            p.SetArea();
            p.SetPerimetr();

            //p2.SetArea();
            //p2.SetPerimetr();

            double area = p.area;
            //Вспоминай свинью-копилку и молоток
            p.Deconstruct(out area1, out perimetr1);
            p2.Deconstruct(out area2, out perimetr2);

            Console.WriteLine($"Площадь 1-го прямоугольника:{area1}, Периметр первого прямоугольника:{perimetr1}");
            Console.WriteLine($"Площадь 2-го прямоугольника:{area2}, Периметр 2-го прямоугольника:{perimetr2}");

            Console.ReadKey();

        }

        /*
         * ЗАДАЧА ПО ТЕМЕ КЛАССЫ
         * 
            Создать класс Прямоугольник с параметрами длина, ширина, площадь, периметр
            в классе создать два метода (1. Расчет площади, вернуть в класс.площадь, 2. Расчет периметра, вернуть класс.периметр), два конструктора, пустой и с двумя параметрами(длина, ширина)
            

            Pryamoygolnik p = new Pryamoygolnik();
            Pryamoygolnik p2 = new Pryamoygolnik(10,15);

            p.height = 20;
            p.weight = 6;

            p.getArea();
            p.getPerimetr();
            p2.getArea();
            p2.getPerimetr();

            Console.WriteLine(p.area, p.perimetr, p2.area, p2.perimetr);

            * создать деконструкор(не деструктор ~) площади и периметра (void Deconstructor(out int area, out int perimetr))
            Console.WriteLine(area1, perimetr1, area2, perimetr2);
         */

        // ТЕМА 2 - МОДИФИКАТОРЫ ДОСТУПА

        /*
         *  
         *  private - закрытый или приватный компонент класса или структуры. Приватный компонент доступен только в рамках своего класса или структуры.
         *  protected - такой компонент класса доступен из любого места в своем классе или в производных классах. При этом производные классы могут располагаться в других сборках.
         *  private protected - компонент класса доступен из любого места в своем классе или в производных классах, которые определены в той же сборке.
         *  internal -  компоненты класса или структуры доступен из любого места кода в той же сборке, однако он недоступен для других программ и сборок.
         *  protected internal -  совмещает функционал двух модификаторов protected и internal. Такой компонент класса доступен из любого места в текущей сборке и из производных классов, которые могут располагаться в других сборках.
         *  public - общедоступный, доступен вне класса вне сборки
         *  
         *  
         *  ЗАДАНИЕ 2
         *  
         *  Создать класс _______ 
         *  
         *  Конструктор
         *  ______(int input){
         *      this.output = input;
         *  }
         *  
         *  публичную переменную input
         *  приватную переменную output
         *  
         *  публичный метод Print() => Console.WritLine(output);
         *  
         * Main -> Вызов метода 
         *  _______ <name_class> = new _______(input);
         *  
         *  <name_class>.Print();
         * 
         * 
         * Инкапсуляция = сокрытие
         * 
         * 
         * 
         */
    }

    class Pryamoygolnik {
        public double width { get; set; } //{get; set} --   
        public double height { get; set; }
        public double area { get; set; }
        private double perimetr { get; set; }

        public void SetPerimetr() {
            this.perimetr = (width + height) * 2;
        }

        public void SetArea() {
            this.area = width * height;
        }

        public Pryamoygolnik() { }
        public Pryamoygolnik(double width, double height) {
            this.width = width;
            this.height = height;
            this.perimetr = (width + height) * 2;
            this.area = width * height;
        }

        public void Deconstruct(out double area, out double perimetr) {
            area = this.area;
            perimetr = this.perimetr;
        }
    }


    class Stage// internal
    {
        //идентично private string 
        string defaultString = "default";
        //поле доступно исключительно внутри текущего класса
        private string privateString = "private";
        //поле доступно внутри текущего и внутри производного класса текущей сборки
        protected private string privateProtectedString = "protected private";
        //поле доступно внутри текущего и внутри производного класса
        protected string protectedString = "protected";
        // доступно в любом месте текущего проекта
        internal string internalString = "internal";
        // доступно в любом месте текущего проекта
        protected internal string protectedInternalString = "protected internal";
        //доступно в любом месте текущей программы, в любой сборке, в любой программе
        public string publicString = "public";


        //по умолчанию - private 
        void Print() => Console.WriteLine(defaultString);
        //метод доступен в текущем классе
        private void PrintPrivate() => Console.WriteLine(privateString);
        //доступен из текущего класса и производных классов, которые определены в этом же проекте
        protected private void PrintProtectedPrivate() => Console.WriteLine(privateProtectedString);
        // доступен из текущего класса и производных классов
        protected void PrintProtected() => Console.WriteLine(protectedString);
        // доступен в любом месте текущего проекта
        internal void PrintInternal() => Console.WriteLine(internalString);
        // доступно в любом месте текущего проекта
        protected internal void PrintProtectedInternal() => Console.WriteLine(protectedInternalString);
        //доступно в любом месте текущей программы, в любой сборке, в любой программе
        public void PrintPublic() => Console.WriteLine(publicString);
    }



    class ConsumerStage
    {

        public void PrintStage()
        {
            Stage stage = new Stage();

            //Console.WriteLine(stage.defaultString);

            //Console.WriteLine(stage.privateString);

            //Console.WriteLine(stage.privateProtectedString);

            //Console.WriteLine(stage.protectedString);

            Console.WriteLine(stage.internalString);

            Console.WriteLine(stage.protectedInternalString);

            Console.WriteLine(stage.publicString);

            //stage.Print();

            // --- то же самое что и с переменными ---
        }
    }

}
