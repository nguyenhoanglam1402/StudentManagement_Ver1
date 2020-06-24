using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagement_Ver1
{
	class ClassRoom
	{
		public List<Student> Students= new List<Student>();
		public void GetListStudent()
		{
			SortList();
			Interface.SetColorTitle();
			Console.WriteLine("|{0,-10}|{1,-25}|{2,-15}|{3,-15}|{4,-15}|{5,-15}",
								"ID", "FULL NAME", "PHYSIC GRADE", "MATH GRADE", "ENGLISH GRADE","AVERAGE GRADE");
			Interface.SetColorTable();
			foreach (Student student in Students)
			{
				student.GetInformation();
			}
			Console.ResetColor();
			Console.WriteLine("\n\tPress any key to return home screen");
			Console.ReadKey();
		}
		private void SortList()
		{
			Student student = new Student();
			Students.Sort();
			Students.Reverse();
		}
	}
}
