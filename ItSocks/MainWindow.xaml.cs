using ItSocks.Controller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ItSocks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> shoeSize = new List<int>();
        int mask = 24;
        int needle = 32;

        int numberOfMAsks = 0;
        public MainWindow()
        {
            InitializeComponent();
            shoeSize.Add(37);
            shoeSize.Add(38); 
            shoeSize.Add(39);
            shoeSize.Add(40);
            shoeSize.Add(41);
            shoeSize.Add(42);
            shoeSize.Add(43);
            shoeSize.Add(44);
            shoeSize.Add(45);
            shoeSize.Add(46);

            ShoeSize.ItemsSource= shoeSize;
            
        }

        private void Calculat_Click(object sender, RoutedEventArgs e)
        {
            CreateNewSockController createNewSockController = new CreateNewSockController();
            createNewSockController.CarryPattern(mask, needle, 43);
        }

        private void ShoeSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //ListBoxItem lbi = (ListBoxItem) (ShoeSize.ItemContainerGenerator.ContainerFromIndex(0));
            ListBoxItem lbi = (ListBoxItem)(ShoeSize.ItemContainerGenerator.ContainerFromIndex(0));


            Debug.WriteLine("The contents of the item at index 0 are: " + (lbi.Content.ToString()) + ".");
        }

        private void NumberOfMAsks_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
