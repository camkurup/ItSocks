using ItSocks.Controller;
using ItSocks.Model;
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
            slValueCuff.Visibility = Visibility.Collapsed;
            slValueShaft.Visibility = Visibility.Collapsed;

            ShoeSize.ItemsSource = shoeSize;
            
            //This shows imgages on every moduel.
            //But it aint in use yet and therefor I desided that I will keep it off until it's needed
            //ManchetIMG();
            //ShaftIMG();
            //HeelMG();
            //SoelIMG();
            //ToeIMG();
        }

        public void ManchetIMG()
        {
            for (int i = 0; i < 4; i++)
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
            for (int i = 0; i < 4; i++)
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
            for (int i = 0; i < 6; i++)
            {
                Image im = new Image();
                im.Height = 50;
                im.Width = 50;
                im.Source = new BitmapImage(new Uri(@"C:\Users\CKU\Documents\Skole\H5\Prøve-Svendeprøve\ItSocks\ItSocks\Img\placeholder.png"));
                //Heel.Children.Add(im);
            }
        }

        public void SoelIMG()
        {
            for (int i = 0; i < 6; i++)
            {
                Image im = new Image();
                im.Height = 50;
                im.Width = 50;
                im.Source = new BitmapImage(new Uri(@"C:\Users\CKU\Documents\Skole\H5\Prøve-Svendeprøve\ItSocks\ItSocks\Img\placeholder.png"));
                //Soel.Children.Add(im);
            }
        }

        public void ToeIMG()
        {
            for (int i = 0; i < 6; i++)
            {
                Image im = new Image();
                im.Height = 50;
                im.Width = 50;
                im.Source = new BitmapImage(new Uri(@"C:\Users\CKU\Documents\Skole\H5\Prøve-Svendeprøve\ItSocks\ItSocks\Img\placeholder.png"));
                //Toe.Children.Add(im);
            }
        }
        private void Calculat_Click(object sender, RoutedEventArgs e)
        {
            //sizeOfShoe have to be selected by the user, other wise the code will braek. i have to set a default sulution on it so i doesnt braek
            int sizeOfShoe = (int)ShoeSize.SelectedItem;
            int masks = Convert.ToInt32(Masks.Text);
            int rows = Convert.ToInt32(Rows.Text);
            double cuffSizeInCentimeters = Convert.ToInt32(slValueCuff.Value);
            double lengthOShaft = Convert.ToInt32(slValueShaft.Value);

            SockController createSockController = new SockController();
            createSockController.CreatePattern(masks, rows, sizeOfShoe, cuffSizeInCentimeters, lengthOShaft);            
        }

        #region InputChanged

        private async void SockCreated(object? sender, EventArgs e)
        {
            //My idea is that this should not have static text but it should refere to my "PatternTemplate"
            PatternTemplate sockTemplate = new PatternTemplate();
            SockEventArgs sockEventArgs = (SockEventArgs)e;

            //the staic numbers below is calculated after the method as run i PatternTemplate.
            //that will mean that it wil show the PatternTemplate methode first then right after the 2 from the static calculation.
            //This aint good enough, but I have not prioritised this bug high enough to do something about it 
            lbl_Cuff.Content = await sockTemplate.CuffTemplate(0, 0) + sockEventArgs.Sock.Cuff;
            lbl_Shaft.Content = await sockTemplate.ShaftTemplate() + sockEventArgs.Sock.Shaft;
            lbl_Heel.Content = await sockTemplate.HeelTemplate() + sockEventArgs.Sock.Heel;
            lbl_Soel.Content = await sockTemplate.SoelTemplate() + sockEventArgs.Sock.Soel;
            lbl_Toe.Content = await sockTemplate.ToeTemplate() + sockEventArgs.Sock.Toe;
        }

        private void InputChanged()
        {
            try
            {
                if (ShoeSize.SelectedItem != null)
                {
                    int sizeOfShoe = (int)ShoeSize.SelectedItem;
                    int masks = Convert.ToInt32(Masks.Text);
                    int rows = Convert.ToInt32(Rows.Text);
                    double cuffSizeInCentimeters = Convert.ToInt32(slValueCuff.Value);
                    double lengthOShaft = Convert.ToInt32(slValueShaft.Value);

                    if (sizeOfShoe > 0 && masks > 0 && rows > 0)
                    {
                        SockController createSockController = new SockController();
                        createSockController.SockCalculated += SockCreated;
                        createSockController.CreatePattern(masks, rows, sizeOfShoe, cuffSizeInCentimeters, lengthOShaft);
                    }
                }
            }
            catch
            {
                //empty Catch
            }
        }

        //look into thius later: after the first calculation it does not ecexute on "Mask_TextChanged" but it does on "Rows_TextChanged"
        //have not yet testet other than thoes two
        private void Masks_TextChanged(object sender, TextChangedEventArgs e)
        {
            InputChanged();
        }

        private void Rows_TextChanged(object sender, TextChangedEventArgs e)
        {
            InputChanged();
        }

        private void ShoeSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InputChanged();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            InputChanged();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            InputChanged();
        }

        #endregion
    }
}
