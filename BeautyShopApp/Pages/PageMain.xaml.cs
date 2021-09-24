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
using BeautyShopApp.AppDataFile;

namespace BeautyShopApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        private Button buttonBack;

        public PageMain(Button _buttonBack)
        {
            buttonBack = _buttonBack;
            InitializeComponent();
        }

        private void BtnService_Click(object sender, RoutedEventArgs e)
        {

            FrameObj.frameMain.Navigate(new PageService());
        }

        private void BtnClient_Click(object sender, RoutedEventArgs e)
        {

            FrameObj.frameMain.Navigate(new PageClient());
        }

        private void BtnCompany_Click(object sender, RoutedEventArgs e)
        {

            FrameObj.frameMain.Navigate(new PageCompany());
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {

            FrameObj.frameMain.Navigate(new PageAddProduct());
        }

        private void BtnStuff_Click(object sender, RoutedEventArgs e)
        {

            FrameObj.frameMain.Navigate(new PageStuff());
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {

            FrameObj.frameMain.Navigate(new PageProduct());
        }

        private void Grid_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Page_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Page_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void Page_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if((bool)e.NewValue)
            {
                buttonBack.Visibility = Visibility.Hidden;
            } else
            {
                buttonBack.Visibility = Visibility.Visible;
            }

            Product.id = 0;
            Product.Title = "";
            Product.Cost = 0;
            Product.Description = "";
            Product.IsActive = false;
            Product.ManufactureID = 0;
        }
    }
}
