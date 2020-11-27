using System;
using System.Diagnostics;
using System.Threading;

namespace Vanity_Lua_Executor
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Title = "Vanity Premium FiveM Lua Exec";
			Console.ForegroundColor = ConsoleColor.Blue;
			string processName = "FiveM";
			bool flag = Process.GetProcessesByName(processName).Length != 0;
			if (flag)
			{
				Console.WriteLine("Found FiveM");
				Thread.Sleep(3000);
				Console.Clear();
				Found.uigasvdsajsa();
				Console.ReadLine();
			}
			else
			{
				Console.Write("Waiting for FiveM.");
				Thread.Sleep(3000);
			}
			for (; ; )
			{
				string processName2 = "FiveM";
				bool flag2 = Process.GetProcessesByName(processName2).Length != 0;
				if (flag2)
				{
					break;
				}
				Console.Write(".");
				Thread.Sleep(1000);
			}
			Console.WriteLine("Found FiveM!");
			Thread.Sleep(3000);
			Console.Clear();
			Found.uigasvdsajsa();
			Console.ReadLine();
			Console.ReadLine();
		}
	}
}
