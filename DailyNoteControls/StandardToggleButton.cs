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
        static StandardToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StandardToggleButton),
                new FrameworkPropertyMetadata(typeof(StandardToggleButton)));
        }
    }
}
