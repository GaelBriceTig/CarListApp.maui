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





        /*
       string _title; // title of the page
       bool _isLoading; // is the page loading, on an operation
       
        public bool IsBusy
        {
            // we get the value of isBusy
            get { return _isBusy; }
            set
            {
                // if the value of isBusy is the same as value we stay the same 
                if (_isBusy == value)
                    return;
                //else isBusy take the value 
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            // we get the value of title
            get { return _title; }
            set
            {
                // if the value of tilte is the same as value we stay the same 
                if (_title == value)
                    return;
                //else title take the value 
                _title = value;
                OnPropertyChanged();
            }
        }

        // this allow our property from viewmodel to be seen by the app everytime there is a change it fire up the changes  
        public event PropertyChangedEventHandler PropertyChanged;

        //get the name of the property triggering this and if empty name it's null
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            // someting has changed ? invoke the new property (name in this case)
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        */
    }
}
