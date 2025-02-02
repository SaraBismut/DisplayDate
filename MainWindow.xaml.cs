﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DisplayDate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int x = 5;
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded; 
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DateLabel.Content = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}