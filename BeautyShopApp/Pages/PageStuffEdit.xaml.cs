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
using System.Data;
using BeautyShopApp.AppDataFile;

namespace BeautyShopApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageStuffEdit.xaml
    /// </summary>
    public partial class PageStuffEdit : Page
    {
        public PageStuffEdit()
        {
            InitializeComponent();
        }

        private void SafeTextChanged(object sender, TextChangedEventArgs e)
        {
            SafeSQLinput.SafeInput(sender, e);
        }

        private void btnUpdateUser_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
