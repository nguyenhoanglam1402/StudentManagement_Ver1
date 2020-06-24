using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudentManagement_Ver1
{
	class ClassRoom
	{
		public List<Student> Students= new List<Student>();
		public void GetListStudent()
		{
			Interface.HeaderOfListTable();
			foreach (Student student in Students)
			{
				student.GetInformation();
			}
			Console.ResetColor();
		}
		public void SelectStudentByID(string id)
		{
			var result = Students.Where(student => student.Id == id).ToList();
			if (result.Count !=0)
			{
				Interface.HeaderOfListTable();
				result[0].GetInformation();
				Interface.SetColorG();
				Console.WriteLine("\n\tPRESS ANY KEY TO RETURN HOME SCREEN !");
				Console.ResetColor();
			}
			else
			{
				Interface.SetColorR();
				Console.WriteLine("\n\tTHIS STUDENT DOESN'T EXIST !");
				Console.ResetColor();
			}
		}
		public void EditGrade(string id, float physicGrade, 
								float mathGrade, float englishGrade)
		{
			var result = Students.Where(student => student.Id == id).ToList();
			if (result.Count != 0)
			{
				Interface.HeaderOfListTable();
				result[0].EditGrade(physicGrade, mathGrade, englishGrade);
				Interface.SetColorG();
				Console.WriteLine("\n\tDONE !\n");
				Console.WriteLine("PRESS ANY KEY TO RETURN HOME SCREEN !");
				Console.ResetColor();
			}
			else
			{
				Interface.SetColorR();
				Console.WriteLine("\n\tTHIS STUDENT DOESN'T EXIST !");
				Console.ResetColor();
			}
		}
		public void GetListBestStudent()
		{
			var result = Students.OrderByDescending(student => student.CalculateAvarage());
			Console.WriteLine(result);
		}
	}
}
