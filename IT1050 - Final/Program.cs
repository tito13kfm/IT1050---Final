namespace IT1050___Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var elevator1 = new Elevator(2, 400);
            var elevator2 = new Elevator(3, 600);

            elevator1.AddOccupant(new Passenger("A1", 180), 0);
            elevator1.AddOccupant(new Passenger("A2", 220), 1);
            
            elevator2.AddOccupant(new Passenger("A1", 200), 0);
            elevator2.AddOccupant(new Passenger("A2", 200), 1);
            elevator2.AddOccupant(new Passenger("A3", 201), 2);

            bool elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();
            bool elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();
        }
    }
}
