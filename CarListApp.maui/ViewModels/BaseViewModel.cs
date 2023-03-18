using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using CommunityToolkit.Mvvm.ComponentModel;

namespace CarListApp.maui.ViewModels
{
    public partial class BaseViewModel : ObservableObject  
    {
       
        [ObservableProperty]
        string title;

        

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotLoading))]
        bool isLoading;

        

        public bool IsNotLoading => !isLoading;
    }
}
