using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DailyNoteControls
{
    public class StandardTextBox : TextBox
    {
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(StandardTextBox), new PropertyMetadata(null));
        public static readonly DependencyProperty PlaceHolderProperty =
            DependencyProperty.Register(nameof(PlaceHolder), typeof(string), typeof(StandardTextBox), new PropertyMetadata("Please input text.."));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
        public string PlaceHolder
        {
            get => (string)GetValue(PlaceHolderProperty);
            set => SetValue(PlaceHolderProperty, value);
        }

        static StandardTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StandardTextBox),
                new FrameworkPropertyMetadata(typeof(StandardTextBox)));
        }
    }
}
