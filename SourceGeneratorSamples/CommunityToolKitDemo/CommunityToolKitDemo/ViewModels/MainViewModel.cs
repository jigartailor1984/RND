using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityToolKitDemo.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string _text;

        [RelayCommand]
        void Add()
        { 
        
        }

        public MainViewModel()
        {
            Text = string.Empty;
        }
    }
}
