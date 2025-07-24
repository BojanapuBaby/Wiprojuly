using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = new Student[]
            {
                new Student(1,"Baby",7.5,"Mpl"),
                new Student(2,"Chinni",8.5,"Bng"),
                new Student(1,"Deekshi",9.5,"Kdp")
                
            };

            foreach (Student student in studentArray)
            {
                Console.WriteLine(student);
            }
        }

            
    }
 }
