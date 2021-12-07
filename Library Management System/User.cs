using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class User
    {
        public int userid;
        public string name;
        public string address;
        public List<int> books = new List<int>();

        public User()
        {
        }

        public User(int userid, string name, string address)
        {
            this.userid = userid;
            this.name = name;
            this.address = address;
        }

        public void AddBook(int id)
        {
            books.Add(id);
        }
    }
}
    

