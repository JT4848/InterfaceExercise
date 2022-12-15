using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public string NumWheels { get; set; }
        public string NumWindows { get; set; }
        public bool Has4X4 { get; set; }
        public string Passengers { get; set; }
    }
}
