using System;

namespace StudentManagement_Ver1
{
	class Application
	{

		ClassRoom classRoom = new ClassRoom();
		public void Run()
		{
			int choice = 0;
			bool isValidChoice = true;
			do
			{
				Interface.MenuBoard();
				isValidChoice = int.TryParse(Console.ReadLine(), out choice);
				if (isValidChoice)
				{
					switch (choice)
					{
						case 1:
							InputStudentInfor();
							break;

						case 2:
							EditStudentInfor();
							break;

						case 3:

							break;

						case 4:
							DisplayListStudent();
							break;

						case 5:
							
							break;

						case 6:

							break;

						case 7:
							FindStudentByID();
							break;
						case 0:

							break;
					}
				}
				else
				{
					Interface.SetColorR();
					Console.WriteLine("\n\tYou have chosen invalid selection ! Please try again !");
					Console.Beep();
					Console.ReadKey();
				}
			} while (choice != 0 || isValidChoice == false);
		}
		public void InputStudentInfor()
		{
			int amount;
			string idStudent;
			string nameOfStudent;
			float physicGrade, mathGrade, englishGrade;
			Console.Clear();
			Interface.SetColorCommand();
			Console.Write("\n\tEnter amount of student :>_");
			Console.ResetColor();
			try
			{
				amount = classRoom.Students.Count + int.Parse(Console.ReadLine());
				for (int i = classRoom.Students.Count; i < amount; i++)
				{
					Student student = new Student();
					do
					{
						Console.ResetColor();
						Console.Clear();
						Console.Write("\tENTER THE STUDENT ID [" + (i + 1) + "] \n\t>_");
						idStudent = Console.ReadLine();
						Console.Write("\n\tENTER THE STUDENT NAME [" + (i + 1) + "] \n\t>_");
						nameOfStudent = Console.ReadLine();
						Console.Write("\n\tENTER THE PHYSIC GRADE [" + (i + 1) + "] \n\t>_");
						physicGrade = float.Parse(Console.ReadLine());
						Console.Write("\n\tENTER THE MATH GRADE [" + (i + 1) + "] \n\t>_");
						mathGrade = float.Parse(Console.ReadLine());
						Console.Write("\n\tENTER THE ENGLISH GRADE [" + (i + 1) + "] \n\t>_");
						englishGrade = float.Parse(Console.ReadLine());
						student.SetInformation(idStudent, nameOfStudent, physicGrade, mathGrade, englishGrade);
					} while (!IsValidationData(student));
					Interface.ConfirmSubmissionBox(student, classRoom.Students);
				}

			}
			catch (Exception e)
			{
				Interface.SetColorR();
				Console.WriteLine("\n\tOops ! Something wrong happen !" +
									"\n\n\tDetail: " + e.Message);
				Console.ReadKey();
			}
		}
		public void EditStudentInfor()
		{
			string idStudent;
			float gradeMath = 0;
			float gradePhysic = 0;
			float gradeEnglish = 0;
			Student student = new Student();
			Console.Write("\n\tENTER THE STUDENT ID\n\t>_");
			idStudent = Console.ReadLine();
			do
			{
				Console.Write("\n\tNEW ENGLISH GRADE \n\t>_");
				float.TryParse(Console.ReadLine(), out gradeEnglish);
				Console.Write("\n\tNEW MATH GRADE \n\t>_");
				float.TryParse(Console.ReadLine(), out gradeMath);
				Console.Write("\n\tNEW PHYSIC GRADE \n\t>_");
				float.TryParse(Console.ReadLine(), out gradePhysic);
				student.EditGrade(gradePhysic, gradeMath, gradeEnglish);
			} while (!IsValidationData(student));
			classRoom.EditGrade(idStudent, gradePhysic, gradeMath, gradeEnglish);
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
			classRoom.SelectStudentByID(idStudent);
			Console.ReadKey();
		}
		public void DisplayListStudent()
		{
			Console.Clear();
			Console.WriteLine("\t\tTHE GRADE TABLE OF []\n");
			classRoom.GetListStudent();
			Interface.SetColorG();
			Console.WriteLine("\n\tPress any key to return home screen");
			Console.ReadKey();
		}
		private bool IsValidationData(Student student)
		{
			return ((student.EnglishGrade >= 0 && student.EnglishGrade <= 10) &&
					(student.MathGrade >= 0 && student.MathGrade <= 10) &&
					(student.PhysicGrade >= 0 && student.PhysicGrade <= 10));
		}
	}
}
