using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViehicleApp
{
    public static  class VehicleFactory
    {
        public static IVehicle GetVehicle(string choice)
        {
            switch (choice)
            {
                case "1":
                    return new Car();
                case "2":
                    return new Bus();
                case "3":
                    return new FormulaCar();
                default:
                    return null;
            }
        }
    }
}
