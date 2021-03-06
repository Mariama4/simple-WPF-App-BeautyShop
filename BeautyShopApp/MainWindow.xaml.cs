using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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
using BeautyShopApp.Pages;
using BeautyShopApp.AppDataFile;
using MySql.Data.MySqlClient;

namespace BeautyShopApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            FrameObj.frameMain = FrmMain;

            FrmMain.Navigate(new Auth(lblUser,btnExit,btnBack));
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (FrameObj.frameMain.CanGoBack)
            {
                FrameObj.frameMain.GoBack();

                if (FrameObj.frameMain.Content.ToString() == "BeautyShopApp.Pages.PageMain")
                {
                    btnBack.Visibility = Visibility.Hidden;
                }
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            CurrentUser.ExitUser(CurrentUser.Id);
            this.Close();
        }

        private void Window_Activated(object sender, EventArgs e)
        {

        }
        

        public static void RaiseExectionErrorInSQL()
        {
            MessageBox.Show("Ошибка! Повторите действие!");
        }
    }
}
