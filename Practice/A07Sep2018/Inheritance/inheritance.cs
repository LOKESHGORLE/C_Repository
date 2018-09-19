using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A07Sep2018.Inheritance
{
    class inheritance
    {
        static void Main2(string[] args)
        {



            //PersonalInformation p = new PersonalInformation("x",9);
            Console.WriteLine("enter student name");
            string x = Console.ReadLine();
            Student s = new Student(x, DateTime.Now, 9);
            teacher t = new teacher("tead", DateTime.Now);
            PersonalInformation p = new PersonalInformation("PI", DateTime.Now);
            PersonalInformation pt = new teacher("pt", DateTime.Now);
            PersonalInformation ps = new Student("ps", DateTime.Now);

            //s.Name = "lokesh";
            Console.WriteLine(s.Name);
            Console.WriteLine("age:" + s.Age + "     grade: " + s.Grade);

            s.displayDoB();
            s.PrintDetails();
            t.PrintDetails();
            p.PrintDetails();
            pt.PrintDetails();
            ps.PrintDetails();

            //Console.WriteLine("printed by TEAC");


            Console.ReadLine();
        }
    }

    class PersonalInformation
    {
        public string Name;
        private DateTime _Dob;
        private int _age;
        public PersonalInformation(string pName, DateTime pDob)
        {
            Name = pName;
            Dob = pDob;
        }
        static PersonalInformation()
        {
            string OldNew = "lokesh";
        }
        private int AgeCalculate(DateTime pDob)
        {
            return 1;// DateTime.Now-pDob.Date
        }

        public DateTime Dob
        {
            get { return _Dob; }
            set
            {
                _Dob = value;
                _age = AgeCalculate(_Dob);
            }
        }
        public int Age
        {
            get { return _age; }
        }

        protected void printDoB()
        {
            Console.WriteLine("age: " + Age);
        }
        public virtual void PrintDetails()
        {
            Console.WriteLine("details with base method    {0}", Age);

        }
    }
    class Student : PersonalInformation
    {
        public int Grade;
        public int[] Marks = new int[6];
        public Student(string name, DateTime Dob, int Grade = 2) : base(name, Dob)
        {
            this.Grade = Grade;
        }

        public void displayDoB()
        {
            printDoB();

        }
        public override void PrintDetails()
        {
            Console.WriteLine("details with student method   {0}", Age);
            Console.WriteLine(StaticProp.DefaultGrade);
        }


    }
    class teacher : PersonalInformation
    {
        public string[] subject = new string[5];

        public teacher(string name, DateTime Dob) : base(name, Dob)
        {

        }
        public override void PrintDetails()
        {
            Console.WriteLine("details with teacher method   {0}", Age);

        }

    }
    static class StaticProp
    {
        public static int DefaultGrade = 5;
        //{
        //    get {
        //        return DefaultGrade;
        //    }
        //    set {
        //        DefaultGrade= 1; }
        //}

    }
}

