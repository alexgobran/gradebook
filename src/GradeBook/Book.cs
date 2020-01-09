using System;
using System.Collections.Generic;

namespace GradeBook 
{
    class Book 
    {       
         public Book(string name)
        {
          grades = new List<double>();
          bookName = name;
          
        }
      
         public void AddGrade (double grade)
     
        {
                  grades.Add(grade);
        }

        public void showStats ()
        {
            var result = 0.0;
            var average = 0.0;
            var highestGrade = double.MinValue;
            var lowestGrade = double.MaxValue;

            foreach (var grade in grades)
            {
                highestGrade = Math.Max( grade, highestGrade);
                lowestGrade = Math.Min( grade, lowestGrade);
            //can also use logic below instead of Math.Max/ Math.min
                // if (grade > highGrade){
                //     highGrade = grade;
                

                result += grade; 
                        
             
            }  
             average = result/grades.Count;
             Console.WriteLine($"Cumalitive grades {result}");      
             Console.WriteLine($"highest grade {highestGrade} ");
             Console.WriteLine($"lowest grade {lowestGrade} ");                     
             Console.WriteLine($"Grades Average {average}");
            
            if (average >= 69)
            
                 {
                        Console.WriteLine($"Everyone Passes!");
                    }
                    else 
                    {
                        Console.WriteLine("Everyone Fails the Class MUhahahah!");
                               
                 }   
                                 
        }
             
        
         private List<double> grades;
         private string bookName;
    }

         
}

