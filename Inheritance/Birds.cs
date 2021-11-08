using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {

        public string Type { get; set; }
        public int Wings { get; set; }
        public bool IsWarmBlooded { get; set; }
        public bool HasFeathers { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        


        public Bird()
        {
            

        }

        public Bird(string name, int age, int legs, bool hasFeathers, bool isWarmBlooded, int wings )
        {
            Name = name;
            Age = age;
            Legs = legs;
            HasFeathers = hasFeathers;
            IsWarmBlooded = isWarmBlooded;
            Wings = wings;           
            
        }

       

       


    }
}
