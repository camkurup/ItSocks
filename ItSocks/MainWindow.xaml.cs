using ItSocks.Controller;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace ItSocks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> shoeSize = new List<int>();
        int mask = 24;
        int rows = 32;
        double cuffSizeInCentimeters = 2.5;
        int countOfMasksInTheMiddel = 10;
        int roundsForToe = 17;

        int maskOnHeel = 30;


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
            createNewSockController.CarryPattern(mask, rows, shoeSize[6], cuffSizeInCentimeters, countOfMasksInTheMiddel, roundsForToe, maskOnHeel);
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
