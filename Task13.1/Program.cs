using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task13._1
{
    internal class Program
    {
        public class Building
        {
            public string adress { get; set; }
            public float length { get; set; }
            public float width { get; set; }
            public float height { get; set; }

            public Building(string adr, float len, float wid, float hei)
            {
                this.adress = adr;
                this.length = len;
                this.width = wid;
                this.height = hei;
            }
            public void Print()
            {
                Console.WriteLine($"Здание по адресу: {this.adress}\nДлина: {this.length}\nШирина: {this.width}\nВысота: {this.height}");
            }
        }

        sealed class MultiBuilding : Building
        {
            public int storeys { get; set; }
            public MultiBuilding(string adr, float len, float wid, float hei, int stor) : base(adr, len, wid, hei)
            {
                this.storeys = stor;
            }
            public void Print()
            {
                base.Print();
                Console.WriteLine($"Этажность: {this.storeys}");
            }
        }


        static void Main()
        {

            Building building1 = new Building("Dubova", 10, 8, 12);
            building1.Print();

            MultiBuilding multiBuilding1 = new MultiBuilding("Kizilovka", 15, 9, 78, 101);

            Console.WriteLine();
            multiBuilding1.Print();

            Console.ReadKey();
        }
    }
}
