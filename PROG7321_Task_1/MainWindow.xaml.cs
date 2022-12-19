using PROG7321_Task_2;
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

namespace PROG7321_Task_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sortBooks_btn(object sender, RoutedEventArgs e)
        {
            SortBooksS win2 = new SortBooksS();
            win2.Show();
            this.Close();
        }

        private void IdentifyAreas_btn(object sender, RoutedEventArgs e)
        {
            Identifying_Areas win2 = new Identifying_Areas();
            win2.Show();
            this.Close();
        }

        private void findCallNum_btn(object sender, RoutedEventArgs e)
        {
            IdentifyCallNums win2 = new IdentifyCallNums();
            win2.Show();
            this.Close();
        }
    }
}
