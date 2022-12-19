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
using WPFCustomMessageBox;

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
        Boolean question1 = false;
        Boolean question2 = false;
        Boolean question3 = false;
        Boolean question4 = false;
        int level = 1;
        Line l1 = new Line();
        Line l2 = new Line();
        Line l3 = new Line();
        Line l4 = new Line();
        Dictionary<String , String> answers = new Dictionary<String, String>();    
        public Identifying_Areas()
        {
            InitializeComponent();
            AreaIdentification.generateCallNumbers(level);
            descriptions();
            

        }
        //Method to generate random Call from 7 Associated with Call numbers
        //https://gist.github.com/abierhaus/14730be18a8aa771e050e41dde1da201 abierhaus
        public void callNums()
        {

            Boolean s = false;
            var random = new Random();
            
            ButtonQuestion1.Content = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(0)];
            ButtonQuestion2.Content = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(1)];
            ButtonQuestion3.Content= CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(2)];
            ButtonQuestion4.Content = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(3)];

            while (s == false)
            {
                int b = 0;
                List<string> cal = new List<string>();
                //textBoxDescription1.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                buttonAnswer1.Content = CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7));
                cal.Add((string)buttonAnswer1.Content);
                //textBoxDescription2.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                buttonAnswer2.Content = CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7));
                cal.Add((string)buttonAnswer2.Content);
                //textBoxDescription3.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                buttonAnswer3.Content = CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7));
                cal.Add((string)buttonAnswer3.Content);
                //textBoxDescription4.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                buttonAnswer4.Content = CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7));

                cal.Add((string)buttonAnswer4.Content);
                //textBoxDescription5.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                buttonAnswer5.Content = CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7));

                cal.Add((string)buttonAnswer5.Content);
                //textBoxDescription6.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                buttonAnswer6.Content = CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7));

                cal.Add((string)buttonAnswer6.Content);
                //textBoxDescription7.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                buttonAnswer7.Content = CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7));

                cal.Add((string)buttonAnswer7.Content);
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
        //Method to generate random descriptions from 7 Associated with Call numbers    
        //https://gist.github.com/abierhaus/14730be18a8aa771e050e41dde1da201 abierhaus
        public void  descriptions()
        {
            Boolean s = false;
            var random = new Random();
            ButtonQuestion1.Content = CallNumber.callNumbersDictionary.Keys.ElementAt(0);
            ButtonQuestion2.Content = CallNumber.callNumbersDictionary.Keys.ElementAt(1);
            ButtonQuestion3.Content = CallNumber.callNumbersDictionary.Keys.ElementAt(2);
            ButtonQuestion4.Content = CallNumber.callNumbersDictionary.Keys.ElementAt(3);
            while (s == false)
            {
                int b = 0;
                List<string> des = new List<string>();
                //textBoxDescription1.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                buttonAnswer1.Content= CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7))];
                des.Add((string)buttonAnswer1.Content);
                //textBoxDescription2.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                buttonAnswer2.Content = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7))];
                des.Add((string)buttonAnswer2.Content);
                //textBoxDescription3.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                buttonAnswer3.Content = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7))];
                des.Add((string)buttonAnswer3.Content);
                //textBoxDescription4.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                buttonAnswer4.Content = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7))];

                des.Add((string)buttonAnswer4.Content);
                //textBoxDescription5.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                buttonAnswer5.Content = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7))];

                des.Add((string)buttonAnswer5.Content);
                //textBoxDescription6.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                buttonAnswer6.Content = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7))];

                des.Add((string)buttonAnswer6.Content);
                //textBoxDescription7.Text = CallNumber.callNumbers[random.Next(0, 6)].CallNumDescription;
                buttonAnswer7.Content = CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(random.Next(0, 7))];

                des.Add((string)buttonAnswer7.Content);
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
        //Method associated with continue button that will either implement the checkAnswerDes or checkAnswerCallNum method
        private void onClickButtonContinue(object sender, RoutedEventArgs e)
        {

            if(altQ == false)
            {
                checkAnswerDes();
            }
            else
            {
                checkAnswerCallNum();
            }

          
        }

        public  String checkNum(int num)
        {
            String description = " ";
            switch (num)
            {
                case 1:
                    description = (string)buttonAnswer1.Content;
                    break;
                case 2:
                    description = (string)buttonAnswer2.Content;
                    break;
                case 3:
                    description = (string)buttonAnswer3.Content;
                    break;
                case 4:
                    description = (string)buttonAnswer4.Content;
                    break;
                case 5:
                    description = (string)buttonAnswer5.Content;
                    break;
                case 6:
                    description = (string)buttonAnswer6.Content;
                    break;
                case 7:
                    description = (string)buttonAnswer7.Content;
                    break;

            }


            return description;
        }

        //Method to check the answer according to Call and Description
        //https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/
        //https://github.com/evanwon/WPFCustomMessageBox Evan Won
        public void checkAnswerDes()
        {
            altQ = true;
            int s = 0;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    if (CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(j)].Equals(answers[answers.Keys.ElementAt(i)])
                        && CallNumber.callNumbersDictionary.Keys.ElementAt(j).Equals(answers.Keys.ElementAt(i)))
                    {
                        s++;
                    }
                }
            }
            //If s is equal to 4
            if(s == 4)
            {
                if(level == 1)
                {
                    ScoreNum += 50;
                }
                else if(level == 2)
                {
                    ScoreNum += 70;
                }
                
                string st = "Score : " + ScoreNum;
                pointsLb.Content = st;
                MessageBox.Show("100% Match");
                progressBar.Value += 10;
                AreaIdentification.generateCallNumbers(level);
                if (progressBar.Value == 100 && level == 1)
                {
                    //A custom message box that shows yes,no and cancel as a different text. This is 
                    //for the level 1
                    MessageBoxResult result = CustomMessageBox.ShowYesNoCancel(
                  "You want to move to the next level?",
                  "Level",
                  "Yes",
                  "Continue with current level",
                  "Stop the game");
                    switch (result)
                    {
                        case MessageBoxResult.Yes:
                            level++;
                            break;
                        case MessageBoxResult.No:
                            break;
                        case MessageBoxResult.Cancel:
                            MainWindow window = new MainWindow();
                            MessageBox.Show("Score : " + ScoreNum);
                            window.Show();
                            this.Close();
                            break;
                    }
                    progressBar.Value = 0;
                }
                else if (progressBar.Value == 100 && level == 2)
                {
                    //A custom message box that shows yes,no and cancel as a different text. This is 
                    //for the level 2
                    MessageBoxResult result = CustomMessageBox.ShowYesNoCancel(
                "You wanto to continue with current level or downgrade the level?",
                "Level",
                "Continue",
                "Downgrade level",
                "Stop the game");
                    switch (result)
                    {
                        case MessageBoxResult.Yes:

                            break;
                        case MessageBoxResult.No:
                            level--;
                            break;
                        case MessageBoxResult.Cancel:
                            MainWindow window = new MainWindow();
                            MessageBox.Show("Score : " + ScoreNum);
                            window.Show();
                            this.Close();
                            break;
                    }
                }
                clearUI();
                callNums();
            }
            else
            {
                MessageBox.Show("Match incorrect");
                MessageBox.Show(CallNumber.callNumbersDictionary.Keys.ElementAt(0) + " : " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(0)] +
                   "\n" + CallNumber.callNumbersDictionary.Keys.ElementAt(1) + " : " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(1)] +
                   "\n" + CallNumber.callNumbersDictionary.Keys.ElementAt(2) + " : " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(2)] +
                   "\n" + CallNumber.callNumbersDictionary.Keys.ElementAt(3) + " : " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(3)], "Correct Match");

                AreaIdentification.generateCallNumbers(level);
                ScoreNum -= 20;
                string st = "Score : " + ScoreNum;
                pointsLb.Content = st;
                progressBar.Value -= 10;

                if (progressBar.Value < 0 || ScoreNum < 0)
                {
                    MessageBox.Show("Game over");
                    MessageBox.Show("Score : " + ScoreNum);
                    MainWindow window = new MainWindow();
                    window.Show();
                    this.Close();
                }
                else
                {

                    clearUI();
                    callNums();
                }
            }

        }

        //Method to check the answer according to description and call number
        //https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/
        //https://github.com/evanwon/WPFCustomMessageBox Evan Won
        public void checkAnswerCallNum()
        {
            altQ = false;
            int s = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (CallNumber.callNumbersDictionary.Keys.ElementAt(j).Equals(answers[answers.Keys.ElementAt(i)])
                        && CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(j)].Equals(answers.Keys.ElementAt(i)))
                    {
                        s++;
                    }
                }
            }
            if(s == 4)
            {
                if (level == 1)
                {
                    ScoreNum += 50;
                }
                else if (level == 2)
                {
                    ScoreNum += 70;
                }
                
                string st = "Score : " + ScoreNum;
                pointsLb.Content = st;
                MessageBox.Show("100% Match");
                progressBar.Value += 10;
                if (progressBar.Value == 100 && level == 1)
                {
                    MessageBoxResult result= CustomMessageBox.ShowYesNoCancel(
                  "You want to move to the next level?",
                  "Level",
                  "Yes",
                  "Continue with current level",
                  "Stop the game");
                    switch (result)
                    {
                        case MessageBoxResult.Yes:
                            level++;
                            break;
                        case MessageBoxResult.No:
                            break;
                        case MessageBoxResult.Cancel:
                            MainWindow window = new MainWindow();
                            MessageBox.Show("Score : " + ScoreNum);
                            window.Show();
                            this.Close();
                            break;
                    }
                    progressBar.Value = 0;
                }else if(progressBar.Value == 100 && level == 2)
                {
                    MessageBoxResult result = CustomMessageBox.ShowYesNoCancel(
                "You wanto to continue with current level or downgrade the level?",
                "Level",
                "Continue",
                "Downgrade level",
                "Stop the game");
                    switch (result)
                    {
                        case MessageBoxResult.Yes:
                 
                            break;
                        case MessageBoxResult.No:
                            level--;
                            break;
                        case MessageBoxResult.Cancel:
                            MainWindow window = new MainWindow();
                            MessageBox.Show("Score : " + ScoreNum);
                            window.Show();
                            this.Close();
                            break;
                    }
                }
                Console.WriteLine(level);
                AreaIdentification.generateCallNumbers(level);
                clearUI();
                descriptions();
            }
            else
            {
                MessageBox.Show("Match incorrect");
                MessageBox.Show(CallNumber.callNumbersDictionary.Keys.ElementAt(0) + " : " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(0)] +
                    "\n" +CallNumber.callNumbersDictionary.Keys.ElementAt(1) + " : " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(1)] +
                    "\n" + CallNumber.callNumbersDictionary.Keys.ElementAt(2) + " : " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(2)] +
                    "\n" +CallNumber.callNumbersDictionary.Keys.ElementAt(3) + " : " + CallNumber.callNumbersDictionary[CallNumber.callNumbersDictionary.Keys.ElementAt(3)], "Correct Match");
                AreaIdentification.generateCallNumbers(level);
                ScoreNum -= 20;
                string st = "Score : " + ScoreNum;
                pointsLb.Content = st;
                progressBar.Value -= 10;
                if (progressBar.Value < 0 || ScoreNum < 0)
                {
                    MessageBox.Show("Game over");
                    MessageBox.Show("Score : " + ScoreNum);
                    MainWindow window = new MainWindow();
                    window.Show();
                    this.Close();
                }
                else
                {

                    clearUI();
                    callNums();
                }

            }

        }
        //Method Associated with back button to take you back to the main menu.
        private void onButtonBackClick(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            MessageBox.Show("Score : " + ScoreNum);
            window.Show();
            this.Close();
        }
        //Method to clear UI of the window and the answers Dictionary
        private void clearUI()
        {
            answers.Clear();
            myCanvas.Children.Remove(l1);
            myCanvas.Children.Remove(l2);
            myCanvas.Children.Remove(l3);
            myCanvas.Children.Remove(l4);
            question1 = false;
            question2 = false;
            question3 = false;
            question4 = false;
            ButtonQuestion1.Background = Brushes.Purple;
            ButtonQuestion2.Background = Brushes.Purple;
            ButtonQuestion3.Background = Brushes.Purple;
            ButtonQuestion4.Background = Brushes.Purple;
        }

        //Method for Question 1 button that confirms selection of it.
        private void onBlockQstBtn(object sender, RoutedEventArgs e)
        {
            if (question1 == false)
            {

                ButtonQuestion1.Background = Brushes.Cyan;
                question1 = true;
            }
            else
            {
                myCanvas.Children.Remove(l1);
                ButtonQuestion1.Background = Brushes.Purple;
                answers.Remove((string)ButtonQuestion1.Content);
                question1 = false;
            }

        }

       
        //Method for Question 2 button that confirms selection of it.
        private void onQuestion2Btn(object sender, RoutedEventArgs e)
        {
            if (question2 == false)
            {

                ButtonQuestion2.Background = Brushes.Cyan;
                question2 = true;
            }
            else
            {
                myCanvas.Children.Remove(l2);
                ButtonQuestion2.Background = Brushes.Purple;
                answers.Remove((string)ButtonQuestion2.Content);
                question2 = false;
            }

        }


        //Method for Question 3 button that confirms selection of it.
        private void onQuestion3Btn(object sender, RoutedEventArgs e)
        {
            if (question3 == false)
            {

                ButtonQuestion3.Background = Brushes.Cyan;
                question3 = true;
            }
            else
            {
                myCanvas.Children.Remove(l3);
                ButtonQuestion3.Background = Brushes.Purple;
                answers.Remove((string)ButtonQuestion3.Content);
                question3 = false;
            }
        }
        //Method for Question 4 button that confirms selection of it.
        private void onQuestion4Btn(object sender, RoutedEventArgs e)
        {
            if (question4 == false)
            {

                ButtonQuestion4.Background = Brushes.Cyan;
                question4 = true;
            }
            else
            {
                myCanvas.Children.Remove(l4);
                ButtonQuestion4.Background = Brushes.Purple;
                answers.Remove((string)ButtonQuestion4.Content);
                question4 = false;
            }
        }
        //Method for Answer 1 Button that will draw the line or not if already assigned to question button
        private void onAnswer1Btn(object sender, RoutedEventArgs e)
        {
            if (!answers.ContainsValue((string)buttonAnswer1.Content))
            {
                if (question1 && !answers.ContainsKey((string)ButtonQuestion1.Content))
                {
                    drawLine(ButtonQuestion1, buttonAnswer1, l1);
                }
                if (question2 && !answers.ContainsKey((string)ButtonQuestion2.Content))
                {
                    drawLine(ButtonQuestion2, buttonAnswer1, l2);
                }

                if (question3 && !answers.ContainsKey((string)ButtonQuestion3.Content))
                {
                    drawLine(ButtonQuestion3, buttonAnswer1, l3);
                }
                if (question4 && !answers.ContainsKey((string)ButtonQuestion4.Content))
                {
                    drawLine(ButtonQuestion4, buttonAnswer1, l4);
                }
            }
            else
            {
                MessageBox.Show("Answer already assigned. Deselect the question button assign to it.", "Answer already assigned");
            }

        }
        //Method for Answer 2 Button that will draw the line or not if already assigned to question button
        private void onAnswer2Btn(object sender, RoutedEventArgs e)
        {
            if (!answers.ContainsValue((string)buttonAnswer2.Content))
            {
                if (question1 && !answers.ContainsKey((string)ButtonQuestion1.Content))
                {
                    drawLine(ButtonQuestion1, buttonAnswer2, l1);
                }
                if (question2 && !answers.ContainsKey((string)ButtonQuestion2.Content))
                {
                    drawLine(ButtonQuestion2, buttonAnswer2, l2);
                }

                if (question3 && !answers.ContainsKey((string)ButtonQuestion3.Content))
                {
                    drawLine(ButtonQuestion3, buttonAnswer2, l3);
                }
                if (question4 && !answers.ContainsKey((string)ButtonQuestion4.Content))
                {
                    drawLine(ButtonQuestion4, buttonAnswer2, l4);
                }
            }
            else
            {
                MessageBox.Show("Answer already assigned. Deselect the question button assign to it.", "Answer already assigned");

            }
        }
        //Method for Answer 3 Button that will draw the line or not if already assigned to question button
        private void onAnswer3Btn(object sender, RoutedEventArgs e)
        {
            if (!answers.ContainsValue((string)buttonAnswer3.Content))
            {
                if (question1 && !answers.ContainsKey((string)ButtonQuestion1.Content))
                {
                    drawLine(ButtonQuestion1, buttonAnswer3, l1);
                }
                if (question2 && !answers.ContainsKey((string)ButtonQuestion2.Content))
                {
                    drawLine(ButtonQuestion2, buttonAnswer3, l2);
                }

                if (question3 && !answers.ContainsKey((string)ButtonQuestion3.Content))
                {
                    drawLine(ButtonQuestion3, buttonAnswer3, l3);
                }
                if (question4 && !answers.ContainsKey((string)ButtonQuestion4.Content))
                {
                    drawLine(ButtonQuestion4, buttonAnswer3, l4);
                }
            }
            else
            {
                MessageBox.Show("Answer already assigned. Deselect the question button assign to it.", "Answer already assigned");

            }
        }
        //Method for Answer 4 Button that will draw the line or not if already assigned to question button
        private void onAnswer4Btn(object sender, RoutedEventArgs e)
        {
            if (!answers.ContainsValue((string)buttonAnswer4.Content))
            {
                if (question1 && !answers.ContainsKey((string)ButtonQuestion1.Content))
                {
                    drawLine(ButtonQuestion1, buttonAnswer4, l1);
                }
                if (question2 && !answers.ContainsKey((string)ButtonQuestion2.Content))
                {
                    drawLine(ButtonQuestion2, buttonAnswer4, l2);
                }

                if (question3 && !answers.ContainsKey((string)ButtonQuestion3.Content))
                {
                    drawLine(ButtonQuestion3, buttonAnswer4, l3);
                }
                if (question4 && !answers.ContainsKey((string)ButtonQuestion4.Content))
                {
                    drawLine(ButtonQuestion4, buttonAnswer4, l4);
                }
            }
            else
            {
                MessageBox.Show("Answer already assigned. Deselect the question button assign to it.", "Answer already assigned");

            }
        }
        //Method for Answer 5 Button that will draw the line or not if already assigned to question button
        private void onAnswer5btn(object sender, RoutedEventArgs e)
        {
            if (!answers.ContainsValue((string)buttonAnswer5.Content))
            {
                if (question1 && !answers.ContainsKey((string)ButtonQuestion1.Content))
                {
                    drawLine(ButtonQuestion1, buttonAnswer5, l1);
                }
                if (question2 && !answers.ContainsKey((string)ButtonQuestion2.Content))
                {
                    drawLine(ButtonQuestion2, buttonAnswer5, l2);
                }

                if (question3 && !answers.ContainsKey((string)ButtonQuestion3.Content))
                {
                    drawLine(ButtonQuestion3, buttonAnswer5, l3);
                }
                if (question4 && !answers.ContainsKey((string)ButtonQuestion4.Content))
                {
                    drawLine(ButtonQuestion4, buttonAnswer5, l4);
                }
            }
            else
            {
                MessageBox.Show("Answer already assigned. Deselect the question button assign to it.", "Answer already assigned");

            }
        }
        //Method for Answer 6 Button that will draw the line or not if already assigned to question button
        private void onAnswer6Btn(object sender, RoutedEventArgs e)
        {
            if (!answers.ContainsValue((string)buttonAnswer6.Content))
            {
                if (question1 && !answers.ContainsKey((string)ButtonQuestion1.Content))
                {
                    drawLine(ButtonQuestion1, buttonAnswer6, l1);
                }
                if (question2 && !answers.ContainsKey((string)ButtonQuestion2.Content))
                {
                    drawLine(ButtonQuestion2, buttonAnswer6, l2);
                }

                if (question3 && !answers.ContainsKey((string)ButtonQuestion3.Content))
                {
                    drawLine(ButtonQuestion3, buttonAnswer6, l3);
                }
                if (question4 && !answers.ContainsKey((string)ButtonQuestion4.Content))
                {
                    drawLine(ButtonQuestion4, buttonAnswer6, l4);
                }
            }
            else
            {
                MessageBox.Show("Answer already assigned. Deselect the question button assign to it.", "Answer already assigned");

            }
        }
        //Method for Answer 7 Button that will draw the line or not if already assigned to question button
        private void onAnswer7Btn(object sender, RoutedEventArgs e)
        {
            if (!answers.ContainsValue((string)buttonAnswer7.Content))
            {
                if (question1 && !answers.ContainsKey((string)ButtonQuestion1.Content))
                {
                    drawLine(ButtonQuestion1, buttonAnswer7, l1);
                }
                if (question2 && !answers.ContainsKey((string)ButtonQuestion2.Content))
                {
                    drawLine(ButtonQuestion2, buttonAnswer7, l2);
                }

                if (question3 && !answers.ContainsKey((string)ButtonQuestion3.Content))
                {
                    drawLine(ButtonQuestion3, buttonAnswer7, l3);
                }
                if (question4 && !answers.ContainsKey((string)ButtonQuestion4.Content))
                {
                    drawLine(ButtonQuestion4, buttonAnswer7, l4);
                }
            }
            else
            {
                MessageBox.Show("Answer already assigned. Deselect the question button assign to it.", "Answer already assigned");

            }
        }
        //Method to draw the line between the button question and answer
        //https://stackoverflow.com/questions/20438073/draw-line-between-two-button-in-wpf Zafer Ayan
        public void drawLine(Button question, Button answer, Line line)
        {
            Point btn1Point = question.TransformToAncestor(this).Transform(new Point(0, 0));
            Point btn2Point = answer.TransformToAncestor(this).Transform(new Point(0, 0));
            Line l = new Line();
            line.Stroke = new SolidColorBrush(Colors.Black);
            line.StrokeThickness = 2.0;
            line.X1 = btn1Point.X + question.ActualWidth;
            line.X2 = btn2Point.X;
            line.Y1 = btn1Point.Y + question.ActualHeight / 2;
            line.Y2 = btn2Point.Y + answer.ActualHeight / 2;
            answers.Add((string)question.Content, (string)answer.Content);
            myCanvas.Children.Add(line);

        }

        private void switchQuestionBtn_click(object sender, RoutedEventArgs e)
        {
            clearUI();
            if(altQ == false)
            {
                descriptions();
                altQ = true;
            }
            else
            {
                callNums();
                altQ = false;
            }
        }
    }
}
