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
    /// Логика взаимодействия для PageAddProduct.xaml
    /// </summary>
    public partial class PageAddProduct : Page
    {

        int logicRb = 0;

        public PageAddProduct()
        {
            InitializeComponent();

            Tuple<DataTable, bool> result = ConnectOdb.Select("SELECT * FROM dbo.manufacturer;");
            DataTable dt = result.Item1;

            if (result.Item2 == false) { return; }

            List<DataRow> list = new List<DataRow>();

            foreach (DataRow dr in dt.Rows)
            {
                CmbxOwner.Items.Add(dr[1]);
            }


            CmbxOwner.SelectedIndex = 0;
            RbActive.IsChecked = true;

        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (RbActive.IsChecked == true)
            {
                logicRb = 1;
            }
            else
            {
                logicRb = 0;
            }

            if (TxtTitle.Text.Length <= 0 || TxtDescription.Text.Length <= 0 || TxtCost.Text.Length <= 0)
            {
                return;
            }

            ConnectOdb.Select("INSERT INTO `dbo`.`product` (`Title`, `Cost`, `Description`, `IsActive`, `ManufacturerID`) VALUES ( '" + TxtTitle.Text + "','" + TxtCost.Text + "','" + TxtDescription.Text + "','" + logicRb.ToString() + "','" + (CmbxOwner.SelectedIndex + 1).ToString() + "');");
            MessageBox.Show("Данные успешно добавлены!", "Уведомление");
        }

        private void SafeTextChanged(object sender, TextChangedEventArgs e)
        {
            SafeSQLinput.SafeInput(sender, e);
        }

    }
}
