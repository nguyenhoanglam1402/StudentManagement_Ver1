using System;

namespace StudentManagement_Ver1
{
	class Interface
	{
		public static void MenuBoard()
		{
			Console.ResetColor();
			Console.Clear();
			SetColorTitle();
			Console.WriteLine("\t\t|     [NGUYEN LAM HIGH SCHOOL SYSTEMS]     |");
			Console.WriteLine("\t\t|__________________________________________|");
			SetColorTable();
			Console.WriteLine("\t\t|  [1] Add more student with their grade   |");
			Console.WriteLine("\t\t|  [2] Edit student grade by their ID      |");
			Console.WriteLine("\t\t|  [3] Remove student by their ID          |");
			Console.WriteLine("\t\t|  [4] Show all of student grade in class  |");
			Console.WriteLine("\t\t|  [5] Find the best student in class      |");
			Console.WriteLine("\t\t|  [6] Find the worst student in class     |");
			Console.WriteLine("\t\t|  [7] Find the a student in class         |");
			Console.WriteLine("\t\t|  [0] Exit the application                |");
			Console.WriteLine("\t\t|________________.*.<~>.*._________________|");
			SetColorCommand();
			Console.Write("\n\t\t[Your choice]");
			Console.Beep();
			Console.ResetColor();
		}

		public static bool ConfirmSubmissionBox()
		{
			SetColorGreen();
			Console.Write("\n\tSubmit [Y]");
			SetColorRed();
			Console.WriteLine("\t\tUnsubmit [Any key]");
			Console.ResetColor();
			Console.Write("\n\t>_");
			if (char.Parse(Console.ReadLine()) == 'Y')
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public static void HeaderOfListTable()
		{
			SetColorTitle();
			Console.WriteLine("\n\t|{0,-10}|{1,-25}|{2,-15}|{3,-15}|{4,-15}|{5,-15}|",
								"ID", "FULL NAME", "PHYSIC GRADE", "MATH GRADE", "ENGLISH GRADE", "AVERAGE GRADE");
			SetColorTable();
		}
		public static void ShowSuccessMessage()
		{
			SetColorGreen();
			Console.WriteLine("\n\tSubmit successfully !");
			Console.ResetColor();
			Console.ReadKey();
		}
		public static void ShowUnsuccessMessage()
		{
			SetColorRed();
			Console.WriteLine("\n\tYour change is not submited !");
			Console.ResetColor();
			Console.ReadKey();
		}
		public static void ShowRequestMessage()
		{
			SetColorGreen();
			Console.WriteLine("\n\tPress any key to return home screen");
		}

		/* What is the Makeup Methods
		 * They are a group of method which make the interface be more beautiful
		 * SetColorTitle() is used to set the color for tile and table header
		 * SetColorTable() is used to set the color for table rows
		 * SetColorGreen() is used to set the color for success message or notification
		 * SetColorRed() is used to set the color for error message or unsuccess message
		 * SetColorCommand() is used to set the color for requirement of system
		 */

		#region[Makeup Method]

		public static void SetColorTitle()
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Black;
		}

		public static void SetColorGreen()
		{
			Console.BackgroundColor = ConsoleColor.DarkGreen;
			Console.ForegroundColor = ConsoleColor.White;
		}

		public static void SetColorTable()
		{
			Console.BackgroundColor = ConsoleColor.Cyan;
			Console.ForegroundColor = ConsoleColor.Black;
		}

		public static void SetColorCommand()
		{
			Console.BackgroundColor = ConsoleColor.DarkCyan;
			Console.ForegroundColor = ConsoleColor.White;
		}

		public static void SetColorRed()
		{
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.ForegroundColor = ConsoleColor.DarkYellow;
		}

		#endregion
	}
}
