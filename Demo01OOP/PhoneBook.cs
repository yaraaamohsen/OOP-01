using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01OOP
{
    internal struct PhoneBook
    {
        string[] names;
        long[] numbers;


        //public PhoneBook (int size)
        //{
        //    names = new string[size];
        //    numbers = new long[size];
        //}

        //public void AddPhone(string name , long number , int index)
        //{
        //    names[index] = name;
        //    numbers[index] = number;
        //}

        //public long this[string name]
        //{
        //    set
        //    {
        //        for (int i = 0; i < names.Length; i++)
        //        {
        //            if (names[i] == name)
        //                numbers[i] = value;
        //        }
        //    }

        //    get
        //    {
        //        for (int i = 0; i < names.Length; i++)
        //        {
        //            if (names[i] == name)
        //                return numbers[i];
        //        }
        //        return -1;
        //    }
        //}

        //public string this[long number]
        //{
        //    set
        //    {
        //        for (int i = 0; i < names.Length; i++)
        //        {
        //            if (numbers[i] == number)
        //                names[i] = value;
        //        }
        //    }

        //    get
        //    {
        //        for (int i = 0; i < numbers.Length; i++)
        //        {
        //            if (numbers[i] == number)
        //                return names[i];
        //        }
        //        return "";
        //    }
        //}

        //public long GetNumber(string Name)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (names[i] == Name)
        //            return numbers[i];
        //    }
        //    return -1;
        //}

        //public string GetName(long number)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] == number)
        //            return names[i];
        //    }
        //    return "";
        //}

        //public void UpdateNumber (string name , long NewNumber)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (names[i] == name)
        //            numbers[i] = NewNumber;
        //    }
        //}

        //public void UpdateName(long number , string NewName)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (numbers[i] == number)
        //            names[i] = NewName;
        //    }
        //}
    }
}
