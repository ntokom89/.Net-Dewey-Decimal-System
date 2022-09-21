using PROG7321_Task_1.Model;
using PROG7321_Task1.Model;
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
using System.Windows.Threading;

namespace PROG7321_Task_1
{
    /// <summary>
    /// Interaction logic for SortBooksS.xaml
    /// </summary>
    public partial class SortBooksS : Window
    {
        //Declaration of variables
        ListBox dragSource = null;
        List<int > items = new List<int>();
        List<String> items2 = new List<String>();
        int pointsbase = 0;
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public SortBooksS()
        {
            InitializeComponent();
        }

        //Method to load data into the first ListBox
        private void loadData(object sender, RoutedEventArgs e)
        {
            DALRandomCallNums.generateCallNumbers();
            items2.AddRange(ListNums.callNums);
            foreach(String nums in items2)
            {
               listBox.Items.Add(nums);
            }
        }

        //A method to implement when a item from a view is clicked on with the left mouse button
        //https://www.c-sharpcorner.com/uploadfile/dpatra/drag-and-drop-item-in-listbox-in-wpf/ Diptimaya Patra
        private void ListBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            dragSource = parent;
            object data = GetDataFromListBox(dragSource, e.GetPosition(parent));

            if (data != null)
            {
                //Drag and drop the item into a ListBox put on.
                DragDrop.DoDragDrop(parent, data, DragDropEffects.Move);
            }

        }

        #region GetDataFromListBox(ListBox,Point)
        //Get Data from the ListBox which applies to both ListBox 1 and 2.
        //https://www.youtube.com/watch?v=U9P2Bg7u5uA SingletonSean
        //https://www.c-sharpcorner.com/uploadfile/dpatra/drag-and-drop-item-in-listbox-in-wpf/ Diptimaya Patra
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
        //A method to retrieve the data from the item that was dropped into the ListBox. Applies to both ListBox 1 and 2
        //https://www.c-sharpcorner.com/uploadfile/dpatra/drag-and-drop-item-in-listbox-in-wpf/ Diptimaya Patra
        private void ListBox_Drop(object sender, DragEventArgs e)
        {
            ListBox parent = (ListBox)sender;
            object data = e.Data.GetData(typeof(string));
            dragSource.Items.Remove(data);
           //((IList)dragSource.ItemsSource).Remove(data);
            parent.Items.Add(data);
        }

        #endregion

        //A button to click to commit the changes being made.
        private void buttonCommit_click(object sender, RoutedEventArgs e)
        {
            BubbleSort.Sort(ListNums.callNums);
            if (listBoxResult.Items.Count == 10)
            {
                ICollection tempList = listBoxResult.Items;
                List<String> listCallNums = new List<String>();
                listCallNums.AddRange(listBoxResult.Items.Cast<String>().ToList());
                //Boolean to compare the sorted List to list submitted by the user.
                bool n = DALRandomCallNums.CompareList(listCallNums);
                if (n == true)
                {
                    if (progressBar.Value < 100)
                    {
                        ListNums.callNums.Clear();
                        listBox.Items.Clear();
                        listBoxResult.Items.Clear();
                        MessageBox.Show("Sucessful match.");
                        DALRandomCallNums.generateCallNumbers();
                        progressBar.Value += 10;
                        progressBarText.Text = progressBar.Value + "%";
                        pointsbase += 20;
                        string st = "points : " + pointsbase;
                        points.Content = st;
                        if(progressBar.Value == 100)
                        {
                            MessageBox.Show("Game complete");
                            MessageBox.Show("Points : " + pointsbase);
                            MainWindow window = new MainWindow();
                            window.Show();
                            this.Close();
                        }
                        else
                        {
                            foreach (String nums in ListNums.callNums)
                            {
                                listBox.Items.Add(nums);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Game complete");
                    }
                }
                else
                {

                    MessageBox.Show("Incorrect match, please try again");
                    String listCorrectOrder ="";
                    foreach(String nums in ListNums.callNums)
                    {
                        listCorrectOrder += nums + "\n";
                    }
                    MessageBox.Show("Correct Order" + "\n" +listCorrectOrder);
                    ListNums.callNums.Clear();
                    listBox.Items.Clear();
                    listBoxResult.Items.Clear();
                    progressBar.Value -= 10;
                    pointsbase -= 5;
                    string st = "points : " + pointsbase;
                    points.Content = st;

                    if(progressBar.Value < 0 || pointsbase < 0)
                    {
                        MessageBox.Show("Game over");
                        MessageBox.Show("Points : " + pointsbase);
                        MainWindow window = new MainWindow();
                        window.Show();
                        this.Close();
                    }
                    else
                    {
                        DALRandomCallNums.generateCallNumbers();
                        foreach (String nums in ListNums.callNums)
                        {
                            listBox.Items.Add(nums);
                        }
                    }


                }
                
            }
            else
            {
                MessageBox.Show("Please fully fill in the listbox");
            }

        }

        //A button to click back to the menu screen.
        private void backButton_click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
            ListNums.nums.Clear();
            ListNums.callNums.Clear();
        }

        private void listBox_isChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
