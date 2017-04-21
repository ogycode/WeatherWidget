﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WeatherWidget2
{
    public partial class App : Application
    {
        public static Model.Localization Lang;
        public static Verloka.HelperLib.Settings.RegSettings Settings;

        public static void UpdateTheme(int num)
        {
            switch (num)
            {
                case 0:
                default:
                    ResourceDictionary dark = new ResourceDictionary();
                    dark.Source = new Uri("Theme\\Dark.xaml", UriKind.Relative);
                    Current.Resources.MergedDictionaries.Clear();
                    Current.Resources.MergedDictionaries.Add(dark);
                    break;
                case 1:
                    ResourceDictionary light = new ResourceDictionary();
                    light.Source = new Uri("Theme\\Light.xaml", UriKind.Relative);
                    Current.Resources.MergedDictionaries.Clear();
                    Current.Resources.MergedDictionaries.Add(light);
                    break;
            }
        }

        void AppStartup(object sender, StartupEventArgs e)
        {
            bool silent = false;
            for (int i = 0; i != e.Args.Length; ++i)
                if (e.Args[i] == "-silent")
                    silent = true;


            //INIT block
            Lang = new Model.Localization();
            Settings = new Verloka.HelperLib.Settings.RegSettings("Weather Widget 2");
            UpdateTheme(Settings.GetValue("Theme", 0));


            MainWindow mainWindow = new MainWindow();
            mainWindow.WindowState = silent ? WindowState.Minimized : WindowState.Normal;
            mainWindow.Show();
            if (silent)
                mainWindow.Hide();
        }
    }
}
