using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_2
{
    internal class Product
    {
        public string Name { get; set; }
        public Dimensions dimensions { get; set; }
        public Department department { get; set; }
        public Product(string name, Dimensions dimensions, Department department)
        {
            Name = name;
            this.dimensions = dimensions;
            this.department = department;
        }

        public override string ToString()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //string departmentNames = string.Join(", ", Products.Select(p => p.department.Name).Distinct());
            return $"Product: {Name,-20} -\t\t Dimensions: {dimensions.Width}x{dimensions.Length}x{dimensions.Height}\t - \tDepartment: {department.Name,-30}";
        
        }
    }
}
