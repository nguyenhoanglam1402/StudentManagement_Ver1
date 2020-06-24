﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace StudentManagement_Ver1
{
	class Student
	{
		public string Id;
		public string NameOfStudent;
		public string IdClass;
		public float PhysicGrade;
		public float MathGrade;
		public float EnglishGrade;
		public Student()
		{
			Id = "N/A";
			NameOfStudent = "N/A";
			IdClass = "N/A";
			PhysicGrade = 0;
			MathGrade = 0;
			EnglishGrade = 0;
		}
		public void SetInformation(string id, string nameOfStudent, float physicGrade,
													float mathGrade, float englishGrade)
		{
			Id = id;
			NameOfStudent = nameOfStudent;
			PhysicGrade = physicGrade;
			MathGrade = mathGrade;
			EnglishGrade = englishGrade;
		}
		public void EditGrade(float physicGrade, float mathGrade, float englishGrade)
		{
			PhysicGrade = physicGrade;
			MathGrade = mathGrade;
			EnglishGrade = englishGrade;
		}
		public void GetInformation()
		{
			Console.WriteLine("|{0,-10}|{1,-25}|{2,-15}|{3,-15}|{4,-15}|{5,-15}",
				Id, NameOfStudent, PhysicGrade, MathGrade, EnglishGrade, CalculateAvarage());
		}
		public double CalculateAvarage()
		{
			return (Math.Round(((PhysicGrade + MathGrade + EnglishGrade) / 3), 1));
		}
	}
}
