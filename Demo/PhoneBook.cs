using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class PhoneBook
    {

        string[] names;
        long[] numbers;

        public PhoneBook(int size)
        {
            names = new string[size];
            numbers = new long[size];
        }

        //public void AddPerson(string name, long number, int index)
        //{
        //    names[index]=name;
        //    numbers[index]=number;
        //}

        //public long this[string name]
        //{ 
        //   get 
        //    {
        //        for (int i = 0; i < names.Length; i++)
        //        {
        //            if (names[i] == name)
        //                return numbers[i];
        //        }
        //        return 0;
        //    }

        //    set 
        //    {
        //        for (int i = 0; i < names.Length; i++)
        //        {
        //            if (names[i] == name)
        //                numbers[i] = value;
        //        }
        //    }
        //}



        //public long GetNumber(string name)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    { 
        //       if (names[i] == name)
        //            return numbers[i];
        //    }
        //    return -1;
        //}

        //public void UpdateNumber(string name,long newnumber)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (names[i] == name)
        //             numbers[i]= newnumber;
        //    }

        //}

    }
}
