namespace Console
{
    class Pets
    {
        private bool sleepy { get;}
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
        public void Status()
        {
            System.Console.WriteLine($"Size: {size}, Sleepy? {sleepy == 1?"Yes":"No"}");
        }
        public int Sleepy()
        {
            Random rng = new Random();
            sleepy = rng.Next(0,1);
        }

        public void Feed(string food)
        {
            System.Console.WriteLine("You have fed your pet");
            System.Console.WriteLine($"Your pet has grown {this.size * 1.03 - this.size} cm cubed!");
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
        public void Cheeky(int cheeky)
        {
            if (cheeky != cheekiness)
            {
                cheekiness = cheeky;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            String[] colours = new string[] {"brown", "black", "white", "albino", "pink", "purple", "orange", "red", "green", "yellow"}
            string[] food = new string[] {""}
            Kangaroo dog = new Kangaroo(true, "brown", 100, "aooga", "children", "Australia", "Australian Kangaroo", 1, 0.02);
            System.Console.WriteLine($"Size: {dog.GetSize()}");
            dog.Feed("");
            System.Console.WriteLine($"Size: {dog.GetSize().ToString("#.##")}");
            dog.Sleepy();
            System.Console.WriteLine(dog.Status());
            System.Console.ReadLine();
        }
    }
}