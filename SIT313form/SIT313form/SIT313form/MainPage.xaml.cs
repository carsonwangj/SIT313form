﻿using System;
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

        private void Button_OnClicked(object sender, EventArgs e)
        {
            string text = MainEntry.Text;
            if(MainEntry.Text == "admin")
            {
                MainLabel.Text = "Hello" + text;
            }
            else
            {
                MainLabel.Text = "Sorry,wrong number";
            }
        }
    }
}
