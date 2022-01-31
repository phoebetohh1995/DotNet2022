using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOverloadingApp
{
    internal class Employee
    {
        string[] skills = new string[3];
        public Employee()
        {
            skills[0] = "C#";
            skills[1] = "MS SQL";
            skills[2] = "DevOps";
        }
        public string this[int index]
        {
            get { return skills[index]; }
            set { skills[index] = value; }
        }
    }

    Employee employee = new Employee();
            for (int i = 0; i< 3; i++)
            {
                Console.WriteLine(employee[i]);
            }

Employee e1 = new Employee();
Employee e2 = new Employee();
e1[0] = "Java";
Employee e3 = e1 + e2;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(e3[i]);
}
public static Employee operator +(Employee e1, Employee e2)
{
    Employee e = new Employee();
    for (int i = 0; i < e.skills.Length; i++)
    {
        if (e1[i] != e2[i])
        {
            e[i] = e1[i] + " and " + e2[i];
        }
        else
            e[i] = e1[i];
    }
    return e;
}
}

