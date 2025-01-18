using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01OOP
{
    internal struct PhoneBook
    {
        #region With Eng/Ahmed Amin
        //string[] names;
        //long[] numbers;


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
        #endregion


        private string[] names;
        private int[] numbers;
        //private int Size;

        public int Size { get; }

        public PhoneBook(int size)
        {
            Size = size;
            names = new string[size];
            numbers = new int[size];
        }

        public void AddPerson(int Position, string PersonName, int PhoneNumber)
        {
            if(names is not null && numbers is not null)
            {
                if(Position < Size)
                {
                    names[Position] = PersonName;
                    numbers[Position] = PhoneNumber;
                }
               
            }
           
        }

        public int GetPhoneNumberByName(string PersonName)
        {
            if (names is not null && numbers is not null)
            {
                for(int i = 0; i < names.Length; i++)
                {
                    if (names[i] == PersonName)
                    return numbers[i];
                }
            }
            return -1; // Not Found
        }

        public void SetPhoneNumberByName(string PersonName, int NewPhoneNumber)
        {
            if(names is not null && numbers is not null)
            {
                for (int i = 0;i < names.Length; i++)
                {
                    if (names[i] == PersonName)
                    {
                        numbers[i] = NewPhoneNumber;
                        break;
                    }
                }
            }
        }

        // Indexer : Is A Special Property
        // 1. Named With This Keyword
        // 2. Property That Take Parameter

        public int this[string name]
        {
            get 
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                            return numbers[i];
                    }
                }
                return -1;
            }

            set
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            numbers[i] = value;
                            break;
                        }
                    }
                }
            }
        }


        // Index Overloading
        public string this[int index]
        {
            get
            {
                return $"{index + 1}, {names[index]}, {numbers[index]}";
            }
        }
    }
}
