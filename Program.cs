namespace Console
{
    class Pets
    {
        private bool hair { get;}
        private String hairCol{ get;}
        private double size{ get; set;}
        private String sound{ get;}
        private String food{ get;}
        private String nationality{ get;}
        private String breed{ get;}
        public Pets(bool hair, String hairCol, double size, string sound, string food, string nationality, string breed)
        {
            this.hair = hair;
            this.hairCol = hairCol;
            this.size = size;
            this.sound = sound;
            this.food = food;
            this.nationality = nationality;
            this.breed = breed;
        }
    }
    class Monkey : Pets
    {
        private int cheekiness { get; set;}
        public Monkey(bool myHair, String MyhairCol, double mySize, string mySound, string myFood, string mNati, string br, int cheek):
            base(myHair, MyhairCol, mySize, mySound, myFood, mNati, br)
        {
            cheekiness = cheek;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}