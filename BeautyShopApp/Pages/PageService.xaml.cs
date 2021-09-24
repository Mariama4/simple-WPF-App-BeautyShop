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
    /// Логика взаимодействия для PageService.xaml
    /// </summary>
    public partial class PageService : Page
    {
        public PageService()
        {
            InitializeComponent();

            Tuple<DataTable, bool> result = ConnectOdb.Select("SELECT id 'ID', Title 'Название', Cost 'Цена', DurationInSeconds 'Время выполнения в секундах', Description 'Описание', Discount 'Скидка' FROM dbo.service;");
            DataTable dt_user = result.Item1;

            if (result.Item2 == false) { return; } else { dtGrid.DataContext = dt_user; }
        }
    }
}
