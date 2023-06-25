using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DailyNoteControls
{
    public class StandardButton : Button
    {
        static StandardButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StandardButton),
                new FrameworkPropertyMetadata(typeof(StandardButton)));
        }
    }
}
