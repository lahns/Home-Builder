using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConcreteBuilder();

            Console.WriteLine("Custom product1:");
            builder.BuildWalls();
            builder.BuildRoof();
            builder.BuildDoors();
            builder.BuildPool();
            Console.Write(builder.GetProduct().ListParts());

            Console.WriteLine("Custom product2:");
            builder.BuildWalls();
            builder.BuildRoof();
            builder.BuildWindows();
            Console.Write(builder.GetProduct().ListParts());
        }
    }
}
