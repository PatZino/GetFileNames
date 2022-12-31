using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFileNames
{
	public class SaveFileNames
	{
		//https://www.csharp-examples.net/get-files-from-directory/
		public static void Execute(string directoryPath, string outputPath)
		{
			var newFile = new StringBuilder();
			var fileName = string.Empty;
			var filePaths = Directory.GetFiles(directoryPath);

			foreach(var file in filePaths)
			{
				var splitFilePath = file.Split('\\');
				fileName = splitFilePath[splitFilePath.Length - 1];
				newFile.AppendLine(fileName);
			}

			File.WriteAllText(outputPath, newFile.ToString());
		}

	}
}
