using StudentDatabase;
using System;
using System.Collections.Generic;

namespace Week2ListOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            List<StudentsObject> students = new List<StudentsObject>();
            students.Add(new StudentsObject("Cullin", "Fowlerville", "Pad Thai", 28));
            students.Add(new StudentsObject("Bill", "Boston", "Chicken Masala", 87));
            students.Add(new StudentsObject("Dan", "Dansville", "Danmeal", ));
            students.Add(new StudentsObject("George", "Grand Rapids", "Chicken feet", 43));

            Console.WriteLine($"There are {students.Count} students in the list so far.");

            //Here we shall pass objects 'students', 'favFoods', and 'hometowns' into one Master List. 
            //string[] masterlist = { Object1, Object 2, Object3 };

            Console.WriteLine($"Here's some info on the students in the list:");

            for (int i = 0; i <= students.Count-1; i++)
            {
                Console.WriteLine($"{i+1}: {students[i].StudentNameProperty} is from {students[i].HometownProperty}. {students[i].StudentNameProperty} is {students[i].StudentAge} years old.");
            }
        }
    }
}
