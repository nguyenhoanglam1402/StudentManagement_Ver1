using System;
using System.Collections.Generic;
using System.Text;

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
			string idStudent;
			string nameOfStudent;
			float physicGrade, mathGrade, englishGrade;
			Console.Clear();
			Interface.SetColorCommand();
			Console.Write("\n\tEnter amount of student :>_");
			Console.ResetColor();
			try
			{ 
			int amount = classRoom.Students.Count + int.Parse(Console.ReadLine());
				for (int i = classRoom.Students.Count; i < amount; i++)
				{
					Student student = new Student();
					do
					{
						Console.ResetColor();
						Console.Clear();
						Interface.SetColorCommand();
						Console.Write("\tENTER THE STUDENT ID [" + i + "]");
						Console.ResetColor();
						idStudent = Console.ReadLine();
						Interface.SetColorCommand();
						Console.Write("\n\tENTER THE STUDENT NAME [" + i + "]");
						Console.ResetColor();
						nameOfStudent = Console.ReadLine();
						Interface.SetColorCommand();
						Console.Write("n\tENTER THE PHYSIC GRADE [" + i + "]");
						Console.ResetColor();
						physicGrade = float.Parse(Console.ReadLine());
						Interface.SetColorCommand();
						Console.Write("\n\tENTER THE MATH GRADE [" + i + "]");
						Console.ResetColor();
						mathGrade = float.Parse(Console.ReadLine());
						Interface.SetColorCommand();
						Console.Write("\n\tENTER THE ENGLISH GRADE [" + i + "]");
						Console.ResetColor();
						englishGrade = float.Parse(Console.ReadLine());
						student.SetInformation(idStudent, nameOfStudent, physicGrade, mathGrade, englishGrade);
					} while (!checkValidationData(student));
					Interface.SetColorG();
					Console.Write("\n\tSubmit");
					Interface.SetColorR();
					Console.WriteLine("\t\tUnsubmit");
					Console.ResetColor();
					if (char.Parse(Console.ReadLine()) == 'Y')
					{
						classRoom.Students.Add(student);
						Interface.SetColorG();
						Console.WriteLine("\n\tSubmit successfully !");
					}
					else
					{
						student = null;
						Interface.SetColorR();
						Console.WriteLine("\n\tYour change is not submited !");
					}		
				}
				
			}
			catch(Exception e)
			{
				Console.WriteLine("You ma")
			}
		}

		private void DisplayHighestStudent()
		{

		}

		private bool checkValidationData(Student student)
		{
			return ((student.EnglishGrade >= 0 && student.EnglishGrade <= 10) ||
					(student.MathGrade >= 0 && student.MathGrade <= 10) ||
					(student.PhysicGrade >= 0 && student.PhysicGrade <= 10) ||
					(student.Id.Length <= 9));
		}
	}
}
