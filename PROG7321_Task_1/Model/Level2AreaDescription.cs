using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7321_Task_1.Model
{
    public  class Level2AreaDescription
    {
        //Method to get description for science category
        public void getDesScience(double num, string callNum,string des)
        {
            switch (num)
            {
                case >= 510 and < 520:
                    CallNumber.callNumbersDictionary.Add(callNum, des +" Type : Mathematics");
                    break;
                case >= 520 and < 530:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Astronomy");
                    break;
                case >= 530 and < 540:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Physics");
                    break;
                case >= 540 and < 550:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Chemistry");
                    break;
                case >= 550 and < 560:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Earth Sciences");
                    break;
                case >= 560 and < 570:

                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Paleontology");
                    break;
                case >= 570 and < 580:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Life Sciences");
                    break;
                case >= 580 and < 590:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Botanical Sciences");
                    break;
                case >= 590:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Zoological Sciences");
                    break;
                default:
                    CallNumber.callNumbersDictionary.Add(callNum, des);
                    break;
            }
        }
        //Method to get description for language category
        public void getDesLanguage(double num, string callNum, string des)
        {
            switch (num)
            {
                case >= 410 and < 420:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Comparative Linguistics");
                    break;
                case >= 420 and < 430:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : English and Anglo Saxon");
                    break;
                case >= 430 and < 440:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : German Language");
                    break;
                case >= 440 and < 450:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : French");
                    break;
                case >= 450 and < 460:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Italian, Rumanian");
                    break;
                case >= 460 and < 470:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Spanish, Portuguese");
                    break;
                case >= 470 and < 480:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Latin and Other Italic Languages");
                    break;
                case >= 480 and < 490:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Classical and Modern Greek");
                    break;
                case >= 490:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Other Language");
                    break;
                default:
                    CallNumber.callNumbersDictionary.Add(callNum, des);
                    break;
            }
        }
        //Method to get description for social sciences category
        public void getDesSocialSciences(double num, string callNum, string des)
        {
            switch (num)
            {
                case >= 310 and < 320:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Statistics");
                    break;
                case >= 320 and < 330:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Political Science");
                    break;
                case >= 330 and < 340:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Economics");
                    break;
                case >= 340 and < 350:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Law");
                    break;
                case >= 350 and < 360:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Public Administration");
                    break;
                case >= 360 and < 370:

                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Social Welfare");
                    break;
                case >= 370 and < 380:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Education");
                    break;
                case >= 380 and < 390:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Public Service");
                    break;
                case >= 390:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Customs and Folklore");
                    break;
                default:
                    CallNumber.callNumbersDictionary.Add(callNum, des);
                    break;
            }
        }
        //Method to get description for Technology category
        public void getDesTechnology(double num, string callNum, string des)
        {
            switch (num)
            {
                case >= 610 and < 620:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Medical Sciences");
                    break;
                case >= 620 and < 630:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Engineering");
                    break;
                case >= 630 and < 640:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Argiculture");
                    break;
                case >= 640 and < 650:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Domestic Sciences");
                    break;
                case >= 650 and < 660:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Business and Management");
                    break;
                case >= 660 and < 670:

                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Chemical Technology");
                    break;
                case >= 670 and < 690:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Manufacturers");
                    break;
                case >= 690:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Building Construction");
                    break;
                default:
                    CallNumber.callNumbersDictionary.Add(callNum, des);
                    break;
            }
        }
        //Method to get description for Arts category
        public void getDesTheArts(double num, string callNum, string des)
        {
            switch (num)
            {
                case >= 710 and < 720:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Landscape and Civic Art");
                    break;
                case >= 720 and < 730:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Architecture");
                    break;
                case >= 730 and < 740:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Sculpture, Plastics");
                    break;
                case >= 740 and < 750:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Drawings, Decorative Arts");
                    break;
                case >= 750 and < 760:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Painting");
                    break;
                case >= 760 and < 770:

                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Prints and Print Making");
                    break;
                case >= 770 and < 780:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Photography");
                    break;
                case >= 780 and < 790:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Music");
                    break;
                case >= 790:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Recreation, Performing Arts");
                    break;
                default:
                    CallNumber.callNumbersDictionary.Add(callNum, des);
                    break;
            }
        }
        //Method to get description for Literature category
        public void getDesLiterature(double num, string callNum, string des)
        {
            switch (num)
            {
                case >= 810 and < 820:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : American Literature");
                    break;
                case >= 820 and < 830:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : English");
                    break;
                case >= 830 and < 840:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : German ");
                    break;
                case >= 840 and < 850:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : French ");
                    break;
                case >= 850 and < 860:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Italian, Rumanian ");
                    break;
                case >= 860 and < 870:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Spanish, Portuguese ");
                    break;
                case >= 870 and < 880:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Latin and Other Italic ");
                    break;
                case >= 880 and < 890:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Classical and Modern Greek ");
                    break;
                case >= 890:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Other Literature");
                    break;
                default:
                    CallNumber.callNumbersDictionary.Add(callNum, des);
                    break;
            }
        }
        //Method to get description for History and Geography category
        public void getDesHistoryGeography(double num, string callNum, string des)
        {
            switch (num)
            {
                case >= 910 and < 920:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Geography Travel");
                    break;
                case >= 920 and < 930:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Biography, Genealogy");
                    break;
                case >= 930 and < 940:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Acient History ");
                    break;
                case >= 940 and < 950:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Europe ");
                    break;
                case >= 950 and < 960:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Asia ");
                    break;
                case >= 960 and < 970:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Africa ");
                    break;
                case >= 970 and < 980:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : North America ");
                    break;
                case >= 980 and < 990:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : South America ");
                    break;
                case >= 990 and < 991:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Pacific Ocean Islands");
                    break;
                case >= 991 and < 993:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type :Indonesia");
                    break;
                case >= 993 and < 994:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : New Zealand and Melanesia");
                    break;
                case >= 994 and < 995:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Australia");
                    break;
                case >= 995 and < 996:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : New Guinea");
                    break;
                case >= 996 and < 997:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Polynesia");
                    break;
                case >= 997 and < 998:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Atlantic Ocean Islands");
                    break;
                case >= 998 and < 999:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Artic Region");
                    break;
                case >= 999:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Antarctic Regions");
                    break;
                default:
                    CallNumber.callNumbersDictionary.Add(callNum, des);
                    break;

            }
        }
        //Method to get description for Religion category
        public void getDesReligion(double num, string callNum, string des)
        {
            switch (num)
            {
                case >= 220 and < 230:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : The Bible");
                    break;
                case >= 230 and < 290:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Christian Doctrine");
                    break;
                case >=290:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Comparative and Other Religions ");
                    break;
                default:
                    CallNumber.callNumbersDictionary.Add(callNum, des);
                    break;
            }
        }
        //Method to get description for Philosophy category
        public void getDesPhilosophy(double num, string callNum, string des)
        {
            switch (num)
            {
                case >= 110 and < 130:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Metaphysics");
                    break;
                case >= 130 and < 140:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Psychology, occultism");
                    break;
                case >= 140 and < 150:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Philosophy");
                    break;
                case >= 150 and < 160:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Psychology");
                    break;
                case >= 169:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Logic");
                    break;
                default:
                    CallNumber.callNumbersDictionary.Add(callNum, des);
                    break;
            }
        }
        //Method to get description for General Works category
        public void getDesGenWorks(double num, string callNum, string des)
        {
            switch (num)
            {
                case >= 20 and < 30:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : Library and Information Science");
                    break;
                case >= 30 and < 50:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : General Encyclopedias");
                    break;
                case >= 50 and < 60:
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type :General Perodicals");
                    break;
                case >= 60 :
                    CallNumber.callNumbersDictionary.Add(callNum, des + " Type : General Organisation");
                    break;
                default:
                    CallNumber.callNumbersDictionary.Add(callNum, des);
                    break;
            }
        }
    }


}
