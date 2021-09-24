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
using System.Data;
using BeautyShopApp.AppDataFile;

namespace BeautyShopApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public MainWindow mainWindow;

        private Label labelUser;
        private Button buttonExit;
        private Button buttonBack;

        public Auth(Label _labelUser, Button _buttonExit, Button _buttonBack)
        {
            labelUser = _labelUser;
            buttonExit = _buttonExit;
            buttonBack = _buttonBack;
            InitializeComponent();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text.Length > 0) // проверяем введён ли логин     
            {
                if (password.Password.Length > 0) // проверяем введён ли пароль         
                {             // ищем в базе данных пользователя с такими данными
                    Tuple<DataTable, bool> result = ConnectOdb.Select("SELECT * FROM dbo.user WHERE login = '" + login.Text + "' AND password = '" + password.Password + "'");
                    DataTable dt_user = result.Item1;

                    if (result.Item2 == false) { return; }
                    if (dt_user.Rows.Count > 0) // если такая запись существует       
                    {
                        CurrentUser.loginUser(Convert.ToInt32(dt_user.Rows[0][0]), dt_user.Rows[0][1].ToString(), dt_user.Rows[0][2].ToString(), dt_user.Rows[0][3].ToString());
                        MessageBox.Show("Пользователь авторизовался"); // говорим, что авторизовался        

                        FrameObj.frameMain.Navigate(new PageMain(buttonBack));

                        labelUser.Content = ("Привет! " + CurrentUser.Name + " " + CurrentUser.Surname + " (" + CurrentUser.Post + ")");
                        labelUser.Visibility = Visibility.Visible; 

                        buttonExit.Visibility = Visibility.Visible;
                        buttonBack.Visibility = Visibility.Hidden;

                    }
                    else MessageBox.Show("Пользователь не найден"); // выводим ошибку  
                }
                else MessageBox.Show("Введите пароль"); // выводим ошибку    
            }
            else MessageBox.Show("Введите логин"); // выводим ошибку
        }

        private void regin_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameMain.Navigate(new Reg(labelUser, buttonExit, buttonBack));
        }

        private void SafeTextChanged(object sender, TextChangedEventArgs e)
        {
            SafeSQLinput.SafeInput(sender, e);
        }
    }


}
