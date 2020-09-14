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
            UpdateSkin(SkinType.Dark);
        }
        internal void UpdateSkin(SkinType skin)
        {
            Resources.MergedDictionaries.Clear();
            Resources.MergedDictionaries.Add(new ResourceDictionary
            {
                Source = new Uri($"pack://application:,,,/HandyControl;component/Themes/Skin{skin.ToString()}.xaml")
            });
            Resources.MergedDictionaries.Add(new ResourceDictionary
            {
                Source = new Uri("pack://application:,,,/HandyControl;component/Themes/Theme.xaml")
            });
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            switch (((MenuItem)sender).Header)
            {
                default:
                    Console.WriteLine(((MenuItem)sender).Header + " clicked!");
                    break;
            }
        }
    }
}
