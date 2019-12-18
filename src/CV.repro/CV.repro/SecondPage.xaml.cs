using System;
using CollectionView.repro1.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionView.repro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }
        
        private void Button_Add(object sender, EventArgs e)
        {
            App.MyCollection.Add(new Item { Name = $"{MyEntry.Text} - From 2nd page @ {DateTime.Now.ToShortTimeString()}" });
        }

        private async void Button_GoBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}