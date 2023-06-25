using DailyNote.Stores;
using DailyNote.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyNote.Services
{
    public class NavigationService : INavigationService
    {
        private readonly MainNavigationStore _mainNavigationStore;
        private INotifyPropertyChanged CurrentViewModel 
        {
            set => _mainNavigationStore.CurrentViewModel = value;
        }

        public NavigationService(MainNavigationStore mainNavigationStore)
        {
            _mainNavigationStore = mainNavigationStore;
        }

        public void Navigate(NavigationType navigationType)
        {
            switch (navigationType) 
            {
                case NavigationType.PostView:
                    CurrentViewModel = (ViewModelBase)App.Current.Services.GetService(typeof(PostViewModel));
                    break;

                case NavigationType.ListView:
                    CurrentViewModel = (ViewModelBase)App.Current.Services.GetService(typeof(ListViewModel));
                    break;

                case NavigationType.DetailView:
                    CurrentViewModel = (ViewModelBase)App.Current.Services.GetService(typeof(DetailViewModel));
                    break;

                default:
                    throw new ArgumentException();
            }
        }
    }
}
