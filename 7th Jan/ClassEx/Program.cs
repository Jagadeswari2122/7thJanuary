﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx
{ 
    class Student
    {
        private int rollno;  //accessor
        private int sem;
        private int marks;  //read-only         
        public string Name { get; set; }   //auto-implemented
        private string branch;

        public int RollNo
        {
            get
            {
                return rollno;
            }
            set
            {
                rollno = value;
                
            }
        }

        public int Sem
        {
            get
            {
                return sem;
            }
            set
            {
                sem = value;

            }
        }

        public int Marks
        {
            get
            {
                return marks;
            }
           
        }

        public string Branch
        {
            get
            {
                return branch;
            }
            set
            {
                branch = value;

            }
        }

        public Student()  //Default Constructor
        {
            Console.WriteLine("Default Constructor");
            Name = "";
            RollNo = 0;
            Sem = 4;
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Roll No : " + rollno);
        }

        public Student(string name,int rollno)
        {
            Console.WriteLine("\nParameterized Constructor");
            this.Name = name;
            this.rollno = rollno;


            Console.WriteLine("Name : " + name);
            Console.WriteLine("Roll No : " + rollno);
        }
          

        public void AcceptStudentDetails()
        {
            Console.WriteLine("Enter marks ");
            this.marks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter branch name ");
            this.branch = (Console.ReadLine());
            Console.WriteLine("Student details are accepted");
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("\nName : " + this.Name);
            Console.WriteLine("Roll No : " + this.rollno);
            Console.WriteLine("Branch : " + this.branch);
            Console.WriteLine("Sem : " + this.sem);
            Console.WriteLine("Marks : " + this.marks);
            Console.WriteLine("\nStudent details are displayed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Student st1 = new Student("Pranavi",48);
            Student st2 = new Student("Lav", 54);
            /*st.Name = "Pranavi";
            st.RollNo = 48;
            st.Sem = 4;
            st.AcceptStudentDetails();
            st.DisplayStudentDetails();
            */
            Console.ReadKey();
        }
    }
}
