﻿using System;

namespace StudentManagement_Ver1
{
	class Interface
	{
		public static void MenuBoard()
		{
			Console.ResetColor();
			Console.Clear();
			SetColorTitle();
			Console.WriteLine("\t|     [NGUYEN LAM HIGH SCHOOL SYSTEMS]     |");
			Console.WriteLine("\t|__________________________________________|");
			SetColorTable();
			Console.WriteLine("\t|  [1] Add more student with their grade   |");
			Console.WriteLine("\t|  [2] Edit student grade by their ID      |");
			Console.WriteLine("\t|  [3] Remove student by their ID          |");
			Console.WriteLine("\t|  [4] Show all of student grade in class  |");
			Console.WriteLine("\t|  [5] Find the best student in class      |");
			Console.WriteLine("\t|  [6] Find the worst student in class     |");
			Console.WriteLine("\t|  [7] Find the a student in class         |");
			Console.WriteLine("\t|  [0] Exit the application                |");
			Console.WriteLine("\t|__________________________________________|");
			SetColorCommand();
			Console.Write("\n\t[Your choice]");
			Console.Beep();
			Console.ResetColor();
		}
		/* What is the Makeup Method
		 * They are a group of method which make the interface be more beautiful
		 * SetColorTitle() is used to set the color for tile and table header
		 * SetColorTable() is used to set the color for table rows
		 * SetColorG() is used to set the color for success message or notification
		 * SetColorR() is used to set the color for error message or unsuccess message
		 * SetColorCommand() is used to set the color for requirement of system
		 */
		#region[Makeup Method]

		public static void SetColorTitle()
		{
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Black;
		}

		public static void SetColorG()
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

		public static void SetColorR()
		{
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.ForegroundColor = ConsoleColor.DarkYellow;
		}

		#endregion
	}
}
