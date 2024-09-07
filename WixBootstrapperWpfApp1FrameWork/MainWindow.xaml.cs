using System.Windows;

using System.Windows;

using System.Windows.Interop;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private MainViewModel viewModel;

    public MainWindow(ManagedBA bootstrapper)
    {
        InitializeComponent();

        var vindowHandle = new WindowInteropHelper(this).EnsureHandle();

        DataContext =
            viewModel = new MainViewModel(bootstrapper) { ViewHandle = vindowHandle };
    }

    private void Install_Click(object sender, RoutedEventArgs e)
    {
        viewModel.InstallExecute();
    }

    private void Uninstall_Click(object sender, RoutedEventArgs e)
    {
        viewModel.UninstallExecute();
    }

    private void Exit_Click(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void TextBlock_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        viewModel.ShowLog();
    }
}