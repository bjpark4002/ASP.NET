using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService_Practice.Model
{
    public class Student
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Student(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public Student()
        {

        }
    }
}