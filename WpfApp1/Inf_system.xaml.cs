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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Inf_system.xaml
    /// </summary>
    public partial class Inf_system : Window
    {
        ApplicationContext db;
        public Inf_system()
        {
            InitializeComponent();
            db = new ApplicationContext();

           
        }

        private void App(object sender, RoutedEventArgs e)
        {
            string last_name = input_last_name.Text.Trim();
            string first_name = input_first_name.Text.Trim();
            string middle_name = input_middle_name.Text.Trim();

            input_last_name.ToolTip = "";
            input_last_name.Background = Brushes.Transparent;
            input_first_name.ToolTip = "";
            input_first_name.Background = Brushes.Transparent;
            input_middle_name.ToolTip = "";
            input_middle_name.Background = Brushes.Transparent;

            Teacher teacher = new Teacher(last_name, first_name, middle_name);

            db.Teachers.Add(teacher);
            db.SaveChanges();
        }

        private void Button_cabinet(object sender, RoutedEventArgs e)
        {
            Cabinet cabinet = new Cabinet();
            cabinet.Show();
        }
    }
}
