using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace DailyNoteControls
{
    public class StandardToggleButton : ToggleButton
    {
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(StandardToggleButton), new PropertyMetadata(null));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        static StandardToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StandardToggleButton),
                new FrameworkPropertyMetadata(typeof(StandardToggleButton)));
        }
    }
}
