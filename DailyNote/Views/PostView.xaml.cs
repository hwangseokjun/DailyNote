using DailyNote.Properties;
using ICSharpCode.AvalonEdit.Editing;
using Microsoft.Win32;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DailyNote.Views
{
    /// <summary>
    /// DiaryView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PostView : UserControl
    {
        private string _currentFileName;

        public PostView()
        {
            InitializeComponent();
            textEditor.TextArea.Caret.PositionChanged += Caret_PositionChanged;
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = Settings.Default.FILE_FILTER;

            if (openFileDialog.ShowDialog() ?? false)
            {
                _currentFileName = openFileDialog.FileName;
                textEditor.Load(_currentFileName);
            }
        }

        private void SaveFileButton_Click(object sender, RoutedEventArgs e)
        {
            if (_currentFileName is null)
            {
                var saveFileDialog = new SaveFileDialog();

                saveFileDialog.DefaultExt = ".txt";
                saveFileDialog.Filter = Settings.Default.FILE_FILTER;

                if (saveFileDialog.ShowDialog() ?? false)
                {
                    _currentFileName = saveFileDialog.FileName;
                }
                else
                {
                    return;
                }

                textEditor.Save(_currentFileName);
            }
        }

        private void Caret_PositionChanged(object sender, EventArgs e)
        {
            Caret caret = textEditor.TextArea.Caret;
            int line = caret.Line;
            int column = caret.Column;

            caretInfoTextBlock.Text = $"Ln: {line}, Col: {column}";
        }
    }
}
