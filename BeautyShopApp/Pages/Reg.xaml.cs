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
using System.Windows.Shapes;
using BeautyShopApp.AppDataFile;
using System.Data;

namespace BeautyShopApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Page
    {
        public MainWindow mainWindow;

        private Label labelUser;
        private Button buttonExit;
        private Button buttonBack;

        public Reg(Label _labelUser, Button _buttonExit, Button _buttonBack)
        {
            labelUser = _labelUser;
            buttonExit = _buttonExit;
            buttonBack = _buttonBack;



            InitializeComponent();
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text.Length > 0) // проверяем логин
                {
                if (password.Password.Length > 0) // проверяем пароль
	                {
                    if (password_Copy.Password.Length > 0) // проверяем второй пароль
		                {
                        if (password.Password == password_Copy.Password) // проверка на совпадение паролей
                        {
                            if (name.Text.Length > 0)
                            {
                                if (surname.Text.Length > 0)
                                {
                                    ConnectOdb.Select("INSERT INTO `dbo`.`user` (`Name`, `Surname`, `Post`, `Login`, `Password`) VALUES ('" + login.Text + "','" + surname.Text + "','" + (post.SelectionBoxItem.ToString()) + "','" + login.Text + "','" + password.Password + "');");
                                    MessageBox.Show("Пользователь зарегистрирован");
                                    if (labelUser != null)
                                    {
                                        FrameObj.frameMain.Navigate(new Auth(labelUser, buttonExit, buttonBack));
                                    } else
                                    {
                                        FrameObj.frameMain.GoBack();
                                    }
                                }
                                else MessageBox.Show("Укажите фамилию");
                            }
                            else MessageBox.Show("Укажите имя");
                        }
                        else MessageBox.Show("Пароли не совподают");
                        }
                    else MessageBox.Show("Повторите пароль");
                    }
                else MessageBox.Show("Укажите пароль");
                }
            else MessageBox.Show("Укажите логин");
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (labelUser != null)
            {
                FrameObj.frameMain.Navigate(new Auth(labelUser, buttonExit, buttonBack));
            }
            else
            {
                FrameObj.frameMain.GoBack();
            }

        }

        private void SafeTextChanged(object sender, TextChangedEventArgs e)
        {
            SafeSQLinput.SafeInput(sender, e);
        }
    }
}
