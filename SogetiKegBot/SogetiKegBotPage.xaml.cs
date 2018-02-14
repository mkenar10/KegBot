using System;
using Xamarin.Forms;

namespace SogetiKegBot
{
    public partial class SogetiKegBotPage : ContentPage
    {
        public SogetiKegBotPage()
        {
            InitializeComponent();

            //images
            logo.Source = ImageSource.FromFile("SogetiKegBot.Droid/Resources/drawable/logo.jpg");
            img.Source = ImageSource.FromFile("SogetiKegBot.Droid/Resources/drawable/guinness.jpg");

            //labels
            ontap.FontAttributes = FontAttributes.Italic;
            ontap.FontSize = 24;

            //onTap for Image
            var tapImage = new TapGestureRecognizer();
            tapImage.Tapped += tapImage_Tapped;
            img.GestureRecognizers.Add(tapImage);

            //add measurement of how much poured here.
            void tapImage_Tapped(object sender, EventArgs e){
                DisplayAlert("Alert","Your pour: ","OK");
            }
        }

        //public void pourBeer(object sender, EventArgs e){
           // DisplayAlert("Alert","Here is some beer!","OK");
        //}
    }
}
