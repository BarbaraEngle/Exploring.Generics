namespace Generics
{
    internal class Car
    {

        public Car(int id, int doorCount, string colour)
        {
            CarId = id;
            DoorCount = doorCount;
            Colour = colour;
        }
        public int CarId { get; set; }
        public int DoorCount { get; set; }
        public string Colour { get; set; } = "White";


        //Here we are overriding the Object.ToString method
        public override string ToString()
        {
            return $"{this.GetType()} has an id of {this.CarId} and it has {this.DoorCount} doors.  The colour of the car is {this.Colour}.";
        }
    }
}
