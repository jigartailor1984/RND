using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CommunityToolKitCoreDemo.ViewModels
{
    public partial class MainViewModel : ObservableValidator
    {
        int _counter = 0;
        [ObservableProperty]
        string _text = string.Empty;

        [RelayCommand]
        void Add()
        {

            Text = $"Add clicked {++_counter} Times!!";
        }
        public MainViewModel()
        {
            Text = "Click Me!";
        }
    }
}
