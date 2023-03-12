using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarListApp.maui.Services;
using CarListApp.maui.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using CarListApp.maui.Views;

namespace CarListApp.maui.ViewModels
{
    public partial class CarListViewModel : BaseViewModel
    {
        private readonly CarService carService;
        public ObservableCollection<Car> Cars { get; private set; } = new();

        public CarListViewModel(CarService carService)
        {
            Title = "Car List";
            this.carService = carService;

        }

        [ObservableProperty]
        bool isRefreshing;

        [RelayCommand]
        async Task GetCarList()
        {
            if (IsLoading) return;
            try
            {
                IsLoading= true;
                if(Cars.Any())
                {
                    Cars.Clear();
                }
                var cars = carService.GetCars();
                foreach(var car in cars)
                {
                    Cars.Add(car);
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"Unable to get cars: {ex.Message}");
                await Shell.Current.DisplayAlert("Error", "Failed to retrive list of cars.", "OK");
            }
            finally
            { 
                IsLoading = false; 
                IsRefreshing = false;
            }
        }

        [RelayCommand]
        async Task GetCarDetails(Car car)
        {
            if(car == null) return;

            await Shell.Current.GoToAsync(nameof(CarDetailsPage), true, new Dictionary<string, object>
            {
                {nameof(Car), car }
            });
        }
    }
}
