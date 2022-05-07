namespace IT1050___Final
{
    internal class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;
        }
        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }
        public double GetCurrentWeight()
        {
            double sumOfWeights = 0;
            foreach (Passenger passenger in Occupants)
            {
                sumOfWeights+=passenger.GetWeight();
            }
            return sumOfWeights;
        }
        public bool IsOverMaxCapacity()
        {
            return GetCurrentWeight() > MaxWeight;
        }
    }
}
