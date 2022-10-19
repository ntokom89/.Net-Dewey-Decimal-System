using PROG7321_Task_1.Model;
using System;
using System.Collections.Generic;
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

namespace PROG7321_Task_1
{
    /// <summary>
    /// Interaction logic for Identifying_Areas.xaml
    /// </summary>
    public partial class Identifying_Areas : Window
    {
        Thread thread;
        int ScoreNum = 0;
        Boolean altQ = false;
        public Identifying_Areas()
        {
            InitializeComponent();
            AreaIdentification.generateCallNumbers();
            descriptions();
            

        }
        public void callNums()
        {

            Boolean s = false;
            var random = new Random();
            TextBlockCallNum.Text = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(0)];
            TextBlockCallNum2.Text = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(1)];
            TextBlockCallNum3.Text = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(2)];
            TextBlockCallNum4.Text = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(3)];

            while (s == false)
            {
                int b = 0;
                List<string> cal = new List<string>();
                //textBoxDescription1.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                textBoxDescription1.Text = CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7));
                cal.Add(textBoxDescription1.Text);
                //textBoxDescription2.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                textBoxDescription2.Text = CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7));
                cal.Add(textBoxDescription2.Text);
                //textBoxDescription3.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                textBoxDescription3.Text = CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7));
                cal.Add(textBoxDescription3.Text);
                //textBoxDescription4.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                textBoxDescription4.Text = CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7));

                cal.Add(textBoxDescription4.Text);
                //textBoxDescription5.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                textBoxDescription5.Text = CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7));

                cal.Add(textBoxDescription5.Text);
                //textBoxDescription6.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                textBoxDescription6.Text = CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7));

                cal.Add(textBoxDescription6.Text);
                //textBoxDescription7.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                textBoxDescription7.Text = CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7));

                cal.Add(textBoxDescription7.Text);
                for (int i = 0; i < 7; i++)
                {
                    if (cal.Contains(CallNumber.callNumbersDictionary.Keys.ElementAt(i)))
                    {
                        //s = true;

                        b++;
                    }
                    else
                    {

                    }
                }
                if (b == 7)
                {
                    s = true;
                    break;
                }
            }
        }

        public void  descriptions()
        {
            Boolean s = false;
            var random = new Random();
            TextBlockCallNum.Text = CallNumber.callNumbersDictionary.Keys.ElementAt(0);
            TextBlockCallNum2.Text = CallNumber.callNumbersDictionary.Keys.ElementAt(1);
            TextBlockCallNum3.Text = CallNumber.callNumbersDictionary.Keys.ElementAt(2);
            TextBlockCallNum4.Text = CallNumber.callNumbersDictionary.Keys.ElementAt(3);
            while (s == false)
            {
                int b = 0;
                List<string> des = new List<string>();
                //textBoxDescription1.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                textBoxDescription1.Text = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7))];
                des.Add(textBoxDescription1.Text);
                //textBoxDescription2.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                textBoxDescription2.Text = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7))];
                des.Add(textBoxDescription2.Text);
                //textBoxDescription3.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                textBoxDescription3.Text = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7))];
                des.Add(textBoxDescription3.Text);
                //textBoxDescription4.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                textBoxDescription4.Text = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7))];

                des.Add(textBoxDescription4.Text);
                //textBoxDescription5.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                textBoxDescription5.Text = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7))];

                des.Add(textBoxDescription5.Text);
                //textBoxDescription6.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                textBoxDescription6.Text = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7))];

                des.Add(textBoxDescription6.Text);
                //textBoxDescription7.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                textBoxDescription7.Text = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7))];

                des.Add(textBoxDescription7.Text);
                for(int i = 0; i < 7; i++)
                {
                    if (des.Contains(CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(i)])){
                        //s = true;

                        b++;
                    }
                    else
                    {

                    }
                }
                if (b == 7)
                {
                    s = true;
                    break;
                }
            }
        }

        private void onClickButtonContinue(object sender, RoutedEventArgs e)
        {
            String ans1 = checkNum(int.Parse(textBox1.Text));
            String ans2 = checkNum(int.Parse(textBox2.Text));
            String ans3 = checkNum(int.Parse(textBox3.Text));
            String ans4 = checkNum(int.Parse(textBox4.Text));

            if(altQ == false)
            {
                checkAnswerDes(ans1, ans2, ans3, ans4);
            }
            else
            {
                checkAnswerCallNum(ans1, ans2, ans3, ans4);
            }

          
        }

        public  String checkNum(int num)
        {
            String description = " ";
            switch (num)
            {
                case 1:
                    description = textBoxDescription1.Text;
                    break;
                case 2:
                    description = textBoxDescription2.Text;
                    break;
                case 3:
                    description = textBoxDescription3.Text;
                    break;
                case 4:
                    description = textBoxDescription4.Text;
                    break;
                case 5:
                    description = textBoxDescription5.Text;
                    break;
                case 6:
                    description = textBoxDescription6.Text;
                    break;
                case 7:
                    description = textBoxDescription7.Text;
                    break;

            }


            return description;
        }


        public void checkAnswerDes(String ans1,String ans2, String ans3, String ans4)
        {
            altQ = true;
            if (CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(0)].Equals(ans1)
               && CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(1)].Equals(ans2)
               && CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(2)].Equals(ans3)
               && CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(3)].Equals(ans4))
            {
                ScoreNum += 50;
                string st = "Score : " + ScoreNum;
                pointsLb.Content = st;
                MessageBox.Show("100% Match");
                AreaIdentification.generateCallNumbers();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                callNums();
            }
            else
            {
                MessageBox.Show("Match incorrect");
                MessageBox.Show(CallNumber.callNumbersDictionary.Keys.ElementAt(0) + ": " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(0)] +
                    CallNumber.callNumbersDictionary.Keys.ElementAt(1) + ": " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(1)] +
                    CallNumber.callNumbersDictionary.Keys.ElementAt(2) + ": " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(2)] +
                    CallNumber.callNumbersDictionary.Keys.ElementAt(3) + ": " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(3)]);
                AreaIdentification.generateCallNumbers();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                callNums();
            }
        }

        public void checkAnswerCallNum(String ans1, String ans2, String ans3, String ans4)
        {
            altQ = false;
            if (CallNumber.callNumbersDictionary.Keys.ElementAt(0).Equals(ans1)
               && CallNumber.callNumbersDictionary.Keys.ElementAt(1).Equals(ans2)
               && CallNumber.callNumbersDictionary.Keys.ElementAt(2).Equals(ans3)
               && CallNumber.callNumbersDictionary.Keys.ElementAt(3).Equals(ans4))
            {
                ScoreNum += 50;
                string st = "Score : " + ScoreNum;
                pointsLb.Content = st;
                MessageBox.Show("100% Match");
                AreaIdentification.generateCallNumbers();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                descriptions();
            }
            else
            {
                MessageBox.Show("Match incorrect");
                MessageBox.Show(CallNumber.callNumbersDictionary.Keys.ElementAt(0) + ": " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(0)] +
                    CallNumber.callNumbersDictionary.Keys.ElementAt(1) + ": " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(1)] +
                    CallNumber.callNumbersDictionary.Keys.ElementAt(2) + ": " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(2)] +
                    CallNumber.callNumbersDictionary.Keys.ElementAt(3) + ": " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(3)]);
                AreaIdentification.generateCallNumbers();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                descriptions();
               
            }
        }
        private void onButtonBackClick(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
