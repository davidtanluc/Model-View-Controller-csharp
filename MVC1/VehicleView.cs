using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC1
{
    class VehicleView
    {
        public void printVehicleDetails(String name, String year)
        {
            Console.WriteLine("Welcome to Auto Trader! ");
            Console.WriteLine("Vehicle name is {0} ",name);
            Console.WriteLine("Vehicle year is {0}", year);
            Console.WriteLine();

        }

    }
}
