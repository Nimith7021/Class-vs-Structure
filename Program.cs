using AnimalClass.Models;

namespace AnimalClass
{
    internal class Program
    {
        public struct Bird
        {
            public string Name;
            public bool isRare;
            public string Color;
        }
        static void Main(string[] args)
        {
            Bird bird;
            bird.Name = "Crow";
            bird.isRare = false;
            bird.Color = "Black";

            Bird bird1 = bird;
            Console.WriteLine("======================FOR STRUCTURE=====================");
            Console.WriteLine("The name of the bird is : " + bird.Name);
            Console.WriteLine("Is the bird rare ? : " + bird.isRare);
            Console.WriteLine("The color of the bird is : " + bird.Color);

            bird.Name = "Cat";

            Console.WriteLine("\n");
            Console.WriteLine("The value of bird name in bird " + bird.Name); //it is value based 
            Console.WriteLine("The value of bird name in bird1 " + bird1.Name);



            Console.WriteLine("=========================FOR CLASS======================");
            Animal animal = new Animal("Dog", false, "Brown");
            Animal animal1 = animal;

            Console.WriteLine("========for animal object========");
            Console.WriteLine(animal);
            Console.WriteLine("========for animal1 object=======");
            Console.WriteLine(animal1);

            animal.Name = "Cat";

            Console.WriteLine("========for animal object========"); /*changes are reflected on both 
                                                                     * objects since its referential*/
            Console.WriteLine("The name of the animal is "+animal.Name);
            Console.WriteLine("========for animal1 object=======");
            Console.WriteLine("The name of the animal is " +animal1.Name);


        }
    }
}
