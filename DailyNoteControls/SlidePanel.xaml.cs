using DailyNoteControls.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DailyNoteControls
{
    /// <summary>
    /// SlidePanel.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SlidePanel : UserControl
    {
        private Border _slider;
        private SliderState _sliderState = SliderState.Closed;
        public static readonly DependencyProperty SliderWidthProperty =
            DependencyProperty.Register(nameof(SliderWidth), typeof(double), typeof(SlidePanel), new PropertyMetadata(300d, OnSliderWidthChanged));

        public double SliderWidth
        {
            get => (double)GetValue(SliderWidthProperty);
            set => SetValue(SliderWidthProperty, value);
        }
        public double AnimationSpeed { get; set; } = 300d;

        public SlidePanel()
        {
            InitializeComponent();
            Loaded += SlidePanel_Loaded;
        }

        public void Open()
        {
            if (!(_sliderState is SliderState.Closed))
            {
                return;
            }

            _sliderState = SliderState.Opening;
            var storyboard = _slider.CreateLeftPropertyStoryboard(from: -SliderWidth, to: 0, millisecends: AnimationSpeed);
            storyboard.Completed += Storyboard_Completed;
            storyboard.Begin();
            this.BringToFront();
        }

        public void Close() 
        {
            if (!(_sliderState is SliderState.Opened))
            {
                return;
            }

            _sliderState = SliderState.Closing;
            var storyboard = _slider.CreateLeftPropertyStoryboard(from: 0, to: -SliderWidth, millisecends: AnimationSpeed);
            storyboard.Completed += Storyboard_Completed;
            storyboard.Begin();
        }

        private void Storyboard_Completed(object sender, EventArgs e)
        {
            if (_sliderState is SliderState.Opening)
            {
                _sliderState = SliderState.Opened;
            }
            else
            {
                _sliderState = SliderState.Closed;
                this.SendToBack();
            }
        }

        public void ChangeSliderLeft()
        {
            if (!(_slider is null))
            {
                Canvas.SetLeft(_slider, -SliderWidth);
            }
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _slider = (Border)GetTemplateChild("slider");
        }

        private void SlidePanel_Loaded(object sender, RoutedEventArgs e) 
        {
            this.SendToBack();
            ChangeSliderLeft();
        }

        private static void OnSliderWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) 
        {
            if (d is SlidePanel slidePanel)
            {
                slidePanel.ChangeSliderLeft();
            }
        }

        private void opacityGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
