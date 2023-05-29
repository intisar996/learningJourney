using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Animal // superclass 
    {
        public string name;
        public int age;

        public virtual void move()
        {
            Console.WriteLine($"Animal name {name} " + $"age : {age}");


        }
        public abstract void MakeSound();

    }

    class Cat : Animal // subclass
    {
        public string gender;
        
        public override void move()
        {
            base.move();
            Console.WriteLine("xxx zzzz xx ");
        }
        public void sound()
        {
            
            Console.WriteLine("Meow");
        }

        public override void MakeSound()
        {
            Console.WriteLine("meeow meowee ");
        }

        public override string ToString()
        {
            return $"my name is {this.name}";
        }

    }

         class   Dog : Animal // subclass
    {
            public string gender;

            public void sound()
            {

                Console.WriteLine("woof");
            }

        public override void MakeSound()
        {
            Console.WriteLine("wooof woooeef ");
        }
    }


         class Egale : Animal // subclass
    {
        public string gender;

        public void sound()
        {

            Console.WriteLine("woof");
        }

        public override void MakeSound()
        {
            Console.WriteLine("wooof woooeef ");
        }
    }



}


