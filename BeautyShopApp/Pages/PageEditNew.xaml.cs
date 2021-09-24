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
    /// Логика взаимодействия для PageEditNew.xaml
    /// </summary>
    public partial class PageEditNew : Page
    {
        int logicRb = 0;

        public PageEditNew(Product product)
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
            TxtTitle.Text = Product.Title;
            TxtCost.Text = Product.Cost.ToString();
            TxtDescription.Text = Product.Description;
            if (Product.IsActive != false)
            {
                RbActive.IsChecked = true;
                logicRb = 1;
            }
            else
            {
                RbNotActive.IsChecked = true;
                logicRb = 0;
            }
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

            Tuple<DataTable, bool> result = ConnectOdb.Select("UPDATE `dbo`.`product` SET `Title` = '" + TxtTitle.Text + "', `Cost` = '" + TxtCost.Text + "', `Description` = '" + TxtDescription.Text + "', `IsActive` = '" + logicRb.ToString() + "', `ManufacturerID` = '" + (CmbxOwner.SelectedIndex + 1).ToString() + "' WHERE (`id` = '" + Product.id.ToString() + "');");
            DataTable dt = result.Item1;

            if (result.Item2 == false) { return; } else { MessageBox.Show("Данные успешно изменены!", "Уведомление"); }
        }

        private void SafeTextChanged(object sender, TextChangedEventArgs e)
        {
            SafeSQLinput.SafeInput(sender, e);
        }
    }
}
