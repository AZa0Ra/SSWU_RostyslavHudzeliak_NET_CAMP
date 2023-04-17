using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_2
{
    internal class Store
    {
        public string Name { get; set; }
        public List<Department> Departments { get; set; }
        public Store(string name)
        {
            Name = name;
            Departments = new List<Department>();
        }
        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }
        public List<Box> PackProducts(List<Product> products, Store store)
        {
            List<Box> boxes = new List<Box>();
            foreach (var product in products)
            {
                bool productPacked = false;
                foreach (Box box in boxes)
                {
                    if (Box.CanFitInBox(product, box))
                    {
                        box.Products.Add(product);
                        box.dimensions = box.CalculateBoxDimensions();
                        box.Name += $", {product.Name}";
                        productPacked = true;
                        break;
                    }
                }
                if (!productPacked)
                {
                    Box newBox = new Box(product.Name, new List<Product> { product }, store);
                    boxes.Add(newBox);
                }
            }
            return boxes;
        }
    }
}
