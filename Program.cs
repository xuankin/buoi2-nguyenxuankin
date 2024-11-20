using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhih
{
   
        internal class Program
        {


            static void Main(string[] args)
            {
            Console.OutputEncoding = Encoding.UTF8;
            List<student> students = new List<student>();

             
                students.Add(new student(1, "kin", 17));
                students.Add(new student(2, "danh", 20));
                students.Add(new student(3, "long", 16));
                students.Add(new student(4, "minh", 22));
                students.Add(new student(5, "An", 19));
            // cau 1 : in toan bo danh sach sinh vien 
            var allStudents = from student in students
                               select student;
            Console.WriteLine("Danh sach sinh vien :");
            foreach (var student in allStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Tên: {student.Name}, Tuoi :{student.Age}");
            }
            // cau 2 : in ra danh sach cac sinh vien co tuoi tu 15- 18 
            var filteredStudents = students
            .Where(student => student.Age >= 18 && student.Age <= 22)
            .ToList();

            Console.WriteLine("Danh sách sinh viên từ 18 đến 22 tuổi:");
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}");
            }
            // cau 3 : tim va in ra sinh vien co ten bat dau bang 'A'
            var studentsWithA = students
            .Where(student => student.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            .ToList();

            Console.WriteLine("Danh sách sinh viên có tên bắt đầu bằng chữ 'A':");
            foreach (var student in studentsWithA)
            {
                Console.WriteLine($"ID: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}");
            }
            // cau 4 tinh tong so tuoi tat ca hoc sinh 
            int totalAge = students.Sum(student => student.Age);

            Console.WriteLine($"Tổng tuổi của tất cả sinh viên: {totalAge}");
            // cau 5 sinh vien co tuoi lon nhat 
            var oldestStudent = students
            .OrderByDescending(student => student.Age)
            .FirstOrDefault();

            if (oldestStudent != null)
            {
                Console.WriteLine($"Sinh viên lớn tuổi nhất: ID: {oldestStudent.Id}, Tên: {oldestStudent.Name}, Tuổi: {oldestStudent.Age}");
            }
            else
            {
                Console.WriteLine("Không có sinh viên trong danh sách.");
            }
            //cau 6 sap xep theo tuoi tang dan 
            var sortedStudents = students
            .OrderBy(student => student.Age)
            .ToList();

           
            Console.WriteLine("Danh sách sinh viên sau khi sắp xếp theo tuổi tăng dần:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Tên: {student.Name}, Tuổi: {student.Age}");
            }

        }
        }
  }


