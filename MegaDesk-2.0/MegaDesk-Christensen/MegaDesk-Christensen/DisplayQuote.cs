using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Christensen

{
    public partial class DisplayQuote : Form
    {
        DeskQuote myDesk;
        Desk desk;
//        private DeskQuote _displayQuote;
        public DisplayQuote(DeskQuote myDesk, Desk desk)
        {  

          
            InitializeComponent();
            this.myDesk = myDesk;
            this.desk = desk;
        }  
      /*  public static void DisplayQuote(AddQuote displayQuot)
        {
          
            MessageBox.Show(displayQuot.FirstName);
            displayQuot.LastName = DeskQuote.LastName;
            string date = DateTime.Today.ToString("dd MMMM yyy");
            MessageBox.Show(date.ToString());
       
        }
  
*/
        private void label14_Click(object sender, EventArgs e)
        {
            
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MM = new MainMenu();
            MM.ShowDialog();
            this.Close();

        }

        private void nameLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            
            //int adddias = Convert.ToInt32(DeskQuote.rushNumdays(DeskQuote.RushOrder));
            int adddias = Convert.ToInt32(myDesk.rushNumdays(myDesk.RushOrder));
            //nameLabel.Text = DeskQuote.FirstName + " " + DeskQuote.LastName;
            nameLabel.Text = myDesk.FirstName + " " + myDesk.LastName;
            WidthLabel.Text = desk.Width + " Inches";
            DepthLabel.Text = desk.Depth + " Inches";
            DrawersLabel.Text = desk.Drawers.ToString();
            //MaterialsLabel.Text = DeskQuote.deskmatsNames(Desk.DesktopMaterail);
            //MaterialsLabel.Text = myDesk.deskmatsNames(Desk.DesktopMaterail);
            MaterialsLabel.Text = desk.DesktopMaterail;
            //OrderLabel.Text = DeskQuote.RushorderDays(DeskQuote.RushOrder);
            //OrderLabel.Text = DeskQuote.RushorderDays(myDesk.RushOrder);
            OrderLabel.Text = myDesk.RushorderDays(myDesk.RushOrder);
            //TotalLabel.Text = "$ " + DeskQuote.Total(Convert.ToInt32(DeskQuote.RushnumTotal(DeskQuote.RushOrder, Convert.ToInt32(Desk.Width), Convert.ToInt32(Desk.Depth))), Convert.ToInt32(Desk.Width), Convert.ToInt32(Desk.Depth), Desk.Drawers, Desk.DesktopMaterail).ToString();
            //TotalLabel.Text = "$ " + DeskQuote.Total(Convert.ToInt32(DeskQuote.RushnumTotal(myDesk.RushOrder, Convert.ToInt32(Desk.Width), Convert.ToInt32(Desk.Depth))), Convert.ToInt32(Desk.Width), Convert.ToInt32(Desk.Depth), Desk.Drawers, Desk.DesktopMaterail).ToString();
            TotalLabel.Text = "$ " + myDesk.Total(Convert.ToInt32(myDesk.RushnumTotal(myDesk.RushOrder, Convert.ToInt32(desk.Width), Convert.ToInt32(desk.Depth))), Convert.ToInt32(desk.Width), Convert.ToInt32(desk.Depth), desk.Drawers, desk.DesktopMaterailAsInt).ToString();
            TodaysDAte.Text = DateTime.Today.ToString("dd MMMM yyyy");

            
        }

        private void TodaysDAte_Click(object sender, EventArgs e)
        {

        }
    }
}
