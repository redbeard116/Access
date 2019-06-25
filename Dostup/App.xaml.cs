﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Dostup
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MainWindow main;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            main = new MainWindow();
            main.Show();
        }
    }
}
