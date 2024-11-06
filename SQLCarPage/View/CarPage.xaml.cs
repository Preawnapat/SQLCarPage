using SQLCarPage.MVVM.ViewModels;

namespace SQLCarPage.View;

public partial class CarPage : ContentPage
{
    public CarPage()
    {
        InitializeComponent();
        this.BindingContext = new CarPageViewModel();
    }
}
