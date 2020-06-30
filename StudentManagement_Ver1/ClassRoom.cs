using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement_Ver1
{
	internal class ClassRoom
	{
		public List<Student> Students = new List<Student>();

		public void RemoveStudentByID(string id)
		{
			var result = Students.Where(student => student.Id == id).ToList();
			bool confirm = Interface.ConfirmSubmissionBox();
			if (confirm && result.Count != 0)
			{
				Interface.SetColorGreen();
				Console.WriteLine("\n\tYOUR REQUEST IS SUBMITED !");
				Students.Remove(result[0]);
			}
			else if (!confirm)
			{
				Interface.SetColorRed();
				Console.WriteLine("\n\tYOUR REQUEST IS NOT SUBMITED !");
			}
			else
			{
				Interface.SetColorRed();
				Console.WriteLine("\n\tYou cannot remove a student who does not exist!");
			}
		}

		public void PrintAllStudents()
		{
			Interface.HeaderOfListTable();
			foreach (Student student in Students)
			{
				student.PrintInformation();
			}
			Console.ResetColor();
		}

		public void GetStudentByID(string id)
		{
			var result = Students.Where(student => student.Id == id).ToList();
			if (result.Count != 0)
			{
				Interface.HeaderOfListTable();
				result[0].PrintInformation();
				Interface.ShowRequestMessage();
				Console.ResetColor();
			}
			else
			{
				Interface.SetColorRed();
				Console.WriteLine("\n\tTHIS STUDENT DOESN'T EXIST !");
				Console.ResetColor();
			}
		}

		public void EditGradeByID(string id, float physicGrade,
								float mathGrade, float englishGrade)
		{
			var result = Students.Where(student => student.Id == id).ToList();
			if (result.Count != 0)
			{
				if (Interface.ConfirmSubmissionBox())
				{
					result[0].EditGrade(physicGrade, mathGrade, englishGrade);
					Interface.SetColorGreen();
					Console.WriteLine("\n\tTHIS REVISION HAS BEEN SUBMITED !");
					Console.ResetColor();
				}
				else
				{
					Interface.SetColorRed();
					Console.WriteLine("\n\tTHIS REVISION HAS BEEN DELETED !");
					Console.ResetColor();
					return;
				}
			}
			else
			{
				Interface.SetColorRed();
				Console.WriteLine("\n\tTHIS STUDENT DOESN'T EXIST !");
				Console.ResetColor();
			}
		}

		public void PrintStudentsWithHighestGrade()
		{
			var result = Students.OrderByDescending(student => student.CalculateAvarage()).ToList();
			foreach (Student student in Students)
			{
				if (student.CalculateAvarage() == result[0].CalculateAvarage())
				{
					student.PrintInformation();
				}
			}
			Interface.ShowRequestMessage();
		}

		public void PrintStudentsWithLowestGrade()
		{
			var result = Students.OrderBy(student => student.CalculateAvarage()).ToList();
			foreach (Student student in Students)
			{
				if (student.CalculateAvarage() == result[0].CalculateAvarage())
				{
					student.PrintInformation();
				}
			}
			Interface.ShowRequestMessage();
		}
	}
}