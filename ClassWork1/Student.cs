namespace ClassWork1
{
    internal struct Student
    {
        public string SecondName { get; private set; }
        public int Number { get; private set; }

        public Student(string secondName, int number)
        {
            SecondName = secondName;
            Number = number;
        }
    }
}
