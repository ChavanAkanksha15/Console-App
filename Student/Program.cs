using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Student[] studentList = new Student[100];
             int index = 0;
             bool IsExit=false;
             while (IsExit==false)
             {
                 Console.WriteLine("Choice: ");
                 Console.WriteLine("Press 1. Add new Student.   Press 2. Display Student List.");
                 Console.WriteLine("Press 3. Search Student.    Press 4. Remove Student.");
                 Console.WriteLine("Press 5  Update Student     Press 5  Exit");
                 Console.WriteLine("----------------------------------------------------");
                 Console.WriteLine("Enter your choice: ");
                 int choice = Convert.ToInt32(Console.ReadLine());

                 switch (choice)
                 {
                     case 1:
                         Console.WriteLine("------------------ADD NEW STUDENT------------------");
                         if (index >= studentList.Length)
                         {
                             Console.WriteLine("List is full...");
                             break;
                         }
                         Student s1 = new Student();
                         s1.AddStudent(false);

                         if (s1.CheckStudent(studentList))
                         {
                             Console.WriteLine("--------------------------------------------------------------------");
                             Console.WriteLine($"Student with Id: {s1.GetId()} already exist in List");
                             Console.WriteLine("--------------------------------------------------------------------");
                             break;
                         }
                         studentList[index] = s1;
                         index++;
                         break;
                     case 2:
                         Console.WriteLine("------------------DISPLAY STUDENT LIST------------------");
                         for(int i = 0; i < studentList.Length; i++)
                         {
                             if (studentList[i] != null)
                             {
                                 studentList[i].DisplayStudent();
                             }

                         }
                         break;
                     case 3:
                         Console.WriteLine("------------------SEARCH STUDENT------------------");
                         Console.WriteLine("Enter Student Id: ");
                         int Student_id = Convert.ToInt32(Console.ReadLine());

                         for (int i = 0; i < studentList.Length; i++)
                         {
                             if (studentList[i] != null)
                             {
                                 if (studentList[i].CheckId(Student_id))
                                 {
                                     studentList[i].DisplayStudent();
                                 }
                                 else
                                 {
                                     Console.WriteLine("------------------------------------");
                                     Console.WriteLine("No student found ");
                                     Console.WriteLine("------------------------------------");
                                 }
                             }

                         }

                         break;
                     case 4:
                         Console.WriteLine("------------------REMOVE STUDENT------------------");
                         Console.WriteLine("Enter Student id to remove student: ");
                         int _id = Convert.ToInt32(Console.ReadLine());
                         for (int i = 0; i < studentList.Length; i++)
                         {
                             if (studentList[i] != null)
                             {
                                 if (studentList[i].CheckId(_id))
                                 {
                                     studentList[i] = null;
                                     Console.WriteLine("Student Remove Successfully.....");
                                 }
                                 else
                                 {
                                     Console.WriteLine("------------------------------------");
                                     Console.WriteLine("No student found ");
                                     Console.WriteLine("------------------------------------");
                                 }
                             }
                         }
                         break;
                     case 5:
                        Console.WriteLine("Enter id to update record: ");
                        int update = Convert.ToInt32(Console.ReadLine());

                        for(int i = 0; i < studentList.Length; i++)
                        {
                            if (studentList[i] != null)
                            {
                                if (studentList[i].CheckId(update))
                                {
                                    studentList[i].AddStudent(true);
                                }
                            }
                        }
                        break;
                    case 6:
                        IsExit = true;
                        break;
                    default:
                         Console.WriteLine("------------------------------------");
                         Console.WriteLine("Invalid Choice...Please try again");
                         Console.WriteLine("------------------------------------");
                         break;
                 }
             }

         
        }
    }   
}

