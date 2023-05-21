using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Vehicle
    {
        prop model;
        prop year;
        prop Category;

        public Vehicle(model,year,Category)
        {
            this.model = model;
            this.year = year;
            this.Category = Category;
        }
    }

    interface IDrivable
    {
        void move();
        void stop();
        }
     interface Iloader
    {
        void load();
        void unload();
    }

    class caterpiller : Vehicle, IDrivable, Iloader
    {
        public caterpiller(model,year,Category) : base(model,year,Category)
        {

        }

        public void load()
        {
            Console.WriteLine("loading");
        }

        public void move() => Console.WriteLine("moveing");
       

        public void stop() => Console.WriteLine("stoping");
      

        public void unload() =>Console.WriteLine("unloading");
       
    }
}
