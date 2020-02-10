using System;
using singleton;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test.Get().HelloWorld();

            Test t = new Test();
            t.Printf("Hello world 2");


            Bumjin.Instantiate().printf("WOW");

            Bumjin test = new Bumjin();
            test.printf("works");
        }

    }
    class Test
    {
        private static Test instance = null;

        public static Test Get()
        {
            if (instance == null)
                instance = new Test();

            return instance;
        }

        public void HelloWorld()
        {
            Console.WriteLine("Hello, World from function");
        }

        public void Printf(string text)
        {
            Console.WriteLine(text);
        }
    }

    class Singleton
    {
        private static Singleton _instance;

        public static Singleton instantiate()
        {
            if (_instance == null)
                _instance = new Singleton();

            return _instance;
        }
    }

    class Bumjin
    {
        private static Bumjin identity = null;

        public static Bumjin Instantiate()
        {
            if (identity == null)
                identity = new Bumjin();

            return identity;
        }

        public void printf(string input)
        {
            Console.WriteLine(input);
        }



    }


    public abstract class Pizza
    {
        public abstract Decimal GetPrice();
        public enum PizzaType
        {
            veggie , seafood , meat 
        }
        public static Pizza PizzaFactory(PizzaType pizzatype)
        {
            switch (pizzatype)
            {
                case PizzaType.veggie:
                    return new veggiePizza();
                case PizzaType.seafood:
                    return new seafoodPizza();
                case PizzaType.meat:
                    return new meatPizza();
            }
        }
    
    }
    public class veggiePizza : Pizza
    {
        private decimal price = 11.5M;
        public override decimal GetPrice()
        {
            return price;
        }
    }
    public class seafoodPizza : Pizza
    {
        private decimal price = 13.5M;
        public override decimal GetPrice()
        {
            return price;
        }
    }
    public class meatPizza : Pizza
    {
        private decimal price = 12.5M;
        public override decimal GetPrice()
        {

            return price;
        }
    }
}