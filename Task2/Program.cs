using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var trains = new Train[2];

            for (int i = 0; i < trains.Length; i++)
            {
                Console.WriteLine("Please specify destination name, number of train and departure time for current train. Use \"-\" as separator.");
                try
                {
                    var input = Console.ReadLine().Split('-');
                    trains[i] = new Train(input[0], int.Parse(input[1]), DateTime.Parse(input[2]));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Incorect input - {e.Message}");
                }
            }
            Array.Sort(trains);
            while (true)
            {
                Console.WriteLine("Please specify number of train.");
                try
                {
                    var input = int.Parse(Console.ReadLine());
                    bool isFound = false;
                    for (int i = 0; i < trains.Length; i++)
                    {
                        if (trains[i].Number == input)
                        {
                            trains[i].PrintInfo();
                            isFound = true;
                            break;
                        }
                    }
                    if (!isFound)
                        Console.WriteLine("Number have not found.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Incorect input - {e.Message}");
                }

            }
        }
    }
}
