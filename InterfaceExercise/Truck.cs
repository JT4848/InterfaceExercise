using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public string BedSize { get; set; }
        public bool IsLoud { get; set; }
        public string NumWheels { get; set; }
        public string NumWindows { get; set; }
        public bool Has4X4 { get; set; }
        public string Passengers { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
    }
}
