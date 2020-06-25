﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement_Ver1
{
	class ClassRoom
	{
		public List<Student> Students = new List<Student>();
		public void RemoveStudent(string id)
		{
			var result = Students.Where(student => student.Id == id).ToList();
			if (Interface.ConfirmSubmissionBox())
			{
				Interface.SetColorG();
				Console.WriteLine("\n\tYOUR REQUEST IS SUBMITED !");
				Students.Remove(result[0]);
			}
			else
			{
				Interface.SetColorR();
				Console.WriteLine("\n\tYOUR REQUEST IS NOT SUBMITED !");
				return;
			}
		}
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
			if (result.Count != 0)
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
				if (Interface.ConfirmSubmissionBox())
				{
					result[0].EditGrade(physicGrade, mathGrade, englishGrade);
					Interface.SetColorG();
					Console.WriteLine("\n\tTHIS REVISION HAS BEEN SUBMITED !");
					Console.ResetColor();
				}
				else
				{
					Interface.SetColorR();
					Console.WriteLine("\n\tTHIS REVISION HAS BEEN DELETED !");
					Console.ResetColor();
					return;
				}
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
			var result = Students.OrderByDescending(student => student.CalculateAvarage()).ToList();
			foreach (Student student in Students)
			{
				if (student.CalculateAvarage() == result[0].CalculateAvarage())
				{
					student.GetInformation();
				}
			}
			Interface.SetColorG();
			Console.WriteLine("\n\tPress any key to return home screen");
		}
		public void GetListWorstStudent()
		{
			var result = Students.OrderBy(student => student.CalculateAvarage()).ToList();
			foreach (Student student in Students)
			{
				if (student.CalculateAvarage() == result[0].CalculateAvarage())
				{
					student.GetInformation();
				}
			}
			Interface.SetColorG();
			Console.WriteLine("\n\tPress any key to return home screen");
		}
	}
}
