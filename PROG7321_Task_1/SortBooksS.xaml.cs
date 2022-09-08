using PROG7321_Task1.Models;
using System;
using System.Collections;
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

namespace PROG7321_Task_1
{
    /// <summary>
    /// Interaction logic for SortBooksS.xaml
    /// </summary>
    public partial class SortBooksS : Window
    {
        ListBox dragSource = null;
        List<int > items = new List<int>();
        public SortBooksS()
        {
            InitializeComponent();
        }

        private void loadData(object sender, RoutedEventArgs e)
        {
            DALRandomCallNums.generateCallNumbers();
            items.AddRange(ListNums.nums);
            foreach(int nums in items)
            {
               listBox.Items.Add(nums);
            }
        }

        private void ListBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            dragSource = parent;
            object data = GetDataFromListBox(dragSource, e.GetPosition(parent));

            if (data != null)
            {
                DragDrop.DoDragDrop(parent, data, DragDropEffects.Move);
            }

        }

        #region GetDataFromListBox(ListBox,Point)
        private static object GetDataFromListBox(ListBox source, Point point)
        {
            UIElement? element = source.InputHitTest(point) as UIElement;
            if (element != null)
            {
                object data = DependencyProperty.UnsetValue;
                while (data == DependencyProperty.UnsetValue)
                {
                    data = source.ItemContainerGenerator.ItemFromContainer(element);

                    if (data == DependencyProperty.UnsetValue)
                    {
                        element = VisualTreeHelper.GetParent(element) as UIElement;
                    }

                    if (element == source)
                    {
                        return null;
                    }
                }

                if (data != DependencyProperty.UnsetValue)
                {
                    return data;
                }
            }

            return null;
        }

        private void ListBox_Drop(object sender, DragEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            object data = e.Data.GetData(typeof(int));
           //((IList)dragSource.ItemsSource).Remove(data);
            parent.Items.Add(data);
        }

        #endregion

        private void buttonCommit_click(object sender, RoutedEventArgs e)
        {
            DALRandomCallNums.radixsort(ListNums.nums, ListNums.nums.Count);
            if (listBoxResult.Items.Count > 0)
            {
                ICollection tempList = listBoxResult.Items;
                List<int> ints = new List<int>();
                ints.AddRange(listBoxResult.Items.Cast<int>().ToList());
                bool n = DALRandomCallNums.CompareList(ints);
                if (n == true)
                {
                    if (progressBar.Value < 100)
                    {
                        ListNums.nums.Clear();
                        listBox.Items.Clear();
                        listBoxResult.Items.Clear();
                        MessageBox.Show("Sucessful match.");
                        DALRandomCallNums.generateCallNumbers();
                        foreach (int nums in ListNums.nums)
                        {
                            listBox.Items.Add(nums);
                        }
                        progressBar.Value += 10;
                    }
                    else
                    {
                        MessageBox.Show("Game complete");
                    }
                }
                else
                {

                    MessageBox.Show("Incorrect match, please try again");
                }
                //listBoxResult.Items = 
            }
            else
            {
                MessageBox.Show("Please fill in the listbox");
            }

        }

        private void backButton_click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
            ListNums.nums.Clear();
        }
    }
}
