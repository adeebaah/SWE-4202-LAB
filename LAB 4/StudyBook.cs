using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Managementt
{
    internal class StudyBook : Book
    {
        public string ISM;
        public string genre;


        public StudyBook(int id, string title, string author, string ism,int quantity)
        {

            this.id = id;
            this.title = title;
            this.author = author;
            this.ISM = ism;
            this.quantity = quantity;



        }

        public string getInfo()
        {
            return this.id.ToString() + "\t" + this.title + "\t" + this.author + "\t" + this.quantity;
        }
    }
}
