using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Myfirstproject.Models
{
    public class ProductModel
    {


            public int SN { get; set; }
            public byte[] Image { get; set; }
            public string Name { get; set; }
            public decimal price { get; set; }
            public string description { get; set; }
        
    }
}