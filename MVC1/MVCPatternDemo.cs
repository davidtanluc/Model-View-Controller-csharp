using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC1
{
    class MVCPatternDemo
    {
        static void Main(string[] args)
        {
            VehicleModel model = retrieveVehicleDatabase();
            VehicleView view = new VehicleView();
            VehicleController controller = new VehicleController(model, view);
            controller.updateView();

            controller.Name = "Audi";
            controller.Year = "2011";
            controller.updateView();
        }

        private static VehicleModel retrieveVehicleDatabase()
        {
            VehicleModel model = new VehicleModel();
            model.Name = "Mercedes";
            model.Year = "2013";
            return model;
        }

    }
}
