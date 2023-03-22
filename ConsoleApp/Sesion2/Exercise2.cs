
using System.Drawing;

namespace ConsoleApp.Sesion2
{
    class Exercise2
    {
        public void execute()
        {
            Car myCar = new(2, 4, "Toyota", true);
            myCar.showInfo();

            Table myTable = new(38.7F, 150.5F, "wood", "brown");
            myTable.showInfo();
        }
    }


    class Car
    {
        byte doors { get; }
        byte wheels { get; }
        string brand { get; }

        bool ITV { get; }


        public Car(byte doors, byte wheels, string brand, bool ITV)
        {
            this.doors = doors;
            this.wheels = wheels;
            this.brand = brand;
            this.ITV = ITV;
        }

        public void showInfo()
        {
            Console.WriteLine($"Car specs:\n# Doors: {this.doors}\n# Wheels: {this.wheels}\nBrand: {this.brand}\nITV: {this.ITV}\n");
        }
    }

    class Table
    {

        float weight { get; }
        float length { get; }
        string material { get; }
        string color { get; }



        public Table(float weight, float length, string material, string color)
        {
            this.weight = weight;
            this.length = length;
            this.material = material;
            this.color = color;
        }

        public void showInfo()
        {
            Console.WriteLine($"Table specs:\nWeight: {this.weight}\nLength: {this.length}\nMaterial: {this.material}\nColor: {this.color}\n");
        }
    }
}
