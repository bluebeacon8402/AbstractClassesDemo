using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */
            var vehicles = new List<Vehicle>();
            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class - DONE
             * Set the properties with object initializer syntax - DONE
             */
            Car car1 = new Car() { HasTrunk = true, Make = "Nissan", Model = "Pathfinder", Year = 2013};
            /*
             * Add the 4 vehicles to the list - DONE
             * Using a foreach loop iterate over each of the properties - DONE
             */
            Motorcycle motorcycle1 = new Motorcycle() { HasSideCart = true, Make = "Harley Davidson", Model = "SoftTail", Year = 2005 };
            // Call each of the drive methods for one car and one motorcycle - DONE
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Make{veh.Make} Model{veh.Model} Year{veh.Year}");
                Console.WriteLine("_________________________________________________________________");
            }


            #endregion            
            Console.ReadLine();
        }
    }
}
