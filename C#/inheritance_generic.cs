using System;
using System.Collections;
using System.Collections.Generic;

namespace InheritanceOverride.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CityDerivedClass a = new CityDerivedClass();
            a.ZipcodeAbstractBase();
            a.ZipcodeVirtualBase();

            PersonalDetails person3 = new PersonalDetails("C", "CCC", 1, 50, 170);
            PersonalDetails person2 = new PersonalDetails("B", "BBB",0, 20, 165);
            PersonalDetails person1 = new PersonalDetails("A", "AAA",0, 28, 185);
            
            PersonalDetails person5 = new PersonalDetails("E", "EEE",1, 70, 170);
            PersonalDetails person4 = new PersonalDetails("D", "DDD",1, 30, 171);
            PersonalDetails person6 = new PersonalDetails("F", "FFF", 1, 21, 180);

            List<PersonalDetails> lst = new List<PersonalDetails>();

           
            lst.Add(person3);
            lst.Add(person2);
            lst.Add(person1);
            lst.Add(person5);
            lst.Add(person4);
            lst.Add(person6);

            Console.WriteLine("-------------original----------------\n\n\n");
            int i = 0;
            ////2-1 printing all information 
            for (i = 0; i < lst.Count; i++)
            {
                lst[i].getInfo();// output all info
            }



            //filtering based on age>35
            for (i = lst.Count-1; i >=0; i--)
            {
                if (lst[i].GetAge() > 35)
                {
                    lst.RemoveAt(i);
                } 
            }


            Console.WriteLine("-------------after taking out over 35----------------\n\n\n");
            for (i = 0; i < lst.Count; i++)
            {
                lst[i].getInfo();
            }

            //sorting based on first character of first name.

            List<PersonalDetails> backupList = new List<PersonalDetails>();
        
            for( i = 0; i < lst.Count; i++) {
                backupList.Add(lst[i]);
            }
            // copy original to backup.

            List<PersonalDetails> arListSortedFirstName = new List<PersonalDetails>();
            // sorted form will be stored in this new list

            while (backupList.Count != 0)
            {
                int store = -1;
                char tem = backupList[0].GetFirstName()[0];
                for (i = 0; i < backupList.Count; i++)
                {
                    if (tem >= backupList[i].GetFirstName()[0])
                    {
                        tem = backupList[i].GetFirstName()[0];
                        store = i;
                    }
                }
                if (store >= 0)
                {
                    arListSortedFirstName.Add(backupList[store]);
                    backupList.RemoveAt(store);

                }
            }

            Console.WriteLine("------------ sorted based on first name-----------------\n\n\n");
            for (i = 0; i < arListSortedFirstName.Count; i++)
            {
                arListSortedFirstName[i].getInfo();
            }



            for (i = 0; i < arListSortedFirstName.Count; i++)
            {    // add sorted list to existing 
                lst.Add(arListSortedFirstName[i]);

            }


            Console.WriteLine("--------------add sorted list to existing list---------------\n\n\n");
            for (i = 0; i < lst.Count; i++)
            {
                lst[i].getInfo();
            }


            for (i = lst.Count-1; i>=0; i--)     //take out male
            {
                
                if (lst[i].GetSex() == 0)
                {
                    lst.RemoveAt(i);

                }
                
            }
            Console.WriteLine("------------After Takeout male-----------------\n\n\n");
            for (i = 0; i < lst.Count; i++)
            {
                lst[i].getInfo();
            }
        }
    }

    


    abstract class CityBaseClass
    {
        public int zipcode = 99163;
        public virtual void ZipcodeVirtualBase()
        {
            Console.WriteLine("zipcodeVirtualBase : " + zipcode);
        }
        public abstract void ZipcodeAbstractBase();
    }

    class CityDerivedClass : CityBaseClass
    {
        public override void ZipcodeVirtualBase()
        {
            Console.WriteLine("zipcodeVirtualDerived : " + zipcode);
        }
        public override void ZipcodeAbstractBase()
        {
            Console.WriteLine("zipcodeAbstractDerived : " + zipcode);
        }

    }

    class PersonalDetails
    {
        private string firstName;
        private string lastName;
        private int age;
        private int sex; // male =0  female = 1
        private int height;
        public PersonalDetails(string firstNameInput, string lastNameInput, int sexInput ,int ageInput, int heightInput)
        {
            firstName = firstNameInput;
            lastName = lastNameInput;
            sex = sexInput;
            age = ageInput;
            height = heightInput;
            Console.WriteLine("Person Detail set up for  : " + firstName + " " + lastName+ " \n");

        }

        public int GetAge()
        {
            return age;
        }
        public int heightAge()
        {
            return height;
        }
        public string GetFirstName()
        {
            return firstName;
        }
        public string GetLastName()
        {
            return lastName;
        }
        public int GetSex()
        {
            return sex;
        }


        public void getInfo()
        {
            Console.WriteLine("\nFirst Name: {0}", firstName);
            Console.WriteLine("Last Name: {0}", lastName);
            
            if (sex == 0)
            {
                Console.WriteLine("Last Name: {0}", "Male");
            }
            else
            {
                Console.WriteLine("Last Name: {0}", "Female");

            }
            Console.WriteLine("Age : {0}", age);
            Console.WriteLine("Height: {0}", height);
        }


    }



}
