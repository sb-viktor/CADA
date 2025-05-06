using CommunityToolkit.Mvvm.ComponentModel;

namespace CADA.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private string _greeting = "Хуй в сраку всей эстраде!!!!!!";
}
