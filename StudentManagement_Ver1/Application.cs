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
					} while (!checkValidationData(student));
					Interface.ConfirmSubmissionBox(student, classRoom.Students);
				}

			}
			catch (Exception e)
			{
				Interface.SetColorR();
				Console.WriteLine("\tOops ! Something wrong happen !" +
									"\n\n\tDetail: " + e.Message);
				Console.ReadKey();
			}
		}
		public void DisplayListStudent()
		{
			classRoom.GetListStudent();
		}
		private bool checkValidationData(Student student)
		{
			return ((student.EnglishGrade >= 0 && student.EnglishGrade <= 10) &&
					(student.MathGrade >= 0 && student.MathGrade <= 10) &&
					(student.PhysicGrade >= 0 && student.PhysicGrade <= 10) &&
					(student.Id.Length <= 9));
		}
	}
}
