using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarListApp.maui.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CarListApp.maui.ViewModels
{
    [QueryProperty(nameof(Car), "Car")]
    public partial class CarDetailsViewModel: BaseViewModel
    {

        [ObservableProperty]
        Car car;

       public CarDetailsViewModel()
        {
            Title = $"Car Details - {car.Make} {car.Model}";
            //essay
        }
    }
}
