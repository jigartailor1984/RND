using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommunityToolKitCoreDemo.ViewModels
{
    public partial class UserDetailsViewModel : ObservableValidator
    {
        [ObservableProperty]
        [NotifyDataErrorInfo]
        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        private string? firstName;

        [ObservableProperty]
        [NotifyDataErrorInfo]
        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        private string? lastName;

        [ObservableProperty]
        [NotifyDataErrorInfo]
        [Required]
        [EmailAddress]
        private string? email;

        [ObservableProperty]
        [NotifyDataErrorInfo]
        [Required]
        [Phone()]
        private string? phoneNumber;

        [RelayCommand]
        void Submit()
        { 
            ValidateAllProperties();
            if(this.HasErrors)
            {
                MessageBox.Show("Validation failed");
            }
            else
            {
                MessageBox.Show("Submition successfull.");
            }
        }
    }
}
