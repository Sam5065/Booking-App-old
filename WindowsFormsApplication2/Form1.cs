using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Genre.Items.Add("Action");
            Genre.Items.Add("Drama");
            Genre.Items.Add("Comedy");
            Genre.Items.Add("Horror");
        }

        ///Ignore below
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void Genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Genre.Text == "Action")
            {
                Films.Items.Clear();
                Films.Items.Add("Black Panther");
                Films.Items.Add("Spiderman: Homecoming");
                Films.Items.Add("Spiderman: Far from home");
                Films.Items.Add("Spiderman: Homeless");
                Films.Items.Add("Avengers: brexit killed us all");
                Films.Items.Add("Avengers: Iron Man Dies");
            }

            if (Genre.Text == "Comedy")
            {
                Films.Items.Clear();
                Films.Items.Add("Blockers");
                Films.Items.Add("Night School");
                Films.Items.Add("Holmes & Watson");
                Films.Items.Add("Game Night");
            }

            if(Genre.Text == "Horror")
            {
                Films.Items.Clear();
                Films.Items.Add("Horror 1");
                Films.Items.Add("Horror 2");
                Films.Items.Add("Horror 3");
                Films.Items.Add("Horror 4");
            }
        }

        private void SpecialRequire_SelectedIndexChanged(object sender, EventArgs e)
        {
          
                if (SpecialRequire.Text == "N/A")
                {
                    Row.Items.Clear();
                    Seat.Items.Clear();
                    Row.Items.Add("Any");
                    Row.Items.Add("Rows 1 - 10");
                    Row.Items.Add("Rows 11 - 20");
                    Row.Items.Add("Rows 21 - 30");
                }

                if (SpecialRequire.Text == "Wheelchair Access")
                {
                    Row.Items.Clear();
                    Seat.Items.Clear();
                    Row.Items.Add("Rows 1 - 10")
                }
         
        }

        private void Films_SelectedIndexChanged(object sender, EventArgs e)
        {
                SpecialRequire.Items.Clear();
                Row.Items.Clear();
                Seat.Items.Clear();
                SpecialRequire.Items.Add("N/A");
                SpecialRequire.Items.Add("");
        }
    }
}
