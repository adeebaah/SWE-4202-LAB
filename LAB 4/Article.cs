using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Managementt
{
    internal class Article : Book
    {
        public string doi;
        public string con;

        public Article(int id, string title, string author, string doi, string publisher, string con)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.doi = doi;
            this.publisher = publisher;
            this.con = con;




        }
        public string getInfo()
        {
            return this.id.ToString() + "/t" + this.title + "/t" + this.author;
        }
    }
}
