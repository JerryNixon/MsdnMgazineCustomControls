using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace SampleApp.Controls
{
    [ContentProperty(Name = "EulaText")]
    public sealed class MyControl1 : Control
    {
        public event RoutedEventHandler Click;

        public MyControl1() => DefaultStyleKey = typeof(MyControl1);

        protected override void OnApplyTemplate()
        {
            if (GetTemplateChild("PART_BUTTON") is Button b)
            {
                b.Click += (s, e) => Click?.Invoke(s, e);
            }
        }

        public string EulaText
        {
            get => (string)GetValue(EulaTextProperty);
            set => SetValue(EulaTextProperty, value);
        }
        public static readonly DependencyProperty EulaTextProperty =
            DependencyProperty.Register(nameof(EulaText), typeof(string),
                typeof(MyControl1), new PropertyMetadata("Default value."));
    }
}
