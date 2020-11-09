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

namespace OperSwitch
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                byte n = byte.Parse(Day.Text);
                switch(n)
                {
                    case 1: Result.Content = "Понедельник";break;
                    case 2: Result.Content = "Вторник"; break;
                    case 3: Result.Content = "Среда"; break;
                    case 4: Result.Content = "Четверг"; break;
                    case 5: Result.Content = "Пятница"; break;
                    case 6: Result.Content = "Суббота"; break;
                    case 7: Result.Content = "Воскресенье"; break;
                    default: Result.Content = "Не правильно введен но"; break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
