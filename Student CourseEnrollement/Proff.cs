using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_CourseEnrollement
{
    internal class Proff:Participant
    {



        public Proff(string name,int reg,string email,string contact,string level,double fee)
        {
            this.name = name;
            this.reg = reg;
            this.contact = contact;
            this.email = email;
            this.level = level;


        }

        public override double getFee(double fee)
        {
            double money = 0;
            money = money + fee + (.1 * fee);
            return money;
        }
    }
}
