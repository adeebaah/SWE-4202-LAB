using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        List<Books> books = new List<Books>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(UserIdBorrowBox.Text);
            int bookid = Convert.ToInt32(BookidBorrowBox.Text);

            //if (bookExists(bookid) && userExists(userid))
            //{
            foreach (Books book in books)
            {
                if (book.bookid == bookid)
                {
                    if (book.quantity < 1)
                    {
                        MessageBox.Show("Out of Stock :(");
                        break;
                    }

                    book.quantity -= 1;

                    foreach (User user in users)
                    {
                        if (user.userid == userid)
                        {
                            user.books.Add(bookid);
                            MessageBox.Show("Book has been added to the user.");
                        }
                    }
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(userIDText.Text);
            string name = nameText.Text;
            string address = addressText.Text;

            User dummy_user = new User(userid, name, address);
            users.Add(dummy_user);

            MessageBox.Show("User has been added successfully!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(bookIDBox.Text);
            string bookname = BookNmeBox.Text;
            string author = AuthorBox.Text;
            string publisher = PublisherBox.Text;
            int quantity = Convert.ToInt32(QuantityBox.Text);

            if (quantity < 0)
            {
                MessageBox.Show("Quantity cannot be negative.");
                return;
            }
            Books dummy_book = new Books(bookid, bookname, author, publisher, quantity);

            books.Add(dummy_book);

            MessageBox.Show("Book has been added successfully!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(BookidHistoryBox.Text);
            bool flag = false;

            foreach (Books book in books)
            {
                if (book.bookid == bookid)
                {
                    flag = true;
                    BookIdLabel.Text = book.bookid.ToString();
                    BookNameLabel.Text = book.bookname;
                    AuthorLabel.Text = book.author;
                    PublisherLabel.Text = book.publisher;
                    QuantityLabel.Text = book.quantity.ToString();
                }
            }

            if (flag == false)
            {
                MessageBox.Show("Book could not be found!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(UseridHistoryBox.Text);
            User dummy = new User();
            bool flag = false;
            foreach (User user in users)
            {
                if (user.userid == userid)
                {
                    flag = true;
                    dummy = user;
                    break;
                }
            }

            if (flag == false)
            {
                MessageBox.Show("User could not be found!");
            }

            UserHistoryList.Items.Clear();

            for (int i = 0; i < dummy.books.Count; i++)
            {
                int id_book = dummy.books[i];
                for (int j = 0; j < books.Count; j++)
                {
                    if (books[j].bookid == id_book)
                    {
                        UserHistoryList.Items.Add(books[j].UserHistory());
                    }
                }
            }
        }
    }
}
        

