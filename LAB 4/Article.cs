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

        public Article(string id, string title, string author, string doi, string publisher, string con)
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
            string articlelist = id + "t"+ title  + "t"+ author + "t"+ doi + "t"+ publisher +"t" + con;
            return articlelist;
        }
    }
}
