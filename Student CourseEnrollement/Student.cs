using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_CourseEnrollement
{
    internal class Student : Participant
    {
        

        public Student(string name,int reg,string contact,string email,string level,double fee)
        {
            this.name = name;
            this.reg = reg;
            this.contact = contact;
            this.email = email;
            this.level = level;
            this.fee = fee;

        }
    }
}
