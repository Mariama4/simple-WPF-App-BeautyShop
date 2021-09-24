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
    /// Логика взаимодействия для PageClient.xaml
    /// </summary>
    public partial class PageClient : Page
    {
        public PageClient()
        {
            InitializeComponent();

            Tuple<DataTable, bool> result = ConnectOdb.Select("SELECT id 'ID', FirstName 'Имя', LastName 'Фамилия', Patronymic 'Отчество', Birthday 'День Рождения', RegistrationDate 'Дата Регистрации', Email 'Почта', Phone 'Номер телефона', GenderCode 'Пол' FROM dbo.client;");
            DataTable dt_user = result.Item1;

            if (result.Item2 == false) { return; } else { dtGrid.DataContext = dt_user; }
        }

        private void dtGrid_ClickUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
