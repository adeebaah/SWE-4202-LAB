using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvv
{
    internal class Empployee
    {
        public string name;
        public string id;
        public string address;
        public string salary;
        public string firstname;
        public string lastname;
        public string hiredate;
        public string email;
        public string jobId;
        public string number;
        public string commm;
        public string managerID;


        public string getInfo()
        {
            return (id + "\t" + firstname);
    }
    }

   
}
