namespace Demo01OOP
{
    // 1. Class
    // 2. Struct
    // 3. Interface
    // 4. Enum
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            //// Struct : Value Type : STACK

            //// Employee
            //// Id, Name, Salary

            //Point PO1;
            //// Declare For Object From Type 'Point'
            //// PO1 : Object
            //// Allocate Unintialized 8 Bytes in Stack
            ////Console.WriteLine(PO1.X);
            //Point PO2 = new Point();
            //PO2 = new Point(3, 4);
            //// new : Used For Select The Constructor That Intialized Its Variable With The Default Value  
            //Console.WriteLine(PO2.X);

            #endregion

            #region OOP Overview
            // OOP : Object Oriented Programming
            // Programming PAradiam
            // OOP : The Paradiam Use For Build Any Buisness

            // Class    : Blueprint Of The Object
            // Object   : Specific Instance From The Class

            // 4 Pillers
            //      1. Encapsulation
            //      2. Inheritance
            //      3. Polymerphism
            //      4. Abstraction 
            #endregion

            #region Encapsulation Using Setter Getter
            // 1. Encapsulation
            // Class || Struct
            // Seprate The Data(Attributes) Defination From Its Use
            // [Setter Getter Method - Properties]

            // Employee (Id, Name, Salary)

            // 1. End User Access Data Itself
            // 2. No Data Validation
            // 3. No Read Only Filed

            // Apply Encapsulation
            // 1. Make All Data (Attributes) private
            // 2. Access Data Through :
            // 2.1. Setter GEtter Method
            // 2.2. Properties

            //Employee Emp01 = new Employee();
            //Emp01.id = 1;
            //Console.WriteLine(Emp01.id);

            //Employee E01 = new Employee(3, "Yara", -12000);
            //Console.WriteLine(E01); 
            #endregion

            #region Encapsulation With Eng Mariam Shindy
            PhoneBook note = new PhoneBook(3);
            note.AddPerson(0, "Mariam", 123);
            note.AddPerson(1, "Mona", 456);
            note.AddPerson(2, "Yara", 789);

            //Console.WriteLine(note);

            //int PhoneNumber = note.GetPhoneNumberByName("Mona");
            //Console.WriteLine(PhoneNumber);
           
            note["Yara"] = 999;
            //Console.WriteLine(note["Yara"]);

            for (int i = 0; i < note.Size; i++)
            {
                Console.WriteLine(note[i]);
            }


            #endregion

            // Apply Encapsulation Using Properties
            // 1. Full Property
            // 2. Automatic Property
            // 3. Special Property [Indexer]

            #region Indexer 
            // Indexer : Special Property :
            //          : 1. Name This 
            //          : 2. Must Take Parameter

            // PhoneBook :

            //PhoneBook phoneBook = new PhoneBook(3);

            //phoneBook.AddPhone("Lolo", 111, 0);
            //phoneBook.AddPhone("Ali", 222, 1);
            //phoneBook.AddPhone("Omar", 333, 2);
            //Console.WriteLine(phoneBook.GetNumber("Ali"));
            //Console.WriteLine(phoneBook.GetName(333));

            //phoneBook.UpdateNumber("Ali", 444);
            //Console.WriteLine(phoneBook.GetNumber("Ali"));

            //phoneBook.UpdateName(111, "lola");
            //Console.WriteLine(phoneBook.GetName(111));

            //phoneBook["Ali"] = 1111;  // long
            //Console.WriteLine(phoneBook["Ali"]); // long

            //phoneBook[333] = "Alio";  // string
            //Console.WriteLine(phoneBook[333]); // string
            #endregion

            #region Class
            // Class : Refernce Type : Heap 

            // Car : Id Model Speed 

            // Car C01;
            // Allocate to Reference (Pointer ) From Type 'Car'
            // Can Refer to Object from Type 'Car' 
            // C01 : Refer to Null 
            // Console.WriteLine(C01);

            // 8 Bytes In Stack
            // 0 Bytes In Heap

            // C01 = new Car(1,200,"xyz");

            // New 
            // 1. Allocate the Number Of Bytes At Heap 
            // 2. Initailized The Byres With Default Values 
            // 3. Call User-Defined If Exists 
            // 4. Assign The Object With The Refer

            // Console.WriteLine(C01);

            //Console.WriteLine(C01.Id);
            //Console.WriteLine(C01.Model);
            //Console.WriteLine(C01.Speed);

            #endregion
        }
    }
}
