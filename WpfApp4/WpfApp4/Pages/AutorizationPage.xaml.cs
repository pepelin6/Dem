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
using WpfApp4.Data;

namespace WpfApp4.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void Act_Click(object sender, RoutedEventArgs e)
        {
            string log = Login.Text;
            string pas = Password.Password;
            using(AklahomaEntities db = new AklahomaEntities())
            {
                Accaunt a = db.Accaunt.Where(c => c.login == log && c.Passvord == pas).FirstOrDefault();
                if(a == null) 
                {
                    MessageBox.Show("Логин или пароль не верны. Попробуйте ещё раз");
                }
                else
                {
                    NavigationService.Navigate(new Page1());
                }
            }
        }
    }
}
