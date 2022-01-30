using System;

namespace Task2
{
    internal struct Train : IComparable
    {
        private string destinationName;
        private int number;
        public int Number { get => number; }
        private DateTime departureTime;

        public Train(string destinationName, int number, DateTime departureTime)
        {
            this.destinationName = destinationName;
            this.number = number;
            this.departureTime = departureTime;
        }

        public int CompareTo(object obj)
        {
            if (((Train)obj).number > number)
            {
                return -1;
            }
            else
            {
                return ((Train)obj).number == number ? 0 : 1;
            }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Number: {number}\n" +
                $"Destination Name: {destinationName}\n" +
                $"Departure Time: {departureTime}");
        }
    }
}
