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

namespace Dimond1337
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainVM();
        }
            private void Button_ClickA(object sender, RoutedEventArgs e)
        {
            WindowOptions windowOptions = new WindowOptions();
            windowOptions.Show();
            this.Close();
        }

        private void Button_ClickB(object sender, RoutedEventArgs e)
        {
            WindowProgram windowProgram = new WindowProgram();
            windowProgram.Show();
            this.Close();
        }
    }
}
