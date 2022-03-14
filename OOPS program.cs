using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OopsProgram
{
    //Encapsulation
    class Student
    {
	   private int rollno;
       private string firstname;
       private string lastname;
       private string address;
       private string skill1;
       private string skill2;
           
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
	  

	   public string FirstName
       {
           get
          {
             return firstname;
          }
          
           set
          {
             firstname = value;
          }
       }
	  
       public string LastName
       {
         get
         {
             return lastname;
         }
         set
         {
            lastname = value;
         }
       }
	   
	   public string Address
       {
         get
         {
             return address;
         }
         set
         {
            address = value;
         }
       }
           //Data Abstraction
       public string Skill1
       {
         get
         {
             return skill1;
         }
         set
         {
            skill1 = value;
         }
       }
           
       public string Skill2
       {
         get
         {
             return skill2;
         }
         set
         {
            skill2 = value;
         }
       }
        
         public void StudentDetails()
       {
          Console.WriteLine("First Name: " + FirstName);
          Console.WriteLine("Last Name: " + LastName);
       }
       public void StudentSkills()
       {
          Console.WriteLine("Student Skill1:" +Skill1);
		  Console.WriteLine("Student Skill2:" +Skill2);
       }
       private void StudentInterest() 
       {
          Console.WriteLine("Student Interest:"); 
       }
       private void StudentHabits()
       {
          Console.WriteLine("Student Good Habits information:");
		  Console.WriteLine("Student Bad Habits information:");
       }

    }
	   //Inheritance
	 class StudentInfo : Student
	{
         private string schoolclass;
          public string SchoolClass
       {
         get
         {
             return schoolclass;
         }
         set
         {
            schoolclass = value;
         }
       }
        //constructor
		public StudentInfo()
		{
			Console.WriteLine("StudentInfo constructor was called");
			this.RollNo = 23;
			this.FirstName = "Mikel";
			this.LastName = "Richard";
			this.Address = "grugram";
            this.SchoolClass = "XA";
		}
   
	}
         
    public class Polymorphism
	{
         public void Display()
		{
			Console.WriteLine("Hello");
		}
		
		public void Display(int n1)
		{
			Console.WriteLine("Number : "+n1);
		}
		
		public void Display(int n1, int n2)
		{
			Console.WriteLine("Sum : "+(n1 + n2));
            Console.WriteLine("Product : "+(n1 * n2));
            Console.WriteLine("Division : "+(n1 / n2));
		}
        
        public void Display(int n1, int n2, int n3)
		{
			Console.WriteLine("Sum : "+(n1 + n2 + n3));
            Console.WriteLine("Product : "+(n1 * n2 * n3));
		}
		
		public void Display(int n1, string name)
		{
			Console.WriteLine("Hello {0}, Value is : {1}", name, n1);
		} 
		
		public void Display(int n1, int n2, string name)
		{
			Console.WriteLine("Hello {0}, Sum is : {1 + 2}", name, n1, n2);
			Console.WriteLine("Hello {0}, Product is : {1 * 2}", name, n1, n2);
		} 
    }
    
	 class Teacher 
    {
        private int id;
        private string TeacherName;
        private string subject;
        
        public Teacher(int id, string TeacherName, string subject)
        {
            this.id = id;
            this.TeacherName = TeacherName;
            this.subject = subject;
        }
        public void getInfo()
        {
           Console.WriteLine("ID = {0}", id);
           Console.WriteLine("TeacherName = {0}", TeacherName);
		  Console.WriteLine("Subject = {0}", subject);
           Console.WriteLine();
        }
    }

    class Program
    {
           
      public static void Main(string[] args)
       {
          //Encapsulation
          Student s = new Student();
          // set values
          s.RollNo = 34;
		  s.FirstName = "Lovnish ";
		  s.LastName = "Bhardwaj ";
          s.Address = "H_No-143, Sector-21, Gurugram, Haryana ";
           
          // get values
          Console.WriteLine ("\nEncapsulation....");
          Console.WriteLine("RollNo: " + s.RollNo);
          Console.WriteLine("First Name: " + s.FirstName);
		  Console.WriteLine("Last Name: " + s.LastName);
          Console.WriteLine("Address: " + s.Address);
		  Console.WriteLine ("\n");
 
              
          //Data Abstraction
          Console.WriteLine ("\nData Abstraction....");
          s. Skill1 = "GCE";
          s. Skill2 = "IOT";
          s.StudentDetails();
          s.StudentSkills();
		  Console.WriteLine ("\n");
		  
           //Inheritance
           Console.WriteLine ("\nInheritance.....");
           StudentInfo si = new StudentInfo(); 
		   Console.WriteLine(si.RollNo);
		   Console.WriteLine(si.FirstName);
		   Console.WriteLine(si.LastName);
		   Console.WriteLine(si.Address);
          Console.WriteLine(si.SchoolClass);
            Console.WriteLine ("\n");
		 
       
          //
            Console.WriteLine ("\nConstructor...");
          Teacher t = new Teacher(1, "Richard", "English");
          Teacher t1 = new Teacher(2, "Harry", "PT");
          Teacher t2 = new Teacher(3, "Stuart", "Maths");
          Teacher t3 = new Teacher(4, "Raghuram", "Hindi");
          t.getInfo();
           t1.getInfo();
           t2.getInfo();
           t3.getInfo();
            Console.WriteLine ("\n");
		 
          
          //polymorphism
          Console.WriteLine ("\npolymorphism..");
			Polymorphism p = new Polymorphism();
            p.Display(); 
            p.Display(285, 150); 
			 Console.WriteLine ("\n");
			
			
          Console.WriteLine("\nPress Enter Key to Exit..");
          Console.ReadLine();
 
       }
	
    }
}