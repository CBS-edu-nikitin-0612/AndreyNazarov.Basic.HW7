using System;

namespace ClassWork2
{
    internal struct Student : IComparable
    {
        public string SecondName { get; private set; }
        public int Score1 { get; private set; }
        public int Score2 { get; private set; }
        public int Score3 { get; private set; }

        public Student(string secondName, int score1, int score2, int score3)
        {
            SecondName = secondName;
            Score1 = score1;
            Score2 = score2;
            Score3 = score3;
        }

        public int CompareTo(object obj)
        {

            if (((Student)obj).GetAmountScore() < GetAmountScore())
            {
                return -1;
            }
            else
            {
                return ((Student)obj).GetAmountScore() == GetAmountScore() ? 0 : 1;
            }
        }

        public int GetAmountScore()
        {
            return Score1 + Score2 + Score3;
        }
    }
}
