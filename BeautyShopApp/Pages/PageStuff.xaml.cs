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
    /// Логика взаимодействия для PageStuff.xaml
    /// </summary>
    public partial class PageStuff : Page
    {
        public PageStuff()
        {
            InitializeComponent();

            Tuple<DataTable, bool> result = ConnectOdb.Select("SELECT id 'ID', Name 'Имя', Surname 'Фамилия', Post 'Должность', Login 'Логин' FROM dbo.user;");
            DataTable dt_user = result.Item1;

            if (result.Item2 == false) { return; } else { dtGrid.DataContext = dt_user; }
        }

        private void dtGrid_ClickUp(object sender, MouseButtonEventArgs e)
        {
            try
            {


                DataRowView row = (DataRowView)dtGrid.SelectedItems[0];

                User.Id = Int32.Parse(row[0].ToString());
                User.Name = row[1].ToString();
                User.Surname = row[2].ToString();
                User.Post = row[3].ToString();
                User.Login = row[4].ToString();

                btnChangeUser.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnRegin_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new Reg(null, null, null));
        }

        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageStuffEdit());
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if ((bool)e.NewValue)
            {
                Tuple<DataTable, bool> result = ConnectOdb.Select("SELECT id 'ID', Name 'Имя', Surname 'Фамилия', Post 'Должность', Login 'Логин' FROM dbo.user;");
                DataTable dt_user = result.Item1;

                if (result.Item2 == false) { return; } else { dtGrid.DataContext = dt_user; }

                btnChangeUser.Visibility = Visibility.Hidden;
            }

            User.Id = 0;
            User.Name = "";
            User.Surname = "";
            User.Post = "";
            User.Login = "";
        }

    }
}
