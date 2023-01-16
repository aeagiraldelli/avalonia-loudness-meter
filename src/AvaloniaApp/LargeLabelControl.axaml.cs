using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace AvaloniaApp
{
    public class LargeLabelControl : TemplatedControl
    {
        public static readonly StyledProperty<string> LargeTextProperty = AvaloniaProperty.Register<LargeLabelControl, string>(nameof(LargeText), "-31.3 LUFS");
        public string LargeText 
        {
            get => GetValue(LargeTextProperty); 
            set => SetValue(LargeTextProperty, value); 
        }

        public static readonly StyledProperty<string> SmallTextProperty = AvaloniaProperty.Register<LargeLabelControl, string>(nameof(SmallText), "SHORT TERM");
        public string SmallText
        {
            get => GetValue(SmallTextProperty);
            set => SetValue(SmallTextProperty, value);
        }
    }
}
