using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.Change = "not modified";
            Console.WriteLine("1 " + myClass.Change);
            ClassTaker(myClass); //Значение изменилось потомучто значение передается по ссылке
            Console.WriteLine("2 " + myClass.Change);

            MyStruct myStruct;
            myStruct.Change = "not modified";
            Console.WriteLine("3 " + myStruct.Change);
            StructTaker(myStruct); //Значение не изменилось потому что оно копирется при передаче в метод
            Console.WriteLine("4 " + myStruct.Change);
            StructTaker2(ref myStruct); // Если исользовать префикс ref но значение изменится
            Console.WriteLine("5 " + myStruct.Change);
        }

        private static void ClassTaker(MyClass myClass)
        {
            myClass.Change = "modified";
        }

        private static void StructTaker(MyStruct myStruct)
        {
            myStruct.Change = "modified";
        }
        private static void StructTaker2(ref MyStruct myStruct)
        {
            myStruct.Change = "modified";
        }
    }
    internal class MyClass
    {
        public string Change;
    }
    internal struct MyStruct
    {
        public string Change;
    }
}
