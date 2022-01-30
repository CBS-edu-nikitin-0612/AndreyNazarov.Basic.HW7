using System;

namespace ClassWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Student[6];
            students[0] = new Student("White", 1);
            students[1] = new Student("Jones", 4);
            students[2] = new Student("Smith", 3);
            students[3] = new Student("Obama", 7);
            students[4] = new Student("Chan", 1);
            students[5] = new Student("Biden", 3);

            Console.WriteLine("{0,-20}{1,-10}", "Second Name", "Number");
            Console.WriteLine(new string('-', 30));
            for (int i = 0; i < students.Length - 1; i++)
            {
                Console.WriteLine("{0,-20}{1,-10}", students[i].SecondName, students[i].Number);
            }
        }
    }
}
