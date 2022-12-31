using System;

namespace GetFileNames
{
	class Program
	{
		static void Main(string[] args)
		{
			var outputPath = @"C:\PProjects\TestFiles\SaveFileNames\";
			var directoryPath = @"C:\PProjects\TestFiles\OutputFile\";
			SaveFileNames.Execute(directoryPath, outputPath);
		}
	}
}
