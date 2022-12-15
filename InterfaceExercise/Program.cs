using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces - done

            //Create 2 Interfaces called IVehicle & ICompany - done

            //Create 3 classes called Car , Truck , & SUV - done

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now.. - done
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; } - done
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car car1 = new Car();
            car1.Name = "Infinity g35";
            car1.Passengers = "two passengers";
            car1.NumWheels = "four wheels";
            car1.IsCoupe = true;
            car1.IsLow = true;
            car1.Has4X4 = false;
            car1.NumWindows = "four windows";
            car1.Logo = "new horizons";
            Console.WriteLine($"One of my favorite car's is a {car1.Name}, it has {car1.NumWindows} {car1.NumWheels} and can hold {car1.Passengers}." +
                $"It is {car1.IsCoupe} that it's a coupe, it's also {car1.IsLow} that it is pretty low, especially if you lower it yourself, but it's " +
                $"{car1.Has4X4} that it has 4x4,it is rear wheel drive. There logo is pretty cool also, it means {car1.Logo}.");
            
            Console.WriteLine("-----------------------");

            SUV suv1 = new SUV();
            suv1.Name = "Rolls Royce Cullinan";
            suv1.NumWheels = "four wheels";
            suv1.Has4X4 = true;
            suv1.NumWindows = "six windows";
            suv1.IsFast = true;
            suv1.Passengers = "five passengers";
            suv1.HasTrunk = true;
            suv1.Logo = "the spirit of ecstasy";
            Console.WriteLine($"Another cool one is a {suv1.Name}, it has {suv1.NumWheels} {suv1.NumWindows} and can hold {suv1.Passengers}." +
                $"It is {suv1.HasTrunk} that it has a massive trunk, it can definitely hold whatever you want to put back there, except maybe a rhino or something." +
                $"  It's {suv1.IsFast} that it's pretty quick, it's also {suv1.Has4X4} that it's 4x4, it definitely need's it with that v12 that's pushing it!" +
                $"The logo is probably one of the most known logo's and it stands for {suv1.Logo} if you didn't know!" );

            Console.WriteLine("-----------------------");

            Truck truck1 = new Truck();
            truck1.Name = "Ford F-650";
            truck1.NumWheels = "six wheels";
            truck1.NumWindows = "six windows";
            truck1.BedSize = "ten foot";
            truck1.Has4X4 = true;
            truck1.IsLoud = true;
            truck1.Passengers = "six passengers";
            truck1.Logo = "flat oval";
            Console.WriteLine($"A really cool one is a {truck1.Name}, it has {truck1.NumWheels} {truck1.NumWindows} and can hold {truck1.Passengers}." +
                $"  Im sure you could assume by it's looks, but yes, it's {truck1.IsLoud} that it's loud, and of course it's {truck1.Has4X4} that it's 4x4." +
                $"You definitely don't want to get that thing stuck. You can fit plenty in it's {truck1.BedSize} bed as long as it isnt raining." +
                $"This logo isn't as cool as it's   pretty common, all it is is a {truck1.Logo}.");
            
        }

    }
}
