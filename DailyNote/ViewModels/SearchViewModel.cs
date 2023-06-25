using DailyNote.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DailyNote.ViewModels
{
    public class SearchViewModel : ViewModelBase
    {
        public SearchViewModel()
        {
            ShowDetailsCommand = new RelayCommand(ExecuteShowDetails, CanExecuteShowDetails);
            RemoveCommand = new RelayCommand(ExecuteRemove, CanExecuteRemove);
        }

        public ICommand ShowDetailsCommand { get; private set; }
        private void ExecuteShowDetails(object parameter)
        {
            // 실행할 로직을 구현합니다.
        }
        private bool CanExecuteShowDetails(object parameter)
        {
            // 실행 가능한지 여부를 결정하는 로직을 구현합니다.
            return true;
        }

        public ICommand RemoveCommand { get; private set; }
        private void ExecuteRemove(object parameter)
        {
            // 실행할 로직을 구현합니다.
        }
        private bool CanExecuteRemove(object parameter)
        {
            // 실행 가능한지 여부를 결정하는 로직을 구현합니다.
            return true;
        }
    }
}
