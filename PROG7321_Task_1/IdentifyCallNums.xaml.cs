using PROG7321_Task_1;
using PROG7321_Task_1.Model;
using PROG7321_Task_2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using trees;

namespace PROG7321_Task_2
{
    /// <summary>
    /// Interaction logic for IdentifyCallNums.xaml
    /// </summary>
    public partial class IdentifyCallNums : Window
    {
        binaryClass bt2 = new binaryClass();
        List<Node> list = new List<Node> ();
        List<Node> list2 = new List<Node>();
        List<Node> list3 = new List<Node>();
        List<string> des = new List<string>();
        Node? model = null;
        Node modelT = null;
        Node modeS = null;
        int score = 0;
        public IdentifyCallNums()
        {

            string[] lines = File.ReadAllLines(@"dewey_decimal_system.txt");
            //binaryClass bt2 = new binaryClass();
            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                if (line.Contains("-"))
                {
                    String[] strlist = line.Split('-',
                      2, StringSplitOptions.None);
                    // Use a tab to indent each line of the file.
                    Console.WriteLine(strlist[0] + " " + strlist[1]);
                    bt2.Add(new CallNumber(strlist[0],int.Parse(strlist[0]), strlist[1]));
                }
            }
            Console.WriteLine("Traversing Pre Order");
            binaryClass.ChildCount(bt2.root);
            BackgroundWorker worker = new BackgroundWorker();
            InitializeComponent();

            nextAsync();
            //bt2.TraversePreOrder(bt2.root, list_views);
        }
        //Method implemented after the background worker's  thread is finished the work
        //https://learn.microsoft.com/en-us/dotnet/desktop/wpf/advanced/threading-model?view=netframeworkdesktop-4.8
        void setUpButton(object sender, RunWorkerCompletedEventArgs e)
        {
            setButtonVisibilityAll();
            setButtonColorAll();
            setButtonDataAll();
            setButtonEnabledAll();

        }
        //Method to set second and third level buttons visibility to hidden
        void setButtonVisibilityAll()
        {
            secondLevelbtn1.Visibility = Visibility.Hidden;
            secondLevelbtn2.Visibility = Visibility.Hidden;
            secondLevelbtn3.Visibility = Visibility.Hidden;
            secondLevelbtn4.Visibility = Visibility.Hidden;

            thirdLevelbtn1.Visibility = Visibility.Hidden;
            thirdLevelbtn2.Visibility = Visibility.Hidden;
            thirdLevelbtn3.Visibility = Visibility.Hidden;
            thirdLevelbtn4.Visibility = Visibility.Hidden;
        }
        //Method to set color for all buttons
        void setButtonColorAll()
        {
            secondLevelbtn1.Background = Brushes.Gray;
            secondLevelbtn2.Background = Brushes.Gray;
            secondLevelbtn3.Background = Brushes.Gray;
            secondLevelbtn4.Background = Brushes.Gray;

            thirdLevelbtn1.Background = Brushes.Gray;
            thirdLevelbtn2.Background = Brushes.Gray;
            thirdLevelbtn3.Background = Brushes.Gray;
            thirdLevelbtn4.Background = Brushes.Gray;

            topLeveltbn1.Background = Brushes.Gray;
            topLeveltbn2.Background = Brushes.Gray;
            topLeveltbn3.Background = Brushes.Gray;
            topLeveltbn4.Background = Brushes.Gray;
        }
        //Method to set the data for all buttons
        void setButtonDataAll()
        {
            topLeveltbn1.Content = list[0].Data.CallNum;
            topLeveltbn2.Content = list[1].Data.CallNum;
            topLeveltbn3.Content = list[2].Data.CallNum;
            topLeveltbn4.Content = list[3].Data.CallNum;

            secondLevelbtn1.Content = list2[0].Data.CallNum;
            secondLevelbtn2.Content = list2[1].Data.CallNum;
            secondLevelbtn3.Content = list2[2].Data.CallNum;
            secondLevelbtn4.Content = list2[3].Data.CallNum;

            thirdLevelbtn1.Content = list3[0].Data.CallNum;
            thirdLevelbtn2.Content = list3[1].Data.CallNum;
            thirdLevelbtn3.Content = list3[2].Data.CallNum;
            thirdLevelbtn4.Content = list3[3].Data.CallNum;
        }
        //method to enable all buttons
        void setButtonEnabledAll()
        {
            secondLevelbtn1.IsEnabled = true;
            secondLevelbtn2.IsEnabled = true;
            secondLevelbtn3.IsEnabled = true;
            secondLevelbtn4.IsEnabled = true;

            thirdLevelbtn1.IsEnabled = true;
            thirdLevelbtn2.IsEnabled = true;
            thirdLevelbtn3.IsEnabled = true;
            thirdLevelbtn4.IsEnabled = true;

            topLeveltbn1.IsEnabled = true;
            topLeveltbn2.IsEnabled = true;
            topLeveltbn3.IsEnabled = true;
            topLeveltbn4.IsEnabled = true;
        }

        //Method to execute in the background worker.
        //https://iq.opengenus.org/select-random-node-from-binary-tree/
        //https://learn.microsoft.com/en-us/dotnet/desktop/wpf/advanced/threading-model?view=netframeworkdesktop-4.8
        void setUp(object sender, DoWorkEventArgs e)
        {
            Random random = new Random();
            Boolean bool1 = false;
            int o = 0;
            while (bool1 == false)
            {
                model = binaryClass.randomNode(bt2.root,"Third Level");
                o++;
;
                if (model == null)
                    {

                    }
                    else
                    {

                        bool1 = true;
                        break;
                    }
                
            }
            textBlockThirdLevDes.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate ()
            {
                textBlockThirdLevDes.Text =  model.Data.CallNumDescription;
            }));


            Thread.Sleep(1000);
            bool1 = false;
            Node modelT2 = new Node();
            Node modelT3 = new Node();
            Node modelT4 = new Node();
            int j = 0;
            bt2.list.Clear();
            bt2.TraversePreOrder(bt2.root);
            var charArrayT = model.Data.CallNumInt.ToString().ToCharArray();
            int tempTopM = int.Parse(charArrayT[0].ToString()) * 100;
            while (bool1 == false)
            {
                 //modelT2 = binaryClass.randomNode(bt2.root, "Top Level");
                 //modelT3 = binaryClass.randomNode(bt2.root, "Top Level");
                 modelT2 = bt2.list[random.Next(bt2.list.Count)];
                modelT3 = bt2.list[random.Next(bt2.list.Count)];
                modelT4 = bt2.list[random.Next(bt2.list.Count)];
                j++;

                //bt2.TraversePreOrder(model, list_views);
                if (modelT2 == null || modelT3 == null || modelT4 == null || modelT2.Data.CallNumInt.Equals(tempTopM) || modelT3.Data.CallNumInt.Equals(tempTopM) || modelT4.Data.CallNumInt.Equals(tempTopM))
                {
                    //textBlockThirdLevDes.Text = "Model is null";
                    //|| modelT2.Equals(modelT3)
                }
                else
                {
                    if (modelT2.Equals(modelT3)|| modelT2.Equals(modelT4)|| modelT3.Equals(modelT4))
                    {
                    }
                    else
                    {
                        bool1 = true;
                        list.Add(modelT2);
                        list.Add(modelT3);
                        list.Add(modelT4);  
                        break;
                    }
                    //textBlockThirdLevDes.Text = "Model is not null";
                    //bt2.TraversePreOrder(model, list_views);
                }


            }
            int tempTopL;


            if (model.Data.CallNum.Contains("	0"))
            {
                modelT = bt2.Find(0);
                list.Add(modelT);
            }
            else
            {
                var charArray = model.Data.CallNumInt.ToString().ToCharArray();
                 tempTopL = int.Parse(charArray[0].ToString()) * 100;
                modelT = bt2.Find(tempTopL);
                list.Add(modelT);
            }
            //List<Node> rList = (List<Node>)list.OrderBy(item => random.Next());
            des.Add(list[0].Data.CallNum);
            des.Add(list[1].Data.CallNum);
            des.Add(list[2].Data.CallNum);
            Boolean s = false;
           
            setUpSecondLevel(model);
            setUpThirdLevel(model);

            randomiseTopLevel();
            randomiseSecondLevel();
            randomiseThirdLevel();
        }

        //Method to randomise the top level call numbers and thier description along with adding to list
        void randomiseTopLevel()
        {
            Random random = new Random();
            bool s = false;
            int c = 0;
            while (s == false)
            {
                int b = 0;
                List<Node> des = new List<Node>();
                Node nod1 = list[random.Next(0, 4)];
                des.Add(nod1);

                Node nod2 = list[random.Next(0, 4)];
                des.Add(nod2);

                Node nod3 = list[random.Next(0, 4)];
                des.Add(nod3);

                Node nod4 = list[random.Next(0, 4)];
                des.Add(nod4);

                for (int i = 0; i < 4; i++)
                {
                    if (des.Contains(list[i]))
                    {
                        b++;
                    }
                    else
                    {
                    }
                }
                if (b == 4)
                {
                    s = true;
                    list = des;
                    break;
                }
            }
        }

        //Method to randomise the second level call numbers and thier description along with adding to list2
        void randomiseSecondLevel()
        {
            Random random = new Random();
            bool s = false;
            while (s == false)
            {
                int b = 0;
                List<Node> des = new List<Node>();
                Node node1 = list2[random.Next(0, 4)];
                des.Add(node1);

                Node node2 = list2[random.Next(0, 4)];
                des.Add(node2);

                Node node3 = list2[random.Next(0, 4)];
                des.Add(node3);

                Node nod4 = list2[random.Next(0, 4)];
                des.Add(nod4);

                for (int i = 0; i < 4; i++)
                {
                    if (des.Contains(list2[i]))
                    {
                        b++;
                    }
                    else
                    {

                    }
                }
                if (b == 4)
                {
                    s = true;
                    list2 = des;
                    break;
                }
            }
        }

        //Method to randomise the third level call numbers and thier description along with adding to list3
        void randomiseThirdLevel()
        {
            Random random = new Random();
            bool s = false;
            while (s == false)
            {
                int b = 0;
                List<Node> des = new List<Node>();

                Node nod1 = list3[random.Next(0, 4)];
                des.Add(nod1);

                Node nod2 = list3[random.Next(0, 4)];
                des.Add(nod2);

                Node nod3 = list3[random.Next(0, 4)];
                des.Add(nod3);

                Node nod4 = list3[random.Next(0, 4)];
                des.Add(nod4);
                for (int i = 0; i < 4; i++)
                {
                    if (des.Contains(list3[i]))
                    {
                        b++;
                    }
                    else
                    {
                    }
                }
                if (b == 4)
                {
                    s = true;
                    list3 = des;
                    break;
                }
            }
        }
        void setUpButtonTopLevel(List<Node> list)
    {
            topLeveltbn1.Content = des[0];
            topLeveltbn2.Content = des[1];
            topLeveltbn3.Content = des[2];
            //setButtonContent();

            //while(buttons.Count > 0)
            //{
            //    Boolean j = false;

            //    if (topLeveltbn1.Content.Equals("") || topLeveltbn2.Content.Equals("") || topLeveltbn3.Content.Equals("") || topLeveltbn1.Content.Equals(topLeveltbn2.Content) || topLeveltbn2.Content.Equals(topLeveltbn3.Content) || topLeveltbn1.Content.Equals(topLeveltbn3.Content))
            //    {
            //        setButtonContent();
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //void setButtonContent()
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        //Button button = buttons[random.Next(3)];
            //            buttons[i].Content = list[random.Next(3)].Data.CallNum;
            //    }
            //}

        }

        //Method for the second level
        //https://iq.opengenus.org/select-random-node-from-binary-tree/
        void setUpSecondLevel(Node model)
        {
           
            Boolean bool1 = false;
            Node modelT2 = new Node();
            Node modelT3 = new Node();
            Node modelT4 = new Node();
            int o = 0;
            while (bool1 == false)
            {
                modelT2 = binaryClass.randomNode(bt2.root, "Second Level");
                modelT3 = binaryClass.randomNode(bt2.root, "Second Level");
                modelT4 = binaryClass.randomNode(bt2.root, "Second Level");


                //bt2.TraversePreOrder(model, list_views);
                if (modelT2 == null || modelT3 == null || modelT4 == null || modelT2.Equals(modelT3) || modelT2.Equals(modelT4) || modelT3.Equals(modelT4))
                {
                    Console.WriteLine("No Model found");
                 
                    //textBlockThirdLevDes.Text = "Model is null";
                }
                else
                {

                    //textBlockThirdLevDes.Text = "Model is not null";
                    //bt2.TraversePreOrder(model, list_views);
                    bool1 = true;

                    list2.Add(modelT2);
                    list2.Add(modelT3);
                    list2.Add(modelT4);
                    break;
                }


            }
            if (model.Data.CallNum.Contains('0'))
            {
                var charArray = model.Data.CallNumInt.ToString().ToCharArray();
                int tempTopL = int.Parse(charArray[0].ToString()) * 100;
                modeS = bt2.Find(tempTopL);
                list2.Add(modeS);
            }
            else if (model.Data.CallNum.Contains("00"))
            {
                modeS = list[2];
                list2.Add(list[2]);
            }
            else
            {
                var charArray = model.Data.CallNumInt.ToString().ToCharArray();
                int tempTopL = int.Parse(charArray[0].ToString() + charArray[1].ToString()) * 10;
                modeS = bt2.Find(tempTopL);
                list2.Add(modeS);
            }
 
        }
        //Method for the Third level
        //https://iq.opengenus.org/select-random-node-from-binary-tree/
        void setUpThirdLevel(Node model)
        {
            list3.Add(model);
            Boolean bool1 = false;
            Node modelT2 = new Node();
            Node modelT3 = new Node();
            Node modelT4 = new Node();
            while (bool1 == false)
            {
                modelT2 = binaryClass.randomNode(bt2.root, "Third Level");
                modelT3 = binaryClass.randomNode(bt2.root, "Third Level");
                modelT4 = binaryClass.randomNode(bt2.root, "Third Level");
                if (modelT2 == null || modelT3 == null || modelT4 == null || modelT2.Equals(modelT3) || modelT2.Equals(modelT4) || modelT3.Equals(modelT4))
                {
                }
                else
                {
                    bool1 = true;
                    break;
                }
            }

            list3.Add(modelT2);
            list3.Add(modelT3);
            list3.Add(modelT4);

        }
        //Method to get second level buttons visible
        //https://stackoverflow.com/questions/3052593/hiding-a-button-in-wpf
        public void setVisibleSecondLevelButtons()
        {
            secondLevelbtn1.Visibility = Visibility.Visible;
            secondLevelbtn2.Visibility = Visibility.Visible;
            secondLevelbtn3.Visibility = Visibility.Visible;
            secondLevelbtn4.Visibility = Visibility.Visible;
        }
        //Method to get third level buttons visible
        //https://stackoverflow.com/questions/3052593/hiding-a-button-in-wpf
        public void setVisibleThirdLevelButtons()
        {
            thirdLevelbtn1.Visibility = Visibility.Visible;
            thirdLevelbtn2.Visibility = Visibility.Visible;
            thirdLevelbtn3.Visibility = Visibility.Visible;
            thirdLevelbtn4.Visibility = Visibility.Visible;
        }

        //Method to use background worker to start producing values required
        //https://www.c-sharpcorner.com/blogs/how-to-use-backgroundworker-in-c-sharp Tapan Patel
        //https://www.c-sharpcorner.com/UploadFile/1c8574/threads-in-wpf/ Gul Md Ershad
        public void nextAsync()
        {

            list.Clear();
            list2.Clear();
            list3.Clear();
            model = null;
            modelT = null;
            modeS = null;
            scoreLbl.Content = "Score : " + score;
            BackgroundWorker worker = new BackgroundWorker();
            //assign it work
            worker.DoWork += new DoWorkEventHandler(setUp);

            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(setUpButton);
            ////start work
            if (!worker.IsBusy)
            {

                worker.RunWorkerAsync();
            }
            else
            {

            }



        }

        //Method to be implemented if the user selects the wrong option
        public void failure(int level)
        {
            if(level == 0)
            {
                score -= 50;
                if(score < 0)
                {
                    MessageBox.Show("Quiz is over" + "\n Score: " + score);
                    MainWindow window = new MainWindow();
                    window.Show();
                    this.Close();
                }
                else
                {
                answerLbl.Content = "Anwser : " + model.Data.CallNum + " " + model.Data.CallNumDescription;

                    scoreLbl.Content = "Score : " + score;
                    progressBar.Value = 0;
                    nextAsync();
                }
            }
            if(level == 1)
            {
                score -= 25;
                if (score < 0)
                {
                    MessageBox.Show("Quiz is over" + "\n Score: " + score);
                    MainWindow window = new MainWindow();
                    window.Show();
                    this.Close();
                }
                else
                {
                    answerLbl.Content = "Anwser : " + model.Data.CallNum + " " + model.Data.CallNumDescription;

                    scoreLbl.Content = "Score : " + score;
                    progressBar.Value = 0;
                    nextAsync();
                }
            }  
            if(level == 2)
            {
                score -= 15;
                if (score < 0)
                {
                    MessageBox.Show("Quiz is over" + "\n Score: " + score);
                    MainWindow window = new MainWindow();
                    window.Show();
                    this.Close();
                }
                else
                {
                    answerLbl.Content = "Anwser : " + model.Data.CallNum + " " + model.Data.CallNumDescription;
                    scoreLbl.Content = "Score : " + score;
                    progressBar.Value = 0;
                    nextAsync();
                }
            }
        }
        //Back method to go back to the main menu
        private void backBtnClick(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            this.Close();
            //MessageBox.Show("Score : " + ScoreNum);
            window.Show();
        }
        //Method to implement top level btn1 statements
        private void topLeveltbn1_click(object sender, RoutedEventArgs e)
        {
            if (topLeveltbn1.Content.Equals(modelT.Data.CallNum))
            {
                topLeveltbn1.Background = Brushes.Green;
                progressBar.Value += 40;
                setVisibleSecondLevelButtons();
            }
            else
            {
                topLeveltbn1.Background = Brushes.Red;
                failure(0);
            }
        }
        //Method to implement top level btn2 statements

        private void topLeveltbn2_click(object sender, RoutedEventArgs e)
        {
            if (topLeveltbn2.Content.Equals(modelT.Data.CallNum))
            {
                topLeveltbn2.Background = Brushes.Green;
                progressBar.Value += 40;
                setVisibleSecondLevelButtons();
            }
            else
            {
                topLeveltbn2.Background = Brushes.Red;
                failure(0);
            }
        }
        //Method to implement top level btn3 statements

        private void topLeveltbn3_click(object sender, RoutedEventArgs e)
        {
            if (topLeveltbn3.Content.Equals(modelT.Data.CallNum))
            {
                topLeveltbn3.Background = Brushes.Green;
                progressBar.Value += 40;
                setVisibleSecondLevelButtons();
            }
            else
            {
                topLeveltbn3.Background = Brushes.Red;
                failure(0);
            }
        }
        //Method to implement second level btn1 statements

        private void secondLevelbtn1_click(object sender, RoutedEventArgs e)
        {
            if (secondLevelbtn1.Content.Equals(modeS.Data.CallNum))
            {
                secondLevelbtn1.Background = Brushes.Green;
                progressBar.Value += 40;
                setVisibleThirdLevelButtons();

            }
            else
            {
                secondLevelbtn1.Background = Brushes.Red;
                failure(1);
            }
        }
        //Method to implement second level btn2 statements
        private void secondLevelbtn2_click(object sender, RoutedEventArgs e)
        {
            if (secondLevelbtn2.Content.Equals(modeS.Data.CallNum))
            {
                secondLevelbtn2.Background = Brushes.Green;
                progressBar.Value += 40;
                setVisibleThirdLevelButtons();
            }
            else
            {
                secondLevelbtn2.Background = Brushes.Red;
                failure(1);
            }
        }
        //Method to implement second level btn3 statements
        private void secondLevelbtn3_click(object sender, RoutedEventArgs e)
        {

            if (secondLevelbtn3.Content.Equals(modeS.Data.CallNum))
            {
                secondLevelbtn3.Background = Brushes.Green;
                progressBar.Value += 40;
                setVisibleThirdLevelButtons();
            }
            else
            {
                secondLevelbtn3.Background = Brushes.Red;
                failure(1);
            }
        }
        //Method to implement third level btn1 statements
        private void thirdLevelbtn1_click(object sender, RoutedEventArgs e)
        {

            if (thirdLevelbtn1.Content.Equals(model.Data.CallNum))
            {
                thirdLevelbtn1.Background = Brushes.Green;
                progressBar.Value += 20;
                score += 50;
                scoreLbl.Content = "Score : " + score;
                answerLbl.Content = "Anwser : " + model.Data.CallNum + " " + model.Data.CallNumDescription;
                nextAsync();
            }
            else
            {
                thirdLevelbtn1.Background = Brushes.Red;
                failure(2);
            }
        }
        //Method to implement third level btn2 statements
        private void thirdLevelbtn2_click(object sender, RoutedEventArgs e)
        {
            if (thirdLevelbtn2.Content.Equals(model.Data.CallNum))
            {
                thirdLevelbtn2.Background = Brushes.Green;
                progressBar.Value += 20;
                score += 50;
                scoreLbl.Content = "Score : " + score;
                answerLbl.Content = "Anwser : " + model.Data.CallNum + " " + model.Data.CallNumDescription;
                nextAsync();
            }
            else
            {
                thirdLevelbtn2.Background = Brushes.Red;
                failure(2);

            }
        }
        //Method to implement third level btn3 statements
        private void thirdLevelbtn3_click(object sender, RoutedEventArgs e)
        {
            if (thirdLevelbtn3.Content.Equals(model.Data.CallNum))
            {
                thirdLevelbtn3.Background = Brushes.Green;
                progressBar.Value += 20;
                score += 50;
                scoreLbl.Content = "Score : " + score;
                answerLbl.Content = "Anwser : " + model.Data.CallNum + " " + model.Data.CallNumDescription;
                nextAsync();
            }
            else
            {
                thirdLevelbtn3.Background = Brushes.Red;
                failure(2);

            }
        }
        //Method to implement top level btn4 statements
        private void topLeveltbn4_click(object sender, RoutedEventArgs e)
        {
            if (topLeveltbn4.Content.Equals(modelT.Data.CallNum))
            {
                topLeveltbn4.Background = Brushes.Green;
                progressBar.Value += 40;
                setVisibleSecondLevelButtons();
            }
            else
            {
                topLeveltbn4.Background = Brushes.Red;
                failure(0);
            }
        }
        //Method to implement second level btn4 statements
        private void secondLevelbtn4_click(object sender, RoutedEventArgs e)
        {
            if (secondLevelbtn4.Content.Equals(modeS.Data.CallNum))
            {
                secondLevelbtn4.Background = Brushes.Green;
                progressBar.Value += 40;
                setVisibleThirdLevelButtons();
            }
            else
            {
                secondLevelbtn4.Background = Brushes.Red;
                failure(1);
            }
        }
        //Method to implement third level btn4 statements
        private void thirdLevelbtn4_click(object sender, RoutedEventArgs e)
        {
            if (thirdLevelbtn4.Content.Equals(model.Data.CallNum))
            {
                thirdLevelbtn4.Background = Brushes.Green;
                progressBar.Value += 20;
                score += 50;
                scoreLbl.Content = "Score : " + score;
                answerLbl.Content = "Anwser : " + model.Data.CallNum + " " + model.Data.CallNumDescription;
                nextAsync();
            }
            else
            {
                thirdLevelbtn4.Background = Brushes.Red;
                failure(2);

            }
        }
    }
}
