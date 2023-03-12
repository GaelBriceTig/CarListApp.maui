using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarListApp.maui.Models;

namespace CarListApp.maui.Services
{
    public class CarService
    {
        public List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car{
                     Make = "Honda", Model = "Fit", Vin = "123"
                },
                new Car{
                     Make = "Toyota", Model = "Prado", Vin = "123"
                },
                new Car{
                     Make = "Audi", Model = "A5", Vin = "123"
                },
                new Car{
                     Make = "BMW", Model = "M3", Vin = "123"
                },
            };
        }
    }
}
