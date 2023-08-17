using ItSocks.Controller;
using System;
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
            int sizeOfShoe = (int)ShoeSize.SelectedItem;
            int masks = Convert.ToInt32(Masks.Text);
            int rows = Convert.ToInt32(Rows.Text);
            
            //Some of the will come from UI and some is from Backend in the calculator(CreateNewSockController)
            double cuffSizeInCentimeters = 2.5;
            int countOfMasksInTheMiddel = 10;
            int roundsForToe = 17;
            int maskOnHeel = 30;

            CreateNewSockController createNewSockController = new CreateNewSockController();
            createNewSockController.CarryPattern(masks, rows, sizeOfShoe, cuffSizeInCentimeters, countOfMasksInTheMiddel, roundsForToe, maskOnHeel);

            Debug.WriteLine(masks);
            
        }

        
    }
}
