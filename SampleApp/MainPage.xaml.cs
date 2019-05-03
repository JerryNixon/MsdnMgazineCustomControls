using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SampleApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs args)
        {
            MyUserControl.EulaTextBox.Text = "Text provided by x:FieldModifier though code-behind.";
            MyUserControl.Clicked += (s, e) => UpdateConsole();
            MyControl.Click += (s, e) => UpdateConsole();
            void UpdateConsole()
            {
                EventConsoleTextBlock.Text += $"Click event. {DateTime.Now}.{Environment.NewLine}";
            }
        }

        public ViewModels.MainPageViewModel ViewModel { get; } = new ViewModels.MainPageViewModel();

        private void Debug_Toggled(object sender, RoutedEventArgs e)
        {
            Application.Current.DebugSettings.IsTextPerformanceVisualizationEnabled = (sender as ToggleSwitch).IsOn;
        }
    }
}
