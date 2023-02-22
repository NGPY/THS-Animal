namespace Console
{
    class Pets
    {
        private bool hair { get;}
        private string hairCol{ get;}
        private double size;
        private string sound{ get;}
        private string food{ get;}
        private string nationality{ get;}
        private string breed{ get;}
        public Pets(bool hair, string hairCol, double size, string sound, string food, string nationality, string breed)
        {
            this.hair = hair;
            this.hairCol = hairCol;
            this.size = size;
            this.sound = sound;
            this.food = food;
            this.nationality = nationality;
            this.breed = breed;
        }

        public void Feed(string food)
        {
            System.Console.WriteLine("You have fed your pet");
            System.Console.WriteLine($"Your pet has grown {this.size * 1.03 - this.size} cm!");
            this.size = this.size * 1.03;
        }
        public double GetSize()
        {
            return this.size;
        }
    }
    class Kangaroo : Pets
    {
        private double pouchSize { get; }
        private double jumpHeight { get; }
        public Kangaroo(bool myHair, string MyhairCol, double mySize, string mySound, string myFood, string mNati, string br, double pouchSize, double jumpHeight) :
            base(myHair, MyhairCol, mySize, mySound, myFood, mNati, br)
        {
            this.jumpHeight = jumpHeight;
            this.pouchSize = pouchSize;
        }
    }
    class Monkey : Pets
    {
        private int cheekiness { get; set;}
        public Monkey(bool myHair, string MyhairCol, double mySize, string mySound, string myFood, string mNati, string br, int cheek):
            base(myHair, MyhairCol, mySize, mySound, myFood, mNati, br)
        {
            cheekiness = cheek;
        }
    }
    class Swallow : Pets
    {
        private float wingspan { get; }
        private float beakSize { get; }
        public Swallow(bool myHair, string myHairCol, double mySize, string mySound, string myFood, string myNationality, string myBreed, float myWingspan, float myBeaksize) :
            base(myHair, myHairCol, mySize, mySound, myFood, myNationality, myBreed)
        {
            this.wingspan = myWingspan;
            this.beakSize = myBeaksize;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kangaroo dog = new Kangaroo(false, null, 242534534, "woof", "children", "Australia", "Australian Kangaroo", 1, 0.02);
            System.Console.WriteLine($"Size: {dog.GetSize()}");
            dog.Feed("");
            System.Console.WriteLine($"Size: {dog.GetSize().ToString("#.##")}");
            System.Console.ReadLine();
        }
    }
}