using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace Vanity_Lua_Executor
{
	internal class Found
	{
		[DllImport("User32.dll", CharSet = CharSet.Unicode)]
		public static extern int MessageBox(IntPtr h, string m, string c, int type);

		public static void uigasvdsajsa()
		{
			string path = "C:\\\\VanityPremium";
			bool flag = Directory.Exists(path);
			if (!flag)
			{
				Directory.CreateDirectory("C:\\VanityPremium");
			}
			bool flag2 = File.Exists("C:\\VanityPremium\\Enjoy.lua");
			if (!flag2)
			{
				File.Create("C:\\VanityPremium\\Enjoy.lua");
			}
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine("Put your code in C:\\VanityPremium\\Enjoy.lua");
			Console.Write("Type Inject and press enter to inject");
			Console.WriteLine(" WARNING YOU'RE GAME WILL CRASH DO NOT EXECUTE YET!!");
			Console.WriteLine("");
			for (; ; )
			{
				string a = Console.ReadLine();
				bool flag3 = a == "Inject";
				if (flag3)
				{
					Found.Execute();
				}
				bool flag4 = a == "inject";
				if (flag4)
				{
					Found.Execute();
				}
			}
		}

		public static void Execute()
		{
			using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\FiveM\\FiveM.app\\citizen\\scripting\\lua\\Sheduler.lua", true))
			{
				streamWriter.WriteLine("");
			}
			Found.VanityPremium();
			Console.ReadLine();
		}

		public static void VanityPremium()
		{
			using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\FiveM\\FiveM.app\\citizen\\scripting\\lua\\Sheduler.lua", true))
			{
				streamWriter.WriteLine("if GetCurrentResourceName() == \"spawnmanager\" then");
			}
			Found.VanityPremium2();
			Console.ReadLine();
		}

		public static void VanityPremium2()
		{
			string text = "C:\\VanityPremium\\Enjoy.lua";
			StreamReader streamReader = new StreamReader(text);
			FileInfo fileInfo = new FileInfo(text);
			StreamReader streamReader2 = fileInfo.OpenText();
			string value;
			while ((value = streamReader2.ReadLine()) != null)
			{
				using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\FiveM\\FiveM.app\\citizen\\scripting\\lua\\Sheduler.lua", true))
				{
					streamWriter.WriteLine(value);
				}
			}
			Found.VanityPremium3();
			Console.ReadLine();
		}

		public static void VanityPremium3()
		{
			using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\FiveM\\FiveM.app\\citizen\\scripting\\lua\\Sheduler.lua", true))
			{
				streamWriter.WriteLine("end");
			}
			Found.VanityPremium4();
			Console.ReadLine();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022A8 File Offset: 0x000004A8
		public static void VanityPremium4()
		{
			using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\FiveM\\FiveM.app\\citizen\\scripting\\lua\\Sheduler.lua", true))
			{
				streamWriter.WriteLine("");
			}
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("Injected!");
			Thread.Sleep(5000);
		}
	}
}
