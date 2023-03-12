
using CommunityToolkit.Mvvm.ComponentModel;



namespace Maui_To_Do.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    string text;

    //[ICommand]

    void Add()
    {
        Text = string.Empty;
    }
}
