using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_TASK_4
{
    public class Medecine
    {
        public int id;
        public string name;
        public string power;
        public int quantity;
        public int price;
        public int balance=0;

        public Medecine(int id,string name,string power,int quantity,int price)
        {
            this.id = id;
            this.name = name;
            this.power = power;
            this.quantity = quantity;
            this.price = price;
        }

    }
}
