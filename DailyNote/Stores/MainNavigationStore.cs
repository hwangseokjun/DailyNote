using DailyNote.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyNote.Stores
{
    public class MainNavigationStore : ViewModelBase
    {
        private INotifyPropertyChanged _currentViewModel;
        public Action CurrentViewModelChanged { get; set; }

        public INotifyPropertyChanged CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                CurrentViewModelChanged?.Invoke();
                _currentViewModel = null;
            }
        }
    }
}
