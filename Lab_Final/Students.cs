using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Final
{
    internal class Students
    {
        public string id;
        public string name;
        public string attendance;
        public string quiz1;
        public string quiz2;
        public string quiz3;
        public string quiz4;
        public string mid;
        public string final;
        public string viva;

        public double sum;
        public double percentage;
        public double total;
        public string grade;

        public double GetTotal()
        {
            int lowest = 0;

            if ((Convert.ToInt32(quiz1) < Convert.ToInt32(quiz2)) && (Convert.ToInt32(quiz1) < Convert.ToInt32(quiz3)) && (Convert.ToInt32(quiz1) < Convert.ToInt32(quiz4)))
                lowest = Convert.ToInt32(quiz1);

            if ((Convert.ToInt32(quiz2) < Convert.ToInt32(quiz1)) && (Convert.ToInt32(quiz2) < Convert.ToInt32(quiz3)) && (Convert.ToInt32(quiz2) < Convert.ToInt32(quiz4)))
                lowest = Convert.ToInt32(quiz2);

            if ((Convert.ToInt32(quiz3) < Convert.ToInt32(quiz1)) && (Convert.ToInt32(quiz3) < Convert.ToInt32(quiz2)) && (Convert.ToInt32(quiz3) < Convert.ToInt32(quiz4)))
                lowest = Convert.ToInt32(quiz3);

            if ((Convert.ToInt32(quiz4) < Convert.ToInt32(quiz1)) && (Convert.ToInt32(quiz4) < Convert.ToInt32(quiz2)) && (Convert.ToInt32(quiz4) < Convert.ToInt32(quiz3)))
                lowest = Convert.ToInt32(quiz4);

            sum = Convert.ToInt32(quiz1) + Convert.ToInt32(quiz2) + Convert.ToInt32(quiz3) + Convert.ToInt32(quiz4) - lowest;

            return sum;
        }

        public double calculateTotal()
        {
            total = (Convert.ToDouble(attendance) + Convert.ToDouble(mid) + Convert.ToDouble(final) + Convert.ToDouble(viva) + GetTotal());
            return total;
        }

        public double GetPercentage()
        {
            percentage = calculateTotal() / 3;
            percentage = Math.Round(percentage, 2);
            return percentage;
        }

        public string GetGrade()
        {
            if (percentage < 40)
                grade = "F";
            else if (percentage < 45 && percentage >= 40)
                grade = "D";
            else if (percentage < 50 && percentage >= 45)
                grade = "C";
            else if (percentage < 55 && percentage >= 50)
                grade = "C+";
            else if (percentage < 60 && percentage >= 55)
                grade = "B-";
            else if (percentage < 65 && percentage >= 60)
                grade = "B";
            else if (percentage < 70 && percentage >= 65)
                grade = "B+";
            else if (percentage < 75 && percentage >= 70)
                grade = "A-";
            else if (percentage < 80 && percentage >= 75)
                grade = "A";
            else
                grade = "A+";

            return grade;
        }

        public string getInfo()
        {
            return (id + "\t" + name + "\t\t" + GetPercentage() + "%" + "\t\t" + GetGrade());
        }
    
}
}
