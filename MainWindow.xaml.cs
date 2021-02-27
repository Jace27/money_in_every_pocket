using MoneyInEveryPocket.Properties;
using System;
using System.Collections.Generic;
using System.Windows;

namespace MoneyInEveryPocket
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            StaticInfo.MainWindow = this;
            StaticInfo.MainFrame = this.MainFrame;
            StaticInfo.MainFrame.Navigate(new Uri("Pages/Main.xaml", UriKind.Relative));
        }
    }
}
