using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
  // interfac Idetails 
   public interface Idetails
   {
     void putData();
   }
   public class Student: Idetails
   {
       private int rno;
       private string firstname;
	   private string lastname;
       private double marks;
       public Student(int r, string f, string l, double m)
       {
           this.rno = r;
           this.firstname = f;
		   this.lastname = l;
           this.marks = m;
       }
       public void putData()
       {
           Console.WriteLine("Roll Number = {0}", rno);
           Console.WriteLine("FirstName = {0}", firstname);
		    Console.WriteLine("LastName = {0}", lastname);
           Console.WriteLine("Marks = {0}", marks);
           Console.WriteLine();
       }
   }
   public class Teacher: Idetails
   {
       private int id;
       private string firstname;
	   private string lastname;
       private string subject;
       public Teacher(int i, string f, string l, string s)
       {
           this.id = i;
           this.firstname = f;
		   this.lastname = l;
           this.subject = s;
       }
       public void putData()
       {
           Console.WriteLine("ID = {0}", id);
           Console.WriteLine("FirstName = {0}", firstname);
		   Console.WriteLine("LastName = {0}", lastname);
           Console.WriteLine("Subject = {0}", subject);
           Console.WriteLine();
       }
   }
   class program
   {
     static void Main(string[] args)
     {
        Student s1 = new Student(1, "John", "potter", 78.5);
        Student s2 = new Student(2, "Sara", "Tendulkar", 60.0);
        Student s3 = new Student(3, "Bruce", "wayne", 98.5);
        s1.putData();
        s2.putData();
        s3.putData();
     
	    Teacher t1 = new Teacher(1, "Mikale", "Jhone", "English");
        Teacher t2 = new Teacher(2, "Raghuram", "shing", "Hindi");
        Teacher t3 = new Teacher(3, "Stuart", "binny", "Maths");
		Teacher t4 = new Teacher(4, "Richard", "hardy", "pt");
        t1.putData();
        t2.putData();
        t3.putData();
		t4.putData();
	 }
	 
   }
}