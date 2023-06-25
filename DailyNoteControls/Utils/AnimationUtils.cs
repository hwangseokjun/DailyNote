using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace DailyNoteControls.Utils
{
    public static class AnimationUtils
    {
        public static Storyboard CreateLeftPropertyStoryboard(this FrameworkElement frameworkElement, double from, double to, double millisecends) 
        {
            var storyboard = new Storyboard();

            var animation = new DoubleAnimation();
            animation.From = from;
            animation.To = to;
            animation.Duration = new Duration(TimeSpan.FromMilliseconds(millisecends));

            storyboard.Children.Add(animation);

            Storyboard.SetTarget(animation, frameworkElement);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Canvas.LeftProperty));

            return storyboard;
        }
    }
}
