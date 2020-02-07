using System;
using System.Collections.Generic;

namespace CollectionDemoConApp
{
    class Program
    {

        public class Employee
        {
            public Employee(int id, string name)
            {
                EmpId = id;
                EmpName = name;
            }

            private int _EmpId;

            public int EmpId
            {
                get { return _EmpId; }
                set { _EmpId = value; }
            }

            private string _EmpName;

            public string EmpName
            {
                get { return _EmpName; }
                set { _EmpName = value; }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dictionary<int, Employee> dic = new Dictionary<int, Employee>();

            Employee em1 = new Employee(1, "AAA");
            Employee em2 = new Employee(2, "BBB");
            Employee em3 = new Employee(3, "CCC");
            Employee em4 = new Employee(4, "DDD");
            Employee em5 = new Employee(5, "EEE");

            Console.WriteLine(em1.EmpId);

            dic.Add(em1.EmpId, em1);
            dic.Add(em2.EmpId, em2);
            dic.Add(em3.EmpId, em3);
            dic.Add(em4.EmpId, em4);
            dic.Add(em5.EmpId, em5);

          

            foreach(KeyValuePair<int,Employee> item in dic)
            {
                Console.WriteLine("ID : {0} Name : {1}",item.Key, item.Value.EmpName );

            }
        }
    }
}
