using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1__
{
    class Company
    {
        public string CompanyName { get; set; }
        public Person[] ArrayOfEmployee { get; set; }
        
        public Company(string companyName)
        {
            //Person[] jaschick = new
            CompanyName = companyName;

            ArrayOfEmployee = new Person[100];
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < ArrayOfEmployee.Length; i++)
            {
                if (ArrayOfEmployee[i] == null) { break; }
                str += $"{ArrayOfEmployee[i].ToString()}\n";
            }
            return str;
        }
    }
    //[a,2,3,4]
}
