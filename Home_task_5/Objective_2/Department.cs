using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_2
{
    internal class Department
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }

    public Department(string name)
    {
        Name = name;
        Products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void AddProducts(List<Product> product)
    {
        Products.AddRange(product);
    }
    }
}
