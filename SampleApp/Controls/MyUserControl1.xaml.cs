using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace SampleApp.Controls
{
    public sealed partial class MyUserControl1 : UserControl
    {
        public event RoutedEventHandler Clicked;

        public MyUserControl1()
        {
            InitializeComponent();
            MySubmitButton1.Click += (s, e) => Clicked?.Invoke(s, e);
            MySubmitButton2.Click += (s, e) => Clicked?.Invoke(s, e);
            MySubmitButton3.Click += (s, e) => Clicked?.Invoke(s, e);
        }

        public string EulaText
        {
            get => (string)GetValue(EulaTextProperty);
            set => SetValue(EulaTextProperty, value);
        }
        public static readonly DependencyProperty EulaTextProperty =
            DependencyProperty.Register(nameof(EulaText), typeof(string),
                typeof(MyUserControl1), new PropertyMetadata("Default value."));
    }
}
