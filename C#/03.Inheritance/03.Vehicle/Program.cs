using System;

namespace _03.Vehicle
{
    class Program
    {
        static void Main()
        {
            Plane plane = new Plane { Year_of_construction = 2000, Price = 1000000, FlightAltitude = 2000, NumberOfPassengers = 10, Speed = 500 };
            plane.Coordinate(1000, 1000);
            plane.Info();
            Car car = new Car { Price = 50000, Year_of_construction = 200, Speed = 210 };
            car.Coordinate(1000, 1000);
            car.Info();
            Ship ship = new Ship { Price = 5000000, Year_of_construction = 2000, Speed = 100, DestinationPort = "Порт Прибрежный", NumberOfPassengers = 100 };
            ship.Coordinate(1000, 1000);
            ship.Info();
            Console.ReadLine();
        }
    }
    class Vehicle
    {
        private double coordinateX, coordinateY;
        private double price, speed, year_of_construction;
        
        public double CoordinateX
        {
            get { return coordinateX; }
            set { coordinateX = value; }
        }

        public double CoordinateY
        {
            get { return coordinateY; }
            set { coordinateY = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double Year_of_construction
        {
            get { return year_of_construction; }
            set { year_of_construction = value; }
        }

        public void Coordinate(double CoordinateX, double CoordinateY)
        {
            this.CoordinateX = CoordinateX;
            this.coordinateY = CoordinateY;
        }

        public virtual void Info()
        {
            Console.WriteLine("Координаты X: {0},Y: {1}", CoordinateX, CoordinateY);
            Console.WriteLine("Стоимость: {0}", Price);
            Console.WriteLine("Скорость: {0}", Speed);
            Console.WriteLine("Год выпуска: {0}", Year_of_construction);
        }
    }

    class Plane : Vehicle
    {
        public double FlightAltitude { get; set; }
        public double NumberOfPassengers { get; set; }
        public override void Info()
        {
            Console.WriteLine("Информация о самолете");
            base.Info();
            Console.WriteLine("Высота полёта: {0}", FlightAltitude);
            Console.WriteLine("Число пассажиров: {0}\n", NumberOfPassengers);
        }

    }

    class Ship : Vehicle
    {
        public double NumberOfPassengers { get; set; }
        public string DestinationPort { get; set; }
        public override void Info()
        {
            Console.WriteLine("Информация о корабле");
            base.Info();
            Console.WriteLine("Число пассажиров: {0}", NumberOfPassengers);
            Console.WriteLine("Порт приписки: {0}\n", DestinationPort);
        }
    }

    class Car : Vehicle
    {
        public override void Info()
        {
            Console.WriteLine("Информация об автомобиле");
            base.Info();
            Console.WriteLine("");
        }
    }
}
