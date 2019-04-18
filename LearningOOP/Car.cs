using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningOOP
{
    public class Car
    {
        string brand;
        bool gearType = true;
        float weight;
        string color;
        string drive;
        string engine;
        int productionYear;
        string model;
        
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }
        public bool IsAutomaticGear
        {
            get
            {
                return gearType;
            }
            set
            {
                gearType = value;
            }
        }
        public string Engine
        {
            get
            {
                return engine;
            }
            set
            {
                engine = value;
            }
        }
        public int ProductionYear
        {
            get
            {
                return productionYear;
            }
            set
            {
                if (value < 1970 || value >DateTime.Today.Year)
                    value = 1970; 
                productionYear = value;
            }
        }
        public float Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public void Driving()
        {
            Console.WriteLine($"The car you're currently driving is a {ProductionYear}-\"{Model}\" made by {Brand}");
        }
        public override string ToString()
        {
            return $@"
brand: {Brand}
Model: {Model}
Year of Production: {ProductionYear}
Weight: {Weight}
Engine: {Engine}
Color: {Color}";
        }
    }
}
