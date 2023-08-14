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
        double ribbingSizeInCentimeters = 2.5;

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

            ShoeSize.ItemsSource = shoeSize;
            
        }

        private void Calculat_Click(object sender, RoutedEventArgs e)
        {
            CreateNewSockController createNewSockController = new CreateNewSockController();
            createNewSockController.CarryPattern(mask, needle, shoeSize[6], ribbingSizeInCentimeters);
        }

        //Godt note til mig selv:
        //nedestående kode kan finde ud af at fortælle hvad der står i min listbox på et bestemt index
        //Jeg skal have fat i mit resultat og føre det med vidre til min knap hvor jeg pt statisk har noteret "43" for sko str. 
        //bed Mikkel om hjælp til dette onsdag
        private void ShoeSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem lbi = (ListBoxItem) (ShoeSize.ItemContainerGenerator.ContainerFromIndex(0));

            Debug.WriteLine("The contents of the item at index 0 are: " + (lbi.Content.ToString()) + ".");
        }
    }
}
