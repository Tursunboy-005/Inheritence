using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Car
    {
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car(decimal price, string model)
        {
            Model = model;
            Price = price;
        }
        public void Drive()
        {
            Console.WriteLine($"   {Model}  is driving...");
        }
    }
    class ExpensiveCar : Car 
    {
        public double Battery { get; set; }

        public ExpensiveCar(decimal price,string model, double battery)
           :base(price,model)            
        {
            Battery = battery;
        }
    }
    class Tesla : ExpensiveCar
    {
     public Tesla( decimal price, string model, double battery)
            :base(price,model,battery) 
        {
        }   
    }
    class TeslaY : Tesla
    {
        public int NumberY { get; set; }
        public TeslaY(int numberY,decimal price, string model,double battery)
            :base(price, model, battery) 
        {
            NumberY = numberY;
        }
    }
    class TeslaX : Tesla
    {
        public int NumberX { get; set; }
        public TeslaX(int numberX,decimal price, string model, double battery) 
            : base(price, model, battery)
        {
            NumberX = numberX;
        }
    }
}
