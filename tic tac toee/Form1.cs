using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dhgjd
{
    public partial class B2 : Form
    {

        bool turn = true;
        int turn_count = 0;

        public B2()
        {
            InitializeComponent();
        }

      

        private void A2_Click(object sender, EventArgs e)
        {

        }

        private void A3_Click(object sender, EventArgs e)
        {

        }

        private void B1_Click(object sender, EventArgs e)
        {

        }

        private void bb2_Click(object sender, EventArgs e)
        {

        }

        private void B3_Click(object sender, EventArgs e)
        {

        }

        private void C1_Click(object sender, EventArgs e)
        {

        }

        private void C2_Click(object sender, EventArgs e)
        {

        }

        private void C3_Click(object sender, EventArgs e)
        {

        }

        private void checkForWinner()
        {
           // DisableButtons();
            bool there_is_a_winner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
           else if ((B1.Text == bb2.Text) && (bb2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            
                there_is_a_winner = true;

            if(there_is_a_winner)
            {
                String winner = " ";
                if (turn)
                    winner = "0 ";
                else
                    winner = "X ";
                MessageBox.Show(winner +"\t"+ "wins!!"); 


              
            }
            else
            {
                if(turn_count==9)
                {
                    MessageBox.Show("Draw!!!");
                }
            }
           
               

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "0";
            turn = !turn;
            b.Enabled = false;
            checkForWinner();
            turn_count++;
        }
        private void DisableButtons()
        {
            foreach (Control c in Controls)
            {
                try
                {

                    Button b = (Button)c;
                    b.Enabled = false;
                }

                catch { }
            }

            ResetButton.Enabled = true;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            turn = true;

            turn_count = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = " ";
                }

                catch { }
            }
        }

       
    }
}

