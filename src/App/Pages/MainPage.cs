﻿using System;
using Bit.App.Resources;
using Xamarin.Forms;

namespace Bit.App.Pages
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            var settingsNavigation = new NavigationPage(new SettingsPage());
            var vaultNavigation = new NavigationPage(new VaultListPage());
            var syncPage = new SyncPage();

            vaultNavigation.BarBackgroundColor = settingsNavigation.BarBackgroundColor = Color.FromHex("3c8dbc");
            vaultNavigation.BarTextColor = settingsNavigation.BarTextColor = Color.FromHex("ffffff");

            vaultNavigation.Title = AppResources.MyVault;
            vaultNavigation.Icon = "fa-lock";

            settingsNavigation.Title = AppResources.Settings;
            settingsNavigation.Icon = "fa-cogs";

            Children.Add(vaultNavigation);
            Children.Add(syncPage);
            Children.Add(settingsNavigation);
        }
    }
}
