using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC1
{
    class VehicleModel
    {
        private String name;
        private String year;

        public String Name
        {
            get
            {
                return name;

            }
            set
            {
                name = value;
            }

        }
        public String Year
        {
            get
            {
                return year;

            }
            set
            {
                year = value;
            }

        }
    }
}
