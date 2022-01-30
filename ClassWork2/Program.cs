using System;

namespace ClassWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Student[6];
            students[0] = new Student("White", 1, 4, 3);
            students[1] = new Student("Jones", 4, 4, 3);
            students[2] = new Student("Smith", 3, 5, 2);
            students[3] = new Student("Obama", 4, 4, 3);
            students[4] = new Student("Chan", 1, 3, 2);
            students[5] = new Student("Biden", 3, 1, 3);

            Array.Sort(students);

            Console.WriteLine("{0,-20}{1,10}{2,10}{3,10}{4,10}", "Second Name", "Score1", "Score2", "Score3", "Amount");
            Console.WriteLine(new string('-', 60));
            for (int i = 0; i < students.Length - 1; i++)
            {
                Console.WriteLine("{0,-20}{1,10}{2,10}{3,10}{4,10}", students[i].SecondName, students[i].Score1, students[i].Score2, students[i].Score3, students[i].GetAmountScore());
            }
        }
    }
}
