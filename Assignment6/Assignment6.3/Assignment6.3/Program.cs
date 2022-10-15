
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ASSIGNMENT_6_
{
    public class PRODUCTS
    {
        static void Main(string[] args)
        {
            List<Products> stdlist = new List<Products>
            {
                new Products{ProductId=1,Product_Name="SOAP",Price=100.0f},
                new Products{ProductId=2,Product_Name="BRUSH",Price=200.0f},
                new Products{ProductId=3,Product_Name="WASHINGMACHINE",Price=300000.0f},
                new Products{ProductId=4,Product_Name="LAPTOP",Price=400000.0f},
                new Products{ProductId=5,Product_Name="MOBILEPHONE",Price=500000.0f},
                new Products{ProductId=6,Product_Name="AIRCONDITIONER",Price=600000.0f},
                new Products{ProductId=7,Product_Name="FAN",Price=7000.0f},
                new Products{ProductId=8,Product_Name="WEDGES",Price=800.0f},
                new Products{ProductId=9,Product_Name="BACKPACKS",Price=900.0f},
                new Products{ProductId=10,Product_Name="DININGTABLE",Price=10000.0f}
            };
            Display(stdlist);
            Console.Read();
        }
        public static void Display(List<Products> products)
        {
            Console.WriteLine();
            var val = products.OrderBy(a => a.Price).ToList();
            foreach (var p in val)
            {
                Console.WriteLine("name: {0}   id: {1}   Price: {2} ", p.Product_Name, p.ProductId, p.Price);
            }
        }
    }

    public class Products
    {
        public int ProductId
        {
            get;
            set;
        }
        public string Product_Name
        {
            get;
            set;
        }
        public float Price
        {
            get;
            set;
        }


    }
}
