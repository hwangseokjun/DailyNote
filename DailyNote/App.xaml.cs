using DailyNote.DataAccess.Repositories;
using DailyNote.Services;
using DailyNote.Stores;
using DailyNote.ViewModels;
using DailyNote.Views;
using Dapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DailyNote
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;
        public IServiceProvider Services { get; }

        public App()
        {
            DefaultTypeMap.MatchNamesWithUnderscores = true;
            Services = ConfigureServices();
            var mainView = Services.GetRequiredService<MainView>();
            mainView.Show();
        }

        private IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Stores
            services.AddSingleton<MainNavigationStore>();

            // Services
            services.AddSingleton<INavigationService, NavigationService>();

            // DataServices
            

            // Repositories
            services.AddSingleton<IDiaryRepository, DiaryRepository>();

            // ViewModels
            services.AddSingleton<PostViewModel>();
            services.AddSingleton<SearchViewModel>();
            services.AddSingleton<MainViewModel>();
            
            // Views
            services.AddSingleton(s => new PostView 
            { 
                DataContext = s.GetRequiredService<PostViewModel>()
            });
            services.AddSingleton(s => new SearchView 
            { 
                DataContext = s.GetRequiredService<SearchViewModel>()
            });
            services.AddSingleton(s => new MainView
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            return services.BuildServiceProvider();
        }
    }
}
