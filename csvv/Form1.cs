using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace csvv
{

    public partial class Form1 : Form
    {
        List<Empployee> employees = new List<Empployee>();


        public Form1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"C:\Users\LENOVO\Downloads\employees.csv"))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    Empployee dummy = new Empployee();

                    dummy.id = values[0];
                    dummy.firstname = values[1];
                    dummy.lastname = values[2];
                    dummy.email = values[3];
                    dummy.number = values[4];
                    dummy.hiredate = values[5];
                    dummy.jobId = values[6];
                    dummy.salary = values[7];
                    dummy.commm = values[8];

                    dummy.managerID = values[9];

                    employees.Add(dummy);
                    emplistbox.Items.Clear();
                    foreach(Empployee emmp in employees)
                    {
                        emplistbox.Items.Add(emmp.getInfo());

                    }





                    listA.Add(values[0]);
                    listB.Add(values[1]);




                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

                string id = idtextbox.Text;
                string time = DateTime.Now.ToString();
                bool errorExist = true;

                foreach (Empployee emp in employees)
                {

                    if (id == emp.id)
                    {
                        errorExist = false;
                        namelabel.Text = emp.firstname +"\t"+ emp.lastname;
                        idlabel.Text = emp.id;
                        salarylabel.Text = emp.salary;
                        addresslabel.Text = emp.number;
                        break;
                    }


                }
                string path = @"C:\Users\LENOVO\Downloads\cvsfile.txt";

                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(id + " ");
                    sw.WriteLine(time + " ");

                    if (!errorExist)
                    {
                        foreach (Empployee emp in employees)
                        {
                            if (id == emp.id)
                            {
                                sw.WriteLine(emp.firstname + " " + emp.lastname + " " + emp.id + " " + emp.number + " " + emp.salary);
                            }
                        }
                    }




                }


            }
        }
}
    


       

