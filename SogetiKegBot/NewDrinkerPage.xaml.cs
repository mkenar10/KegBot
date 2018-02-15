using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SogetiKegBot
{
    public partial class NewDrinkerPage : ContentPage
    {
        public NewDrinkerPage()
        {
            InitializeComponent();

            BackgroundColor = Color.Ivory;

            startdrinking.FontSize = 24;

            //CameraButton.Clicked += CameraButton_Clicked;
            //images
            logo.Source = ImageSource.FromFile("SogetiKegBot.Droid/Resources/drawable/logo.jpg");

        }

        void SaveInfo_Clicked(object sender, EventArgs e)
        {
            var firstName = firstname.Text;
            var lastName = lastname.Text;

            if(string.IsNullOrWhiteSpace(firstName)&& string.IsNullOrWhiteSpace(lastName)){
                DisplayAlert("Alert", "Great!", "OK");
            }else{
                DisplayAlert("Alert", "You must complete all areas of information.", "OK");
            }
        }


    }
}
