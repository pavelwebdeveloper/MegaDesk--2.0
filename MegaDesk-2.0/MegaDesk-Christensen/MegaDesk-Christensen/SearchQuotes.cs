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
    public partial class SearchQuotes : Form
    {
        public string desktop_Material;
        
        List<DeskQuote> foundDeskQuotes;
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox desktopMaterialInput = sender as ComboBox;
            desktop_Material = desktopMaterialInput.SelectedValue.ToString();

            //MessageBox.Show($"{desktop_Material}");

            foundDeskQuotes = new List<DeskQuote>();

            //MessageBox.Show($"{Program.deskQuoteList.Count()}");

            foreach (DeskQuote deskQuote in Program.deskQuoteList)
            {
                //MessageBox.Show($"{deskQuote}");
                if (deskQuote.Desktop_Material == desktop_Material)
                {
                    foundDeskQuotes.Add(deskQuote);
                }
            }

            
            DataGridView.DataSource = foundDeskQuotes;



        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Desk.DesktopMaterial));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu MM = new MainMenu();
            MM.ShowDialog();
            this.Close();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {

        }
    }
}
