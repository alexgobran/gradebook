using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        
        
        static void Main(string[] args)

            {

            var bookAlex = new Book("Alex's Grades");
          

            

            

           
            bookAlex.AddGrade(92.3);
            bookAlex.AddGrade(22.5);
            bookAlex.AddGrade(88.6);
            bookAlex.AddGrade(94.5);

            bookAlex.showStats();
           
                
                      
        }   

    }
}
