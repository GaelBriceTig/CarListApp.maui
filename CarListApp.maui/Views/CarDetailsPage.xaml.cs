namespace CarListApp.maui.Views;
using CarListApp.maui.ViewModels;

public partial class CarDetailsPage : ContentPage
{
	public CarDetailsPage(CarDetailsViewModel carDetailsViewModel)
	{
		InitializeComponent();
		BindingContext= carDetailsViewModel;
	}
}