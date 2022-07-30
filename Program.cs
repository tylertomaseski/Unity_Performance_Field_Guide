using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Unity_Performance_Field_Guide
{
	public class Program
	{
		public struct Tip
		{
			public string Title;
			public string InsteadOf;
			public string Try;
			public string Because;
			public float Difficulty;
		}

		static void PrintDummyTipXML()
		{
			XmlSerializer xmlserializer = new XmlSerializer(typeof(Tip));
			StringWriter stringWriter = new StringWriter();

			XmlWriterSettings settings = new XmlWriterSettings { OmitXmlDeclaration = true, Indent = true };

			XmlWriter writer = XmlWriter.Create(stringWriter, settings);

			var tip = new Tip() { Because = " ", Difficulty = 0.5f, InsteadOf = " ", Title = " ", Try = " " };
			xmlserializer.Serialize(writer, tip);
			Console.WriteLine(stringWriter.ToString());

		}

		static void Main(string[] args)
		{
			PrintDummyTipXML();
			var root = TryGetSolutionDirectoryInfo();
			string templateDir = Path.Combine(root.FullName, "templates");
			string tipsDir = Path.Combine(root.FullName, "tips");
			string outputDir = Path.Combine(root.FullName, "output");

			//ensure output folder exists
			if (Directory.Exists(outputDir) == false)
				Directory.CreateDirectory(outputDir);

			//get html template
			string template = File.ReadAllText(Path.Combine(templateDir, "index.html"));
			StringBuilder contentsBuilder = new StringBuilder();
			GenerateBody(ref contentsBuilder, tipsDir);

			string outputText = string.Format(template, contentsBuilder.ToString());

			File.WriteAllText(Path.Combine(outputDir, "Index.html"), outputText);
			File.Create(Path.Combine(outputDir, ".nojekyll"));
		}

		public static void GenerateBody(ref StringBuilder sb, string tipsDirectory)
		{
			var allTips = Directory.EnumerateFiles(tipsDirectory);
			foreach (var tipPath in allTips)
			{
				string tipContents = File.ReadAllText(tipPath);
				sb.Append(tipContents);
			}
		}

		public static DirectoryInfo TryGetSolutionDirectoryInfo(string currentPath = null)
		{
			var directory = new DirectoryInfo(
			currentPath ?? Directory.GetCurrentDirectory());
			while (directory != null && !directory.GetFiles("*.sln").Any())
			{
				directory = directory.Parent;
			}
			return directory;
		}

	}
}
