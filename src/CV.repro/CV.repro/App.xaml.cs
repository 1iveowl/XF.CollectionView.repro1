using System;
using System.Collections.ObjectModel;
using CollectionView.repro1;
using CollectionView.repro1.Model;
using Xamarin.Forms;

namespace CollectionView.repro
{
    public partial class App : Application
    {
        public static ObservableCollection<Item> MyCollection { get; } = new ObservableCollection<Item>();

        public App()
        {

            MyCollection.Add(new Item { Name = $"Item 1 @ {DateTime.Now.ToShortTimeString()}" });
            MyCollection.Add(new Item { Name = $"Item 2 @ {DateTime.Now.ToShortTimeString()}" });

            InitializeComponent();

            MainPage = new MainPage();
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
