using MentalNotesNew.ViewModel;
using MentalNotesNew.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace MentalNotesNew.View
{
    public partial class MainPage : ContentPage
    {

        private MainViewModel vm = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = vm;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.FullName = "John DeVries";


        }


    }

}