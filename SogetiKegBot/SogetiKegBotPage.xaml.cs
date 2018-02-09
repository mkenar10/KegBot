using System;
using Xamarin.Forms;

namespace SogetiKegBot
{
    public partial class SogetiKegBotPage : ContentPage
    {
        public SogetiKegBotPage()
        {
            InitializeComponent();

            image.Source = ImageSource.FromFile("SogetiKegBot.Droid/Resources/drawable/spade.jpg");

            //var btn = this.FindByName<Button>("button");
        }

        public void pourBeer(object sender, EventArgs e){
            DisplayAlert("Alert","Here is some beer!","OK");
        }
    }
}
