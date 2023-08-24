﻿using QRBankPay.Views;
using System;
using Xamarin.Forms;

namespace QRBankPay
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ClientPage), typeof(ClientPage));
        }
        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
