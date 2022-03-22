using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_TASK_4
{
    public partial class powerbox : Form
    {
        List<Medecine> medicines = new List<Medecine>();
        public powerbox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idtextbox.Text);
            int price = Convert.ToInt32(pricetextbox.Text);
            string name = nametextbox.Text;
            int quantity = Convert.ToInt32(quantitytextbox.Text);
            string power = powertextbox.Text;

            Medecine dummy_m=new Medecine(id, name, power, quantity, price);
            medicines.Add(dummy_m);

            MessageBox.Show("Medicines has been added!!");






        }

        private void button2_Click(object sender, EventArgs e)
        {
            int medicineid = Convert.ToInt32(medidtextbox.Text);
            int sellquantity = Convert.ToInt32(quantity2textbox.Text);

            foreach(Medecine medicine in medicines)
            {
                if(medicine.id==medicineid)
                {
                    if(medicine.quantity<=0 || medicine.id<=sellquantity)
                    {
                        MessageBox.Show("Out of stock :(");
                    }

                else
                    {
                        medicine.quantity = medicine.quantity - sellquantity;
                        medicine.balance = medicine.balance + (medicine.quantity * medicine.price);
                        MessageBox.Show("medicine has been Sold :)");
                    }
                }
            }




        }

        private void button4_Click(object sender, EventArgs e)
        {
            int stockid = Convert.ToInt32(medicineIdTextBox.Text);

            foreach(Medecine medicine in medicines)
            {
                if(medicine.id==stockid)
                {
                    namelabelbox.Text = medicine.name.ToString();
                    powerlabelbox.Text = medicine.power.ToString();
                    quantitylabelbox.Text = medicine.quantity.ToString();




                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Balance total = new Balance();

            foreach(Medecine medicine in medicines)
            {

                total.totalbalance = (medicine.price * medicine.quantity) - total.totalbalance;

            }
            balancelabelbox.Text = Convert.ToString(total.totalbalance);
        }
    }
}
