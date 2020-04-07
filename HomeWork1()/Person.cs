using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1__
{
    class Person
    {
        int weight;
        public int Weight
        {
            get
            {
                return weight;
            }
            
        }
        public int High { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }
        int age;
        public int Age
        {
            
            set
            {
                age = value;
            }
        }
        public Person(int high, string name,bool gender, int age  )
        {
            Age = age;
            High = high;
            Name = name;
            Gender = gender;
        }
        public int Method1(int property3, int property2, int property1)
        {
            int a = 10;
            return a;
        }
        public void Method2()
        {
            int a = 0;
        }

        public override string ToString()
        {
            string gender = "Woman";
            if(Gender)
            {
                gender = "Man"; 

            }
            return $"!Age is: {age};High is: {High}; Name is:{Name} Gender is: {gender}";
            
        }
    }
}
