using System;

namespace StudentManagement_Ver1
{
	class Application
	{

		public void Run()
		{
			int choice = 0;
			bool isValidChoice = true;
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
							userAction.InputStudentInfor();
							break;

						case 2:
							userAction.EditStudentInfor();
							break;

						case 3:
							userAction.RemoveStudent();
							break;

						case 4:
							userAction.DisplayListStudent();
							break;

						case 5:
							userAction.ShowBestStudent();
							break;

						case 6:
							userAction.ShowWorstStudent();
							break;

						case 7:
							userAction.FindStudentByID();
							break;
						case 0:
							Interface.SetColorTitle();
							Console.WriteLine("\n\tSee you soon !");
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
				GC.Collect();
			} while (choice != 0 || isValidChoice == false);
		}
	}
}
