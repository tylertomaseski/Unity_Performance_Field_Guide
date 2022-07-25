using System;
using System.IO;

namespace Unity_Performance_Field_Guide
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			string dir = Path.Combine(Environment.CurrentDirectory, "output");

			if (Directory.Exists(dir) == false)
				Directory.CreateDirectory(dir);

			System.IO.File.WriteAllText(Path.Combine(dir, "Index.html"), "Lorem Ipsum");
		}
	}
}
