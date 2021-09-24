using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using BeautyShopApp.AppDataFile;

namespace BeautyShopApp
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            if (CurrentUser.Id != 0)
            {
                CurrentUser.ExitUser(CurrentUser.Id);
            }
        }
    }
}
