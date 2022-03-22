using System;

namespace Animals;

public class Animal
{
    private string nameOfAnimal;
    private string habitat_area;
    private string sound;
    private int weight;
    private int height;
    private int birthyear = 2021;

    public Animal()
    {
        this.nameOfAnimal = " ";
        this.habitat_area = "";
        this.sound = "";
        this.weight = 4;
        this.height = 20;
    }

    public void setname(string nameOfAnimal)
    {
        this.nameOfAnimal = nameOfAnimal;
    }
    public void sethabitat(string habitat_area)
    {
        this.habitat_area = habitat_area;
    }
    public void setsound(string sound)
    {
        this.sound = sound;

    }
    public void setweight(int weight)
    {
        this.weight = weight;
    }
    public void setheight(int height)
    {
        this.height = height;
    }
    public string getname()
    {
        return nameOfAnimal;
    }
    public string gethabitat()
    {
        return habitat_area;
    }
    public string getsound()
    {
        return sound;
    }
    public int getweight()
    {
        return weight;
    }
    public int getheight()
    {
        return height;
    }
    public int getAge()
    {
        return (2022 - birthyear);
    }
    public string getInformation()
    {
        return ("Name :" + nameOfAnimal + "\n" + "Habitat Area :" + habitat_area + "\n" + "Weight :" + weight + "\n" + "Height :" + height + "\n");
    }
    public virtual string vocalize()
    {
        return sound;
    }

    public class cat : Animal
    {
        public override string vocalize()
        {
            return "MEOW";
        }
    }
    public class cow : Animal
    {
        public override string vocalize()
        {
            return "MOO";
        }
    }
    public class Chicken : Animal
    {
        public override string vocalize()
        {
            return "BUCK BUCK";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            cow dummy_cow = new cow();
            dummy_cow.birthyear = 2012;

            if (dummy_cow.birthyear <= 2021)
            {
                dummy_cow.nameOfAnimal = "Cow";
                dummy_cow.habitat_area = "Land";
                dummy_cow.weight = 10;
                dummy_cow.height = 5;


                Console.WriteLine("Age: " + dummy_cow.getAge());
                Console.WriteLine(dummy_cow.getInformation());
                Console.WriteLine("Sound : " + dummy_cow.vocalize());
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine("\n"+"_____________________________________");

            cat dummy_cat = new cat();
            dummy_cat.birthyear = 2019;

            if(dummy_cat.birthyear<=2021)
            {
                dummy_cat.nameOfAnimal = "Cat";
                dummy_cat.habitat_area = "They are like water so they can live everywhere ";
                dummy_cat.weight = 10;
                dummy_cat.height = 8;

                Console.WriteLine(dummy_cat.getInformation());
                Console.WriteLine("Age :" + dummy_cat.getAge());
                Console.WriteLine("Sound :" + dummy_cat.vocalize());

            }
            else
            {
                Console.WriteLine("Invalid Input");

            }
            Console.WriteLine("\n" + "_____________________________________");

            Chicken dummy_chick = new Chicken();
            dummy_chick.birthyear = 2017;

            if (dummy_chick.birthyear <= 2021)
            {
                dummy_chick.nameOfAnimal = "Chicken";
                dummy_chick.habitat_area = "Land";
                dummy_chick.weight =2;
                dummy_chick.height = 5;

                Console.WriteLine(dummy_chick.getInformation());
                Console.WriteLine("Age :" + dummy_chick.getAge());
                Console.WriteLine("Sound :" + dummy_chick.vocalize());

            }
            else
            {
                Console.WriteLine("Invalid Input");

            }
            Console.WriteLine("\n" + "_____________________________________");

        }

        

        
    }
}
