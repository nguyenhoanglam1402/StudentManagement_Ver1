using System;

namespace StudentManagement_Ver1
{
	class Application
	{

		public void Run()
		{
			int choice;
			bool isValidChoice;
			UserAction userAction = new UserAction();
			do
			{
				Interface.MenuBoard();
				isValidChoice = int.TryParse(Console.ReadLine(), out choice);
				if (isValidChoice)
				{
					switch (choice)
					{
						case 1:
							userAction.InputListStudent();
							break;

						case 2:
							userAction.InputEditStudentInfor();
							break;

						case 3:
							userAction.InputRemovingStudentID();
							break;

						case 4:
							userAction.DisplayAllStudents();
							break;

						case 5:
							userAction.ShowStudentsWithHighestGrade();
							break;

						case 6:
							userAction.ShowStudentWithLowestMark();
							break;

						case 7:
							userAction.FindStudentByID();
							break;
					}
				}
				else
				{
					Interface.SetColorRed();
					Console.WriteLine("\n\tYou have chosen invalid selection ! Please try again !");
					Console.Beep();
					Console.ReadKey();
				}
				GC.Collect();
			} while (choice > 0 || isValidChoice == false);
			userAction = null;
			Console.Clear();
			Interface.SetColorCommand();
			Console.WriteLine("\n\t\tSEE YOU SOON !");
			Console.ResetColor();
		}
	}
}
