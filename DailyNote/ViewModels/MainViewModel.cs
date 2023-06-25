using DailyNote.Commands;
using DailyNote.DataAccess.Values;
using DailyNote.Models;
using DailyNote.Properties;
using DailyNote.Services;
using DailyNote.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace DailyNote.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        #region 프로퍼티
        private readonly MainNavigationStore _mainNavigationStore;
        private INotifyPropertyChanged _currentViewModel;
        public INotifyPropertyChanged CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        private ObservableCollection<Category> _categories;
        public ObservableCollection<Category> Categories
        {
            get => _categories;
            set => SetProperty(ref _categories, value);
        }

        private Category _selectedCategory;
        public Category SelectedCategory
        {
            get => _selectedCategory;
            set => SetProperty(ref _selectedCategory, value);
        }

        private string _newCategoryName = string.Empty;
        public string NewCategoryName
        {
            get => _newCategoryName;
            set => SetProperty(ref _newCategoryName, value);
        }
        #endregion

        public MainViewModel(MainNavigationStore mainNavigationStore, INavigationService navigationService)
        {
            _mainNavigationStore = mainNavigationStore;
            _mainNavigationStore.CurrentViewModelChanged += CurrentViewModelChanged;
            navigationService.Navigate(NavigationType.PostView);
            Categories = new ObservableCollection<Category>();

            // 테스트용
            var node1 = new Category { Id = null, Name = "2020" };
            node1.OnSelected += Category_OnSelected;
            var node2 = new Category { Id = null, Name = "2021" };
            node2.OnSelected += Category_OnSelected;
            var node3 = new Category { Id = null, Name = "2022" };
            node3.OnSelected += Category_OnSelected;
            Categories.Add(node1);
            Categories.Add(node2);
            Categories.Add(node3);
            //

            HelpCommand = new RelayCommand(ExecuteHelp);
            AddCategoryCommand = new RelayCommand(ExecuteAddCategory, CanExecuteAddCategory);
            ModifyCategoryCommand = new RelayCommand(ExecuteModifyCategory);
            DeleteCategoryCommand = new RelayCommand(ExecuteDeleteCategory);
        }

        private void Category_OnSelected(Category self)
        {
            Console.WriteLine($"선택됨 {self.Name}");
        }

        private void CurrentViewModelChanged()
        {
            CurrentViewModel = _mainNavigationStore.CurrentViewModel;
        }

        public ICommand HelpCommand { get; private set; }
        private void ExecuteHelp(object parameter)
        {
            Console.WriteLine("질문 안받습니다.");
        }

        public ICommand AddCategoryCommand { get; private set; }
        private void ExecuteAddCategory(object parameter)
        {
            Categories.Add(new Category { Id = null, Name = NewCategoryName });
            NewCategoryName = string.Empty;
        }
        private bool CanExecuteAddCategory(object parameter)
        {
            return NewCategoryName != string.Empty;
        }

        public ICommand ModifyCategoryCommand { get; private set; }
        private void ExecuteModifyCategory(object parameter)
        {
            // 실행할 로직을 구현합니다.
        }

        public ICommand DeleteCategoryCommand { get; private set; }
        private void ExecuteDeleteCategory(object parameter)
        {
            // 실행할 로직을 구현합니다.
        }
    }
}
