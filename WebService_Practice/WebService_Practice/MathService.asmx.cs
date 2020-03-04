using Dal.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using WebService_Practice.Model;
using Dal;

namespace WebService_Practice
{
    /// <summary>
    /// Summary description for MathService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MathService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {

            
            return "Hello World";
        }
        [WebMethod]
        public int Sum(int a , int b)
        {
            return a + b;
        }
        [WebMethod] // if you comment this line, it won't be available 
        public int Multiply(int a , int b)
        {

            return a * b;
        }
        [WebMethod]
        public List<Student> getStudent()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Bumjin"));
            students.Add(new Student(2, "Two"));
            students.Add(new Student(3, "Three"));
            students.Add(new Student(4, "Four"));
            return students;
        }

        [WebMethod]
        public List<tblProduct> getProduct()
        {
            AvengersEntities db = new AvengersEntities();
            

            List<tblProduct> products = db.tblProduct.ToList();

            return products;
        }

    }
}
