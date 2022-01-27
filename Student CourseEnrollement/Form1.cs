using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_CourseEnrollement
{
    public partial class Form1 : Form
    {
        List<Student> student = new List<Student>();
        List<Proff> proffs = new List<Proff>();
        List<Course> courses = new List<Course>();




        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nametextbox.Text;
            string email = emailtextbox.Text;
            string contact = contacttextbox.Text;
            int reg = Convert.ToInt32(regtextbox.Text);
            string level;
            double fee = 0;

            bool student_check = studentbutton.Checked;
            bool prof_check = proffbutton.Checked;

            bool beginner_check = beginnerbutton.Checked;
            bool advanced_check = advancedbutton.Checked;
            bool interm_check = interbutton.Checked;

            if(beginner_check==true)
                {
                level = beginnerbutton.Text;
            }
            else if(advanced_check==true)
            {
                level = advancedbutton.Text;

            }
            else if(interm_check==true)
            {
                level = interbutton.Text;

            }
            else
            {
                level = beginnerbutton.Text; 
            }

            if (student_check == true)
            {
                Student dummy_student = new Student(name, reg, email, contact, level, fee);
                student.Add(dummy_student);
                selectstudentcombobox.Items.Add(dummy_student.name);
                selectstudent2.Items.Add(dummy_student.name);
                MessageBox.Show("Student has been added.");
            }
            if(prof_check==true)
            {
                Proff dummy_pro = new Proff(name, reg, email, contact, level, fee);
                proffs.Add(dummy_pro);
                selectstudentcombobox.Items.Add(dummy_pro.name);
               
                MessageBox.Show("Proffessional has been added.");

            }


           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string title = titletextbox.Text;
            double cfee = Convert.ToDouble(feetextbox.Text);
            string level;

            bool beg_check = radioButton6.Checked;
            bool int_check = radioButton7.Checked;
            bool ad_check=radioButton8.Checked;

            if(beg_check==true)
            {
                level = radioButton6.Text;
            }
            else if(int_check==true)
            {
                level= radioButton7.Text;

            }
            else if(ad_check==true)
            {
                level = radioButton8.Text;
            }
            else
            {
                level = radioButton6.Text;
            }

            Course dummy_course = new Course(title, cfee, level);

            courses.Add(dummy_course);
            coursebox.Items.Add(dummy_course.title);
            MessageBox.Show("Course has been added.");




        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string selected_student = selectstudentcombobox.SelectedItem.ToString();
            string selected_course = coursebox.SelectedItem.ToString();

            foreach(Student student in student)
            {
                if(student.name==selected_student)
                {
                    foreach(Course course in courses)
                    {
                        if((course.title==selected_course)&&(student.level==course.level))
                        {
                            student.Enroll(course.title);
                            coursefeelabel.Text = Convert.ToString(student.getFee(course.cfee));
                        }
                    }
                }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnrolledCourses.Items.Clear();
            string selected_student = selectstudent2.SelectedItem.ToString();

            foreach(Student student in student)
            {
                if(selected_student==student.name)
                {
                    EnrolledCourses.Items.Add(student.enrolledcourses());

                }

                foreach(Proff proffessors in proffs)
                {
                    if(selected_student==proffessors.name)
                    {
                        EnrolledCourses.Items.Add(proffessors.enrolledcourses());
                    }
                }
            }

        }
    }
}
