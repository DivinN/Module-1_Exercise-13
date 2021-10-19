using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Exercise_13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Сегодня мы наконец создадим здание (ну почти =) ).");
            Console.WriteLine("Введите адрес вашего здания.");
            string address = Console.ReadLine();

            Console.WriteLine("Введите длину здания.");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите ширину здания.");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите высоту здания.");
            int height = Convert.ToInt32(Console.ReadLine());

            Building build = new Building(address, length, width, height);
            build.Print();

            Console.WriteLine("Теперь создадим экземпляр класса MultiBuilding.");
            Console.WriteLine("Введите количество этажей.");
            int numOfFloors = Convert.ToInt32(Console.ReadLine());

            MultiBuilding multiBuilding = new MultiBuilding(address, length, width, height, numOfFloors);
            multiBuilding.Print();


            Console.ReadKey();
        }
    }



    class Building
    {
        int buildingLength;
        int buildingWidth;
        int buildingHeight;

        public string Address { set; get; }
        public int Length
        {
            set
            {
                if (value > 0)
                {
                    buildingLength = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Длина здания должна быть больше 0.");
                }
            }
            get
            {
                return buildingLength;
            }
        }

        public int Width
        {
            set
            {
                if (value > 0)
                {
                    buildingWidth = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Ширина здания должна быть больше 0.");
                }
            }
            get
            {
                return buildingWidth;
            }
        }

        public int Height
        {
            set
            {
                if (value > 0)
                {
                    buildingHeight = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Высота здания должна быть больше 0.");
                }
            }
            get
            {
                return buildingHeight;
            }
        }

        public Building(string address, int length, int width, int height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }

        public void Print()
        {
            Console.WriteLine("Данное здания расположено по адресу: {0}. Имеет длину {1} м, ширину {2} м и высоту {3} м.", Address, buildingLength, buildingWidth, buildingHeight);
        }
    }


    sealed class MultiBuilding : Building
    {
        int numberOfFloors;
        public int NumberOfFloors
        {
            set
            {
                if (value > 0)
                {
                    numberOfFloors = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Число этажей здания должно быть больше 0.");
                }
            }
            get
            {
                return numberOfFloors;
            }
        }

        public MultiBuilding(string address, int length, int width, int height, int floors)
            : base (address, length, width, height)
        {
            NumberOfFloors = floors;
        }
        public void Print()
        {

            MultiBuilding multi = new MultiBuilding(Address, Length, Width, Height, NumberOfFloors);
            Building build = multi;
            build.Print();
            Console.WriteLine("При этом этажность здания равна: {0}", NumberOfFloors);
        }
    }
}
