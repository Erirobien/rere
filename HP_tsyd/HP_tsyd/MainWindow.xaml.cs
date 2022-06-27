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

namespace HP_tsyd
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      //  HPDBEntities context;

        public MainWindow()
        {
            InitializeComponent();
      //      context = new HPDBEntities();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int idworker = Convert.ToInt32(login.Text);
                int pass = Convert.ToInt32(password.Text);

          ////      Worker worker = context.Worker.ToList().Find(x => x.idWorker==idworker);
          //      if (worker == null)
          //      {
          //          MessageBox.Show("Работника с таким логином не существует!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
          //      }
          //      else
               // {
                   //if (worker.password.Equals(pass))
                   // {
                   //     MessageBox.Show("Успешная авторизация!", "Успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                   //     password.Background=Brushes.LightGreen; 
                   // }
                  //  else
                  //  {
                        MessageBox.Show("Пароли не совпадают", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                        password.Background=Brushes.Red;
                  //  }
             //   }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверно введен логин", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch
            {
                MessageBox.Show("Ошибка!","Ошибка!",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
