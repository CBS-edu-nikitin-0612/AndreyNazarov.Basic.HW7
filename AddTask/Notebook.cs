using System;

namespace AddTask
{
    internal struct Notebook
    {
        private string model;
        private string manufacturer;
        private int price;

        public Notebook(string model, string manufacturer, int price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public void Print()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;           

            Console.WriteLine("{0,-20}{1,-40}", "Model:", model);
            Console.WriteLine("{0,-20}{1,-40}", "Manufacturer:", manufacturer);
            Console.WriteLine("{0,-20}{1,-40:C0}", "Price:", price);
        }
    }
}
