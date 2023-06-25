using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DailyNoteControls
{
    public class StandardDataGrid : DataGrid
    {
        static StandardDataGrid()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(StandardDataGrid),
                new FrameworkPropertyMetadata(typeof(StandardDataGrid)));
        }
    }
}
