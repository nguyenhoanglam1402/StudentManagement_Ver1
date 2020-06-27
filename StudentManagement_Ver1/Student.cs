using System;

namespace StudentManagement_Ver1
{
	class Student
	{
		public string Id;
		public string NameOfStudent;
		public float PhysicGrade;
		public float MathGrade;
		public float EnglishGrade;
		public Student(string id, string nameOfStudent, float physicGrade,
										float mathGrade, float englishGrade)
		{
			Id = id;
			NameOfStudent = nameOfStudent;
			PhysicGrade = physicGrade;
			MathGrade = mathGrade;
			EnglishGrade = englishGrade;
		}
		public Student()
		{

		}
		public void EditGrade(float physicGrade, float mathGrade, float englishGrade)
		{
			PhysicGrade = physicGrade;
			MathGrade = mathGrade;
			EnglishGrade = englishGrade;
		}
		public void PrintInformation()
		{
			Console.WriteLine("\t|{0,-10}|{1,-25}|{2,-15}|{3,-15}|{4,-15}|{5,-15}|",
				Id, NameOfStudent, PhysicGrade, MathGrade, EnglishGrade, CalculateAvarage());
		}
		public double CalculateAvarage()
		{
			double result = (Math.Round(((PhysicGrade + MathGrade + EnglishGrade) / 3), 1));
			return result;
		}
	}
}
