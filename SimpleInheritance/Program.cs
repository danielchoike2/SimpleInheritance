using System;
using System.Drawing;

namespace Inheritance
{

    // base class 
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    // derived class of Animal 

    class Fish
    {// start of fish class 
        public string othername;
        public string fishcolor;
        public string fishspecies;

        // constructor
        public Fish()
        {
            othername = "";
            fishcolor = "";
            fishspecies = "";
         }
        //parameterized constructor
        public Fish(string othername, string fishcolor, string fishspecies)
        {
            this.othername = othername;
            this.fishcolor = fishcolor; 
            this.fishspecies = fishspecies; 
        }

        public void fishdisplay()
        {// start of fishdisplay
            Console.WriteLine("Fish Information");
            Console.WriteLine($"Name: {othername}");
            Console.WriteLine($"Color: {fishcolor}");
            Console.WriteLine($"Species: {fishspecies}");
        } // end of fishdisplay

    }// end of fish class 

    class Bird
    {// start of bird class 
        public string birdname;
        public string birdcolor;
        public string birdspecies;

        // constructor
        public Bird()
        {
            birdname = "";
            birdcolor = "";
            birdspecies = "";
        }
        //parameterized constructor
        public Bird(string birdname, string birdcolor, string birdspecies)
        {
            this.birdname = birdname;
            this.birdcolor =birdcolor;
            this.birdspecies = birdspecies;
        }

        public void birddisplay()
        {// start of fishdisplay
            Console.WriteLine("Bird Information");
            Console.WriteLine($"Name: {birdname}");
            Console.WriteLine($"Color: {birdcolor}");
            Console.WriteLine($"Species: {birdspecies}");
        } // end of fishdisplay

    }// end of fish class 

    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            Console.WriteLine("");
            myPet.display();
            Fish myFish = new Fish();
            myFish.othername = "Boogie";
            myFish.fishcolor = "Orange and Black";
            myFish.fishspecies = "Oscar";
            Console.WriteLine("");
            myFish.fishdisplay();
            Bird oneBird = new Bird();
            oneBird.birdname = "Terry";
            oneBird.birdcolor = "Gray and Red";
            oneBird.birdspecies = "African Parrot";
            Console.WriteLine("");
            oneBird.birddisplay();
            Console.WriteLine("");
            myFish.fishdisplay();
            Bird twoBird = new Bird();
            twoBird.birdname = "Sammy";
            twoBird.birdcolor = "Green";
            twoBird.birdspecies = "Parakeet";
            Console.WriteLine("");
            twoBird.birddisplay();

            // derived class object using default constructor


            //derived class object using parameterized constructor

        }

    }
}
