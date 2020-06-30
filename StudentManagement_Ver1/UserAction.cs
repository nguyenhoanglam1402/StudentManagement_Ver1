using System;

namespace StudentManagement_Ver1
{
	internal class UserAction
	{
		private ClassRoom classRoom = new ClassRoom();

		private static string InputIdStudent(int index)
		{
			Console.Clear();
			Console.Write("\tENTER THE STUDENT ID [" + (index + 1) + "] \n\t>_");
			return (Console.ReadLine());
		}

		private static string InputStudentName(int index)
		{
			Console.Write("\n\tENTER THE STUDENT NAME [" + (index + 1) + "] \n\t>_");
			return (Console.ReadLine());
		}

		private static float InputStudentPhysicGrade(int index)
		{
			Console.Write("\n\tENTER THE MATH GRADE [" + (index + 1) + "] \n\t>_");
			return (float.Parse(Console.ReadLine()));
		}

		private static float InputStudentMathGrade(int index)
		{
			Console.Write("\n\tENTER THE PHYSIC GRADE [" + (index + 1) + "] \n\t>_");
			return (float.Parse(Console.ReadLine()));
		}

		private static float InputStudentEnglishGrade(int index)
		{
			Console.Write("\n\tENTER THE ENGLISH GRADE [" + (index + 1) + "] \n\t>_");
			return (float.Parse(Console.ReadLine()));
		}

		private static Student CreateNewStudentInfor(int index)
		{
			Student student = new Student(InputIdStudent(index), InputStudentName(index), InputStudentPhysicGrade(index),
													InputStudentMathGrade(index), InputStudentEnglishGrade(index));
			return student;
		}

		public void ShowStudentWithLowestMark()
		{
			Console.Clear();
			Interface.HeaderOfListTable();
			classRoom.PrintStudentsWithLowestGrade();
			Console.ReadKey();
		}

		public void ShowStudentsWithHighestGrade()
		{
			Console.Clear();
			Interface.HeaderOfListTable();
			classRoom.PrintStudentsWithHighestGrade();
			Console.ReadKey();
		}

		public void InputListStudent()
		{
			int amount;
			bool isValid;
			Console.Write("\n\t\tEnter amount of student :>_");
			Console.ResetColor();
			try
			{
				amount = classRoom.Students.Count + int.Parse(Console.ReadLine());
				for (int i = classRoom.Students.Count; i < amount; i++)
				{
					Student student = new Student();
					do
					{
						student = CreateNewStudentInfor(i);
						isValid = IsValidationData(student);
					} while (isValid == false);
					if (Interface.ConfirmSubmissionBox())
					{
						classRoom.Students.Add(student);
						Interface.ShowSuccessMessage();
					}
					else
					{
						student = null;
						Interface.ShowUnsuccessMessage();
					}
				}
			}
			catch (Exception e)
			{
				Interface.SetColorRed();
				Console.WriteLine("\n\tOops ! Something wrong happen !" +
									"\n\n\tDetail: " + e.Message);
				Console.ReadKey();
			}
		}

		public void InputEditStudentInfor()
		{
			string idStudent;
			float gradeMath;
			float gradePhysic;
			float gradeEnglish;
			Student student = new Student();
			Console.Write("\n\tENTER THE STUDENT ID\n\t>_");
			idStudent = Console.ReadLine();
			do
			{
				Console.Clear();
				Interface.SetColorTitle();
				Console.WriteLine("\n\tEDITING STUDENT [" + idStudent + "]");
				Console.ResetColor();
				Console.Write("\n\tNEW ENGLISH GRADE \n\t>_");
				float.TryParse(Console.ReadLine(), out gradeEnglish);
				Console.Write("\n\tNEW MATH GRADE \n\t>_");
				float.TryParse(Console.ReadLine(), out gradeMath);
				Console.Write("\n\tNEW PHYSIC GRADE \n\t>_");
				float.TryParse(Console.ReadLine(), out gradePhysic);
				student.EditGrade(gradePhysic, gradeMath, gradeEnglish);
			} while (!IsValidationData(student));
			classRoom.EditGradeByID(idStudent, gradePhysic, gradeMath, gradeEnglish);
			Console.ReadKey();
		}

		public void InputRemovingStudentID()
		{
			string id;
			Console.Write("\n\tENTER STUDENT ID\n\t>_");
			id = Console.ReadLine();
			classRoom.RemoveStudentByID(id);
			Console.ReadKey();
		}

		public void FindStudentByID()
		{
			string idStudent;
			Console.Clear();
			Console.WriteLine("\tENTER THE FINDING STUDENT ID");
			Console.Write("\t>_");
			idStudent = Console.ReadLine();
			idStudent.TrimEnd('\n');
			classRoom.GetStudentByID(idStudent);
			Console.ReadKey();
		}

		public void DisplayAllStudents()
		{
			Console.Clear();
			classRoom.PrintAllStudents();
			Interface.SetColorGreen();
			Console.WriteLine("\n\tPress any key to return home screen");
			Console.ReadKey();
		}

		private static bool IsValidationData(Student student)
		{
			return ((student.EnglishGrade >= 0 && student.EnglishGrade <= 10) &&
					(student.MathGrade >= 0 && student.MathGrade <= 10) &&
					(student.PhysicGrade >= 0 && student.PhysicGrade <= 10));
		}
	}
}