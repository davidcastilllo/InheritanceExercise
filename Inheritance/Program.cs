using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

             var birdOne = new Bird();

             birdOne.IsAlive = (true);
             birdOne.Age = (7);
             birdOne.LandSeaAir = ("Air");
             birdOne.LegCount = (2);

             birdOne.CanFly = (true);
             birdOne.EatsFromSea = (true);
             birdOne.WalksOnLand = (true);
             birdOne.NumberOfFeathers = (100);

             birdOne.display();
             
             var reptileOne = new Reptile();

             reptileOne.IsAlive = (true);
             reptileOne.Age = (9);
             reptileOne.LandSeaAir = ("Land");
             reptileOne.LegCount = (4);

             reptileOne.CanSwim = (true);
             reptileOne.LaysEggs = (true);
             reptileOne.ColdOrHotBlooded = ("Hot Blooded");
             reptileOne.ScalesOrScutes = ("Scales");

             reptileOne.display();

        }
    }
}
