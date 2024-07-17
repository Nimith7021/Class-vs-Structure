using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClass.Models
{
    internal class Animal
    {
        public string Name { get; set; }

        public bool IsRare { get; set; }

        public string Color { get; set; }

        public Animal(string name, bool isRare, string color)
        {
            Name = name;
            IsRare = isRare;
            Color = color;
        }

        public override string ToString()
        {
            return $"The name of the animal is {Name}\n" +
                $"Is the animal rare ? {IsRare}\n" +
                $"The color of the animal : {Color}";
        }
    }
}
