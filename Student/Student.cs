using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student
    {
         int Id;
         string Name;
         string DepartMent;
         string Email;


        public int GetId()
         {
             return Id;
         }
         public void AddStudent(bool IsUpdate)
         {
            if (IsUpdate != true)
            {
                Console.WriteLine("Enter Student Id: ");
                Id = Convert.ToInt32(Console.ReadLine());

            }
             
             Console.WriteLine("Enter Student Name: ");
             Name=Console.ReadLine().Trim();
             Console.WriteLine("Enter Student Department: ");
             DepartMent = Console.ReadLine().Trim();
             Console.WriteLine("Enter Student Email: ");
             Email=Console.ReadLine().Trim();
         }

        /*public void UpdateData()
        {
            Console.WriteLine("Enter Student Name: ");
            Name = Console.ReadLine().Trim();
            Console.WriteLine("Enter Student Department: ");
            DepartMent = Console.ReadLine().Trim();
            Console.WriteLine("Enter Student Email: ");
            Email = Console.ReadLine().Trim();
        }*/
         public void DisplayStudent()
         {
             Console.WriteLine($"{Id} || {Name} || {DepartMent} || {Email}");
         }

         public bool CheckId(int id)
         {
            return this.Id== id;
         }
        public bool CheckStudent(Student[] _student)
         {
             for (int i = 0; i < _student.Length; i++)
             {
                 if (_student[i] != null)
                 {
                     if (_student[i].CheckId(this.Id))
                     {
                         return true;
                     }
                 }


             }
             return false;
         }
       

      
    }

}

