using ItSocks.Controller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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

            ManchetIMG();
            ShaftIMG();
            HeelMG();
            SoelIMG();
            ToeIMG();

        }
        public void ManchetIMG()
        {
            for (int i = 0; i < 5; i++)
            {
                Image im = new Image();
                im.Height = 50;
                im.Width = 50;
                im.Source = new BitmapImage(new Uri(@"C:\Users\CKU\Documents\Skole\H5\Prøve-Svendeprøve\ItSocks\ItSocks\Img\placeholder.png"));
                Manchet.Children.Add(im);
            }
        }

        public void ShaftIMG()
        {
            for (int i = 0; i < 5; i++)
            {
                Image im = new Image();
                im.Height = 50;
                im.Width = 50;
                im.Source = new BitmapImage(new Uri(@"C:\Users\CKU\Documents\Skole\H5\Prøve-Svendeprøve\ItSocks\ItSocks\Img\placeholder.png"));
                Shaft.Children.Add(im);
            }
        }

        public void HeelMG()
        {
            for (int i = 0; i < 10; i++)
            {
                Image im = new Image();
                im.Height = 50;
                im.Width = 50;
                im.Source = new BitmapImage(new Uri(@"C:\Users\CKU\Documents\Skole\H5\Prøve-Svendeprøve\ItSocks\ItSocks\Img\placeholder.png"));
                Heel.Children.Add(im);
            }
        }

        public void SoelIMG()
        {
            for (int i = 0; i < 10; i++)
            {
                Image im = new Image();
                im.Height = 50;
                im.Width = 50;
                im.Source = new BitmapImage(new Uri(@"C:\Users\CKU\Documents\Skole\H5\Prøve-Svendeprøve\ItSocks\ItSocks\Img\placeholder.png"));
                Soel.Children.Add(im);
            }
        }

        public void ToeIMG()
        {
            for (int i = 0; i < 10; i++)
            {
                Image im = new Image();
                im.Height = 50;
                im.Width = 50;
                im.Source = new BitmapImage(new Uri(@"C:\Users\CKU\Documents\Skole\H5\Prøve-Svendeprøve\ItSocks\ItSocks\Img\placeholder.png"));
                Toe.Children.Add(im);
            }
        }
        private void Calculat_Click(object sender, RoutedEventArgs e)
        {
            //sizeOfShoe have to be selected by the user, other wise the code will braek. i have to set a default sulution on it so i doesnt braek
            int sizeOfShoe = (int)ShoeSize.SelectedItem;
            int masks = Convert.ToInt32(Masks.Text);
            int rows = Convert.ToInt32(Rows.Text);
            double cuffSizeInCentimeters = Convert.ToInt32(slValueCuff.Value);

            CreateSockController createSockController = new CreateSockController();
            createSockController.CreatePattern(masks, rows, sizeOfShoe, cuffSizeInCentimeters);
            
        }
    }
}
