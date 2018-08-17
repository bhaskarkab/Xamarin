using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 0.5;
        }

        //void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        //{
        //    lblTitle.Text = String.Format("Value is {0:F2}", e.NewValue);
        //}
    }
}
