using System;
using System.Threading;

namespace StudentManagement_Ver1
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("\n\t\t© Copyright 2020 - NGUYEN HOANG LAM");
			Thread.Sleep(2500);
			Console.WriteLine("\n\t\tLastest Version on June 27th,2020" +
								"\n\t\tBuild Series: EE-1402");
			Thread.Sleep(2500);
			Console.WriteLine("\n\n\t\tLaunching [NGUYEN LAM SCHOOL Application]...");
			Thread.Sleep(3000);
			Application app = new Application();
			app.Run();
		}
	}
}