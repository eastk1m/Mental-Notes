using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MentalNotesNew.Model;

namespace MentalNotesNew.ViewModel
{
    [ObservableObject]
    public partial class MainViewModel
    {
        public MainViewModel()
        { }
            


        [ObservableProperty]
        private bool logoIsVisible = true;

        [ObservableProperty]
        private string fullName;

        [ObservableProperty]
        private string favoriteFlower = "oip.jpg";

        [RelayCommand]
        private void ToggleFlowerVisibility()
        {
            FlowerIsVisible = !FlowerIsVisible;
        }


        public ObservableCollection<Username> UserList { get; set; } = new();

        [RelayCommand]
        private void UpdateRegistrations()
        {
            foreach (var item in UserList)
                item.IsRegistered = true;
        }


    }



}