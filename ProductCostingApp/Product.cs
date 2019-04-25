using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCostingApp
{
    public class Product
    {
        public string Name { get; set; }
        public decimal SellingPrice { get; set; }
        public double Unit { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
    public class RawMaterial
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string UnitOfMeasurement { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }
    }
    public class Category
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class ProductAssembly
    {
        public RawMaterial RawMaterial { get; set; }

    }
}
