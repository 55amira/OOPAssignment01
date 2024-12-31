using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assign01
{
    internal struct Person
    {
        string name;
        int age;

        
      
      public string Name
      {
          set { name = value; }
          get { return name; }
       
      }
      public int Age
      {
          set { age = value; }
          get { return age; }

      }

      public void AddPerson(string name, int age)
      {
          this.name = name;
          this.age = age;
      }

        //public void AddPerson(string name, int age)
        //{
        //    this.name = name;
        //    this.age = age;
        //}




    }
}
