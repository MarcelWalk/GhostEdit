using HandyControl.Data;
using System;
using System.Windows;
using System.Windows.Controls;

namespace GhostEdit
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (((Button)sender).Content.ToString().ToLower())
            {
                case "new":
                    break;
                case "open":
                    break;
                case "save":
                    break;
                case "publish":
                    break;
                default:
                    break;
            }
        }
    }
}
