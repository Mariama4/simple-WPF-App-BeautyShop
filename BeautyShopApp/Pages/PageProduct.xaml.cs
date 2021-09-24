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
using BeautyShopApp.AppDataFile;
using BeautyShopApp.Pages;
using System.Windows.Threading;

namespace BeautyShopApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageProduct.xaml
    /// </summary>
    public partial class PageProduct : Page
    {

        public PageProduct()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
            timer.Start();
        }

        public void UpdateData(object sender, object e) 
        {
            Tuple<DataTable, bool> result;

            if (TxtSearch.Text.Length <= 0)
            {
                result = ConnectOdb.Select("SELECT id 'ID', Title 'Название', Cost 'Стоимость', Description 'Описание' ,IsActive 'Доступность', ManufacturerID 'Номер производителя' FROM dbo.product;");
            }
            else
            {
                result = ConnectOdb.Select("SELECT id 'ID', Title 'Название', Cost 'Стоимость', Description 'Описание' ,IsActive 'Доступность', ManufacturerID 'Номер производителя' FROM dbo.product WHERE product.Title LIKE '" + TxtSearch.Text + "%' OR product.Description LIKE '" + TxtSearch.Text + "%';");
            }

            DataTable dt_user = result.Item1;

            if (result.Item2 == false) { return; } else { dtGrid.DataContext = dt_user; }

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageEditNew((sender as Button).DataContext as Product));
        }

        private void BtnSalehistory_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new PageSalehistory((sender as Button).DataContext as Product));
        }

        private bool boolConvertor(int val)
        {
            return (val == 1);
        }

        private void dtGrid_ClickUp(object sender, MouseButtonEventArgs e)
        {
            try
            {


                DataRowView row = (DataRowView)dtGrid.SelectedItems[0];

                Product.id = Int32.Parse(row[0].ToString());
                Product.Title = row[1].ToString();
                Product.Cost = Int32.Parse(row[2].ToString());
                Product.Description = row[3].ToString();
                Product.IsActive = boolConvertor(Int32.Parse(row[4].ToString()));
                Product.ManufactureID = Int32.Parse(row[5].ToString());


                lblTitleProduct.Content = "Товар: " + Product.Title + " (" + Product.Description + ")";

                btnEdit.Visibility = Visibility.Visible;
                btnSalehistory.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {

            }
        }

        private void Grid_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void SafeTextChanged(object sender, TextChangedEventArgs e)
        {
            SafeSQLinput.SafeInput(sender, e);
        }
    }
}
