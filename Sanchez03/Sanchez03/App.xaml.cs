using Sanchez03.DataContext;
using Sanchez03.Interfaces;
using Sanchez03.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sanchez03
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            GetContext().Database.EnsureCreated();
            MainPage = new MatriculasView();
        }
        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
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
