using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace MegaDesk_Christensen
{
    //internal class DeskQuote
    
    public class DeskQuote
    {
        //static string FName, LName;
        //public string FName, LName;
        //static int Rushnum;
        //public int Rushnum;
        //public static string FirstName
        Desk deskInstance;
        int[,] rushOrderPriceList = new int[3, 3];
        
        /*public string FirstName
        {
            get
            {
                return FName;
            }
            set
            {
                FName = value;
            }
        }*/

        public string FirstName
        {
            get; set;
            
        }
        //public static string LastName
        /*public string LastName
        {
            get
            {
                return LName;

            }
            set
            {
                LName = value;
            }
        }*/

        public string LastName
        {
            get; set;            
        }
        //public static int RushOrder
        /*public int RushOrder
        {
            get
            {
                return Rushnum;
            }
            set
            {
                Rushnum = value;
            }
        }*/

        public int RushOrder
        {
            get;set;
        }

        public enum RushCombo
        {
            Three = 0,
            Five = 1,
            Seven = 2,
            Fourteen = 3
        }

        private RushCombo _rushCombo;

        public RushCombo CurrentRushCombo
        {
            get { return _rushCombo; }
            set { _rushCombo = value; }
        }

        

        public int DeskWidth
        {
            get; set;
        }
        public int DeskDepth
        {
            get; set;
        }

        public int Number_Of_Drawers
        {
            get; set;
        }

        public string Desktop_Material
        {
            get; set;
        }

        public Desk Desk
        {
            get; set;
        }

        public string Quote_Date { get; set; }

        public int Total_For_Quote { get; set; }

        public DeskQuote(string firstName, string lastName, int rushOrder, Desk desk, string date)
        {
            
            
            this.FirstName = firstName;
            this.LastName = lastName;
            this.RushOrder = rushOrder;
            this.Desk = desk;
            this.DeskWidth = this.Desk.Width;
            this.DeskDepth = this.Desk.Depth;
            this.Number_Of_Drawers = this.Desk.Drawers;
            this.Desktop_Material = this.Desk.DesktopMaterail;
            this.Quote_Date = date;
            this.Total_For_Quote = this.Total(rushOrder, desk.Width, desk.Depth, desk.Drawers, desk.DesktopMaterailAsInt);
            this.GetRushOrder();
        }


        //public static string RushorderDays(int RushOrder)
            public string RushorderDays(int RushOrder)
        {
            if (RushOrder == 0)
            {
                return "3 Day Shipping";
            }
            else if (RushOrder == 1)
            {
                return "5 Day Shipping";
            }
            else if (RushOrder == 2)
            {
                return "7 Day Shipping";
            }
                   
            return "14 Day Shipping";
        }
        //public static string deskmatsNames(int DesktopMaterail)
            public string deskmatsNames(int DesktopMaterail)
        {
            if (DesktopMaterail == 0)
            {
                return "Oak";
            }
            else if (DesktopMaterail == 1)
            {
                return "Laminate";
            }
            else if (DesktopMaterail == 2)
            {
                return "Pine";
            }
            else if (DesktopMaterail == 3)
            {
                return "Rosewood";
            }
            else if (DesktopMaterail == 4)
            {
                return "Veneer";
            }
            return "";
        }

        //public static int deskmatsTotal(int DesktopMaterail)
            public int deskmatsTotal(int DesktopMaterail)
        {
            if (DesktopMaterail == 0)
            {
                return DesktopMaterail = 200;
            }
            else if (DesktopMaterail == 1)
            {
                return DesktopMaterail = 100;
            }
            else if (DesktopMaterail == 2)
            {
                return DesktopMaterail = 50;
            }
            else if (DesktopMaterail == 3)
            {
                return DesktopMaterail = 300;
            }
            else if (DesktopMaterail == 4)
            {
                return DesktopMaterail = 125;
            }
            return 5;
        }
        //public static int rushNumdays(int rushNum)
        public int rushNumdays(int rushNum)
        {
            if (rushNum == 0)
            {
                return rushNum = 3;
            }
            else if (rushNum == 1)
            {
                return rushNum = 5;
            }
            else if (rushNum == 2)
            {
                return rushNum = 7;
            }
            else
            {
                return rushNum = 14;
            }
        }
        //public static int RushnumTotal(int rushNum, int Width, int Depth)
        public int RushnumTotal(int rushNum, int Width, int Depth)
        {



            if (rushNum == 0)
            {
                if ((Width * Depth) < 1000)
                {
                    return rushNum = rushOrderPriceList[0, 0];
                }
                else if ((Width * Depth) >= 1000 && (Width * Depth) <= 2000)
                {
                    return rushNum = rushOrderPriceList[0, 1];
                }
                else
                {
                    return rushNum = rushOrderPriceList[0, 2];
                }
                
            }
            else if (rushNum == 1)
            {
                if ((Width * Depth) < 1000)
                {
                    return rushNum = rushOrderPriceList[1, 0];
                }
                else if ((Width * Depth) >= 1000 && (Width * Depth) <= 2000)
                {
                    return rushNum = rushOrderPriceList[1, 1];
                }
                else 
                {
                    return rushNum = rushOrderPriceList[1, 2];
                }

            }
            else if (rushNum == 2)
            {
                if ((Width * Depth) < 1000)
                {
                    return rushNum = rushOrderPriceList[2, 0];
                }
                else if ((Width * Depth) >= 1000 && (Width * Depth) <= 2000)
                {
                    return rushNum = rushOrderPriceList[2, 1];
                }
                else 
                {
                    return rushNum = rushOrderPriceList[2, 2];
                }

            }
            return 0;
        }

        //public static int Total(int rushNumber, int Width, int Depth, int Drawers, int DesktopMaterail)
        public int Total(int rushNumber, int Width, int Depth, int Drawers, int DesktopMaterail)
        {
             int deskWidth = Convert.ToInt32(this.DeskWidth);
             int deskDepth = Convert.ToInt32(this.DeskDepth);
             int deskDrawers = Convert.ToInt32(this.Number_Of_Drawers);
          //   int deskMats = Convert.ToInt32(Desk.DesktopMaterail);   

         //   int rushNumber = RushnumTotal(rushNum, Width, Depth);
            int deskmattts = deskmatsTotal(DesktopMaterail);


        int total = 200 + (deskWidth * deskDepth) + (deskDrawers * 50) + deskmattts + rushNumber;
            
            return total;

            

    }

        public string GetRushOrder()
        {
            StreamReader reader = new StreamReader("rushOrderPrices.txt");

            if (File.Exists("rushOrderPrices.txt"))
            {

                int[] rushOrderPrices = Array.ConvertAll(File.ReadAllLines("rushOrderPrices.txt"), s => Int32.Parse(s));
                
                int index = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        rushOrderPriceList[i, k] = rushOrderPrices[index];
                        index++;
                    }
                }

                //MessageBox.Show($"{rushOrderPriceList[0, 0]} {rushOrderPriceList[0, 1]} {rushOrderPriceList[0, 2]}");

                /*MessageBox.Show($"{rushOrderPriceList[0,0]}");
                MessageBox.Show($"{rushOrderPriceList[0,1]}");
                MessageBox.Show($"{rushOrderPriceList[0,2]}");
                MessageBox.Show($"{rushOrderPriceList[1,0]}");
                MessageBox.Show($"{rushOrderPriceList[1,1]}");
                MessageBox.Show($"{rushOrderPriceList[1,2]}");
                MessageBox.Show($"{rushOrderPriceList[2,0]}");
                MessageBox.Show($"{rushOrderPriceList[2,1]}");
                MessageBox.Show($"{rushOrderPriceList[2,2]}");*/

                return "Exists";
            }
            else
            {
                return "Does not exist";
            }



        }


        public void Save(List<DeskQuote> quoteList, TextWriter textOut)
        {
            //MessageBox.Show("inside SAVE 2 method ++++++++++++++++");
            var convertedJSON = JsonConvert.SerializeObject(quoteList, Formatting.Indented);
            //MessageBox.Show($"{convertedJSON}");
            textOut.WriteLine(convertedJSON);
        }

        public bool Save(List<DeskQuote> quoteList, string filename)
        {
            //MessageBox.Show("inside save method &&&&&&&&&&&");
            //MessageBox.Show($"{quoteList.Count()}");
            TextWriter textOut = null;
            try
            {
                //MessageBox.Show($"{filename}");
                textOut = new StreamWriter(filename);
                //MessageBox.Show($"{filename}");

                Save(quoteList, textOut);
            }
            catch (Exception e)
            {
                //MessageBox.Show($"{e.Message}");
                return false;
            }
            finally 
            {
                if (textOut != null)
                {
                    textOut.Close();
                }
            }
            return true;
        }

        public static List<DeskQuote> Load(string filename)
        {
            List<DeskQuote> quoteList = null;
            quoteList = new List<DeskQuote>();

            if (File.Exists(filename)) { 

                StreamReader textIn = new StreamReader(filename);
            try
            {
                string JSONList = textIn.ReadToEnd();

                    //MessageBox.Show("Inside public static List<DeskQuote> Load");
                    //MessageBox.Show($"{JSONList}");

                quoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(JSONList);


                //MessageBox.Show($"{quoteList}");

            }
            catch
            {
                return null;
            }
            finally
            {
                if (textIn != null) textIn.Close();
            }
            return quoteList;
            } else 
            {
                return null;
            }
        }



    }
}
