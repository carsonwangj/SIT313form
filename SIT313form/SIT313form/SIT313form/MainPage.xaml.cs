using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SIT313form
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            string text = Account.Text;
            string text1 = Password.Text;
            if(Account.Text == "admin" && Password.Text =="123")
            {

                await Navigation.PushAsync(new Page1());
            }
            else
            {
                MainLabel.Text = "Sorry,Check your account";
            }
        }


        private void Button_signup(object sender, EventArgs e)
        {
            string text3 = Server.Text;
            Server.Text = "Server Busy";
        }
    }
}
