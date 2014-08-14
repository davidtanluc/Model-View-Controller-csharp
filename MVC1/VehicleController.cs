using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC1
{
    class VehicleController
    {
        private VehicleModel model;
        private VehicleView  view;
        public VehicleController(VehicleModel model, VehicleView view)
        {
            this.model = model;
            this.view = view;

        }

        public String Name
        {
           get
           {
               return model.Name;
           } 
            set
            {
                model.Name = value;
            }

        }
        public String Year
        {
            get
            {
                return model.Year;
            }
            set
            {
                model.Year = value;
            }

        }

        public void updateView()
        {
            view.printVehicleDetails(Name, Year);
        }

    }
}
