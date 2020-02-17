using System;

namespace InheritanceOverride.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CityDerivedClass a = new CityDerivedClass();
            a.ReturnZipcodeVirtual();
            a.ReturnZipcodeAbstract();
        }
    }


    abstract class CityBaseClass
    {

        public int zipcode= 99163;

        public virtual void ReturnZipcodeVirtual()
        {
            Console.WriteLine("Virtual CityBase Class. zipcode : "+zipcode);

        }

        public abstract void ReturnZipcodeAbstract();
    }
    class CityDerivedClass : CityBaseClass
    {
        public override void ReturnZipcodeVirtual()
        {
            Console.WriteLine("Virtual CityDerived Class. zipcode : "+this. zipcode);
        }

        public override void ReturnZipcodeAbstract()
        {
            Console.WriteLine("abstract CityDerived Class. zipcode : " + zipcode);


        }

    }
}
