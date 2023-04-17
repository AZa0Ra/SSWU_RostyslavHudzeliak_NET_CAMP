using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective_2
{
    internal class Box
    {
        Store store;
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public Dimensions dimensions { get; set; }

        public Box(string name, List<Product> products, Store store)
        {
            Name = name;
            Products = products;
            dimensions = CalculateBoxDimensions();
            this.store = store;
        }

        public Dimensions CalculateBoxDimensions()
        {
            double width = 0;
            double height = 0;
            double length = 0;
            foreach (var product in Products)
            {
                width += product.dimensions.Width;
                length = Math.Max(length, product.dimensions.Length);
                height = Math.Max(height, product.dimensions.Height);
            }      
            return new Dimensions(width, length, height);
        }
        public static bool CanFitInBox(Product product, Box box)
        {
            // перевірка, чи товар поміщається по довжині та висоті
            if (product.dimensions.Length <= box.dimensions.Length && product.dimensions.Height <= box.dimensions.Height)
            { 
                // перевірка, чи коробка є порожньою або в ній вже є товар з того ж підрозділу
                if (box.Products.Count == 0 ||
                    box.Products[0].department.Name == product.department.Name)
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            string departmentNames = string.Join(", ", Products.Select(p => p.department.Name).Distinct());
            return $"Box: {store.Name}\\{departmentNames}\nDimensions: {dimensions.Width}x{dimensions.Length}x{dimensions.Height}\nBoxed: {Name}\n";
        }
    }
}
