using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Managementt
{
   
    public partial class Form1 : Form
    {
        List<StudyBook> books = new List<StudyBook>();
        List<Article> articles = new List<Article>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void AddStudyBookButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDTextBox.Text);
            string title = TitleTextBox.Text;
            string author = AuthorTextBox.Text;
           
            string ism = ISMTextBox.Text;
            int quantity =Convert.ToInt32(QuantityTextBox.Text);


            StudyBook dummy = new StudyBook(id, title, author, ism, quantity);



                MessageBox.Show("study books has been added.");
            


    }

        private void AddResearchBookButton_Click(object sender, EventArgs e)
        {
            string id = ResearchIDTextBox.Text;
            string title = ResearchTitleTextBox.Text;
            string author = ResearchAuthorTextBox.Text;
            string publisher = ResearchPublisherTextBox.Text;
            string doi = DOITextBox.Text;
            string con = JournalTextBox.Text;
            Article dummy2 = new Article(id, title, author, publisher, doi, con);

            MessageBox.Show("Research articles has been added");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudyBookListBox.Items.Clear();
            for (int i=0; i < books.Count;i++)
                {
                StudyBookListBox.Items.Add(books[i].getInfo());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResearchBookListBox.Items.Clear();
            {
                for (int i = 0; i < books.Count; i++)
                {
                    ResearchBookListBox.Items.Add(articles[i].getInfo());
                }
                    
            }

        }

        private void StudyBookBorrowButton_Click(object sender, EventArgs e)
        {
            int studybookid = Convert.ToInt32(StudyBookIDTextBox.Text);

            foreach (StudyBook studybook in books)
            {
                if (studybook.id == studybookid)
                {
                    studybook.quantity = -1;
                }

            }
            MessageBox.Show("Study book has been borrowed!");
        }

        private void ResearchBookIDButton_Click(object sender, EventArgs e)
        {
            int articleid = Convert.ToInt32(ResearchBookIDTextBox.Text);
            foreach(Article article in articles)
            {
                if(article.id==articleid)
                {
                    article.quantity = -1;
                }
            }
            MessageBox.Show("Article has been borrowed!");
        }
    }
}
