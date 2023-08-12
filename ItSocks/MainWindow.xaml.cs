using ItSocks.Controller;
using System;
using System.Collections.Generic;
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
        List<string> shoeSize = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            shoeSize.Add("43");
            ShoeSize.ItemsSource= shoeSize;
            
        }

        private void Calculat_Click(object sender, RoutedEventArgs e)
        {
            CreateNewSockController createNewSockController = new CreateNewSockController();
            createNewSockController.CarryPattern(24, 32, 43);
        }
    }
}
