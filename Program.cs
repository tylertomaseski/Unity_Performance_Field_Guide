using System;
using System.IO;
using Tommy;

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

			File.WriteAllText(Path.Combine(dir, "Index.html"), "Lorem Ipsum");
			File.Create(Path.Combine(dir, ".nojekyll"));
		}
	}
}
