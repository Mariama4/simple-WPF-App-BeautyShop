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
using System.Data;

namespace BeautyShopApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageSalehistory.xaml
    /// </summary>
    public partial class PageSalehistory : Page
    {
        public PageSalehistory(Product product)
        {
            InitializeComponent();

            lblTitleProduct.Content = "Товар: " + Product.Title;

            Tuple<DataTable, bool> result = ConnectOdb.Select("SELECT id 'ID', SaleDate 'Дата продажи', ProductID 'ID продукта', Quantity 'Количество', ClientServiceID 'ID документа' FROM dbo.productsale WHERE ProductID = '" + Product.id + "';");
            DataTable dt_user = result.Item1;

            if (result.Item2 == false) { return; } else { dtGrid.DataContext = dt_user; }
        }
    }
}
