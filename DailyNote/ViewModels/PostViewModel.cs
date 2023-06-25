using DailyNote.Commands;
using DailyNote.DataAccess.Models;
using DailyNote.DataAccess.Repositories;
using DailyNote.DataAccess.Services;
using DailyNote.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DailyNote.ViewModels
{
    public class PostViewModel : ViewModelBase
    {
        #region 프로퍼티
        private readonly IDiaryRepository _diaryRepository;
        private readonly IDiaryService _diaryService;
        private readonly INodeService _nodeService;

        private DateTime _selectedDate;
        private Diary _currentDiary;

        public Diary CurrentDiary
        {
            get => _currentDiary;
            set => SetProperty(ref _currentDiary, value);
        }
        public DateTime SelectedDate
        {
            get => _selectedDate;
            set => SetProperty(ref _selectedDate, value);
        }
        #endregion

        public PostViewModel(IDiaryRepository diaryRepository)
        {
            _diaryRepository = diaryRepository;
            SelectDateCommand = new RelayCommand(ExecuteSelectDate);
            SaveDiaryCommand = new RelayCommand(ExecuteSaveDiary);
            AddDirectoryCommand = new RelayCommand(ExecuteAddDirectory);
            ModifyDirectoryCommand = new RelayCommand(ExecuteModifyDirectory, CanExecuteModifyDirectory);
            RemoveDirectoryCommand = new RelayCommand(ExecuteRemoveDirectory, CanExecuteRemoveDirectory);
        }

        public ICommand SelectDateCommand { get; private set; }
        private void ExecuteSelectDate(object parameter)
        {
            // 실행할 로직을 구현합니다.
            Console.WriteLine(SelectedDate);
        }

        public ICommand SaveDiaryCommand { get; private set; }
        private void ExecuteSaveDiary(object parameter)
        {
            // 실행할 로직을 구현합니다.
        }

        public ICommand AddDirectoryCommand { get; private set; }
        private void ExecuteAddDirectory(object parameter)
        {
            // 실행할 로직을 구현합니다.
        }

        public ICommand ModifyDirectoryCommand { get; private set; }
        private void ExecuteModifyDirectory(object parameter)
        {
            // 실행할 로직을 구현합니다.
        }
        private bool CanExecuteModifyDirectory(object parameter)
        {
            // 실행 가능한지 여부를 결정하는 로직을 구현합니다.
            return true;
        }

        public ICommand RemoveDirectoryCommand { get; private set; }
        private void ExecuteRemoveDirectory(object parameter)
        {
            // 실행할 로직을 구현합니다.
        }
        private bool CanExecuteRemoveDirectory(object parameter)
        {
            // 실행 가능한지 여부를 결정하는 로직을 구현합니다.
            return true;
        }
    }
}
