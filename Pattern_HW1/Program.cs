using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Фабричный метод(Factory Method)

namespace Pattern_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev1 = new PanelDeveloper("Панель Строй Групп");
            House house1 = dev1.Create();

            Developer dev2 = new WoodDeveloper("Древесина Строй Групп");
            House house2 = dev2.Create();

            Console.ReadLine();
        }
    }

    // Создаем абстрактный родительский класс "Строительная Компания" который делится на строителей "панельных" и "деревянных" домов(через соответсвующие
    // классы) и задаем ему в свойствах имя
    abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }

        // фабричный метод

        abstract public House Create();

    }
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n): base(n)
        {

        }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        {

        }

        public override House Create()
        {
            return new WoodHouse();
        }
    }



    // Создаем абстрактный родительский класс "Дом" от которого наследуются "панельный" и "деревянный" дома 
    abstract class House
    {

    }
    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Panel house constructed");
        }
    }
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Wood house constructed");
        }
    }
}




//Формальное определение паттерна на языке C# может выглядеть следующим образом:

//abstract class Creator
//{
//    public abstract Product FactoryMethod();
//}

//class ConcreteCreatorA : Creator
//{
//    public override Product FactoryMethod() { return new ConcreteProductA(); }
//}

//class ConcreteCreatorB : Creator
//{
//    public override Product FactoryMethod() { return new ConcreteProductB(); }
//}

//abstract class Product
//{ }

//class ConcreteProductA : Product
//{ }

//class ConcreteProductB : Product
//{ }

