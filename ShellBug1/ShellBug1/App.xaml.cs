using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ShellBug1.Services;
using ShellBug1.Views;

namespace ShellBug1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
