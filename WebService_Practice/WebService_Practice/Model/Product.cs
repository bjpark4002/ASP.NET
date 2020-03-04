using Dal.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService_Practice.Model
{
    public class Product : tblProduct
    {

     
            public string Product_ID { get; set; }
            public string Manufacturer_ID { get; set; }
            public string SubCategory_ID { get; set; }
            public string Product_Name { get; set; }
            public string Product_Image { get; set; }
            public string Series { get; set; }
            public string Model { get; set; }
            public string Model_Year { get; set; }
            public string Series_Info { get; set; }
            public string Featured { get; set; }


    }
}