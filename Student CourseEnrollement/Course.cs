using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_CourseEnrollement
{
    public class Course
    {
       public string title;
       public double cfee;
       public string level;

        public Course(string title,double cfee,string level)
        {
            this.title = title;
            this.cfee = cfee;
            this.level = level; 
        }



    }
}
