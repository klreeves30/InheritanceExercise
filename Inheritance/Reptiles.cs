using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public string FavoriteFood { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool HasTail = true;
        public string Name { get; set; }
        public int Age { get; set; }

        

        public Reptile()
        {
           

        }
        
        
        public Reptile(string name, int age, bool isColdBlooded, bool hasTail, string favoriteFood )
        {
            Name = name;
            Age = age;
            IsColdBlooded = isColdBlooded;
            HasTail = hasTail;
            FavoriteFood = favoriteFood;

        }


        //example of creating method to call in main program

        public void PrintDetails() 
        {

            Console.WriteLine($"{GetType().Name}\n");
            Console.WriteLine($"The life span of an {Name} is {Age} years old\n");
            Console.WriteLine($"Is a {Name} cold blooded {IsColdBlooded}\n");
            Console.WriteLine($"Is it true that {Name} has a tail? That is {HasTail}\n");
            Console.WriteLine($"{Name} favorite food is {FavoriteFood}\n");
        }
      

    }
}
