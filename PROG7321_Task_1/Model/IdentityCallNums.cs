using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using trees;

namespace PROG7321_Task_2.Model
{
    internal class IdentityCallNums
    {
        public static List<Node> setUp(binaryClass bt2)
        {
            List<Node> list = new List<Node>();
            Random random = new Random();
            Node? model = null;
            Boolean bool1 = false;

            //Thread thread = new Thread(getRandomThirdLevel());
            //model = getRandomThirdLevel();
            while (bool1 == false)
            {
                model = binaryClass.randomNode(bt2.root, "Third Level");
                //bt2.TraversePreOrder(model, list_views);
                if (model == null)
                {
                    //textBlockThirdLevDes.Text = "Model is null";
                }
                else
                {
                    //textBlockThirdLevDes.Text = "Model is not null";
                    //bt2.TraversePreOrder(model, list_views);
                    bool1 = true;
                    break;
                }


            }
            if (model.Data.CallNum.Contains(" 0"))
            {
                Node modelT1 = bt2.Find(0);
                list.Add(modelT1);
            }
            else
            {
                var charArray = model.Data.CallNumInt.ToString().ToCharArray();
                int tempTopL = int.Parse(charArray[0].ToString()) * 100;
                Node modelT1 = bt2.Find(tempTopL);
                list.Add(modelT1);
            }
            bool1 = false;
            Node modelT2 = new Node();
            Node modelT3 = new Node();
            while (bool1 == false)
            {
                modelT2 = binaryClass.randomNode(bt2.root, "Top Level");
                modelT3 = binaryClass.randomNode(bt2.root, "Top Level");
                //bt2.TraversePreOrder(model, list_views);
                if (modelT2 == null || modelT3 == null || modelT2.Equals(modelT3))
                {
                    Thread.Sleep(100);
                }
                else
                {

                    //textBlockThirdLevDes.Text = "Model is not null";
                    //bt2.TraversePreOrder(model, list_views);
                    bool1 = true;
                    list.Add(modelT2);
                    list.Add(modelT3);
                    break;
                }


            }
            //textBlockThirdLevDes.Text = model.Data.CallNumDescription;
            //list_views.Items.Add(model.leftNode.Data.CallNumDescription);

            //topLeveltbn1.Content = list[0].Data.CallNumInt;
            //topLeveltbn2.Content = modelT2.Data.CallNumInt;
            //topLeveltbn3.Content = modelT3.Data.CallNumInt;
            //setUpButtonTopLevel(list);
            //setUpSecondLevel(model);
            //setUpThirdLevel(model);
            return list;
        }
    }
}
