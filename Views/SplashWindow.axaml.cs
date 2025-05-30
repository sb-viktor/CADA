using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;

namespace CADA.Views;

public partial class SplashWindow : Window
{
    private readonly Action? _mainAction;

    public SplashWindow()
    {
    }

    public SplashWindow(Action mainAction)
    {
        InitializeComponent();
        _mainAction = mainAction;
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        DummyLoad();
    }

    private async void DummyLoad()
    {
        // Do some background stuff here.
        await Task.Delay(3000);

        await Dispatcher.UIThread.InvokeAsync(() =>
        {
            _mainAction?.Invoke();
            Close();
        });
    }
}