using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionView.repro;
using CollectionView.repro1.Model;
using Xamarin.Forms;

namespace CollectionView.repro1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        // private ObservableCollection<Item> MyPageCollection { get; set; } 

        public MainPage()
        {
            InitializeComponent();

            MyCollectionView.ItemsSource = App.MyCollection;
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            App.MyCollection.Add(new Item { Name = $"{MyEntry.Text} @ {DateTime.Now.ToShortTimeString()}" });
        }

        private async void Button_GotoSecondPage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SecondPage());
        }
    }
}
