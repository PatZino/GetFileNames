using System.IO;
using System.Text;

namespace GetFileNames
{
	public class SaveFileNames
	{
		//https://www.csharp-examples.net/get-files-from-directory/
		public static void Execute(string directoryPath, string outputPath)
		{
			var newFile = new StringBuilder();
			var fullPath = new StringBuilder();
			var fileName = string.Empty;
			var filePaths = Directory.GetFiles(directoryPath);

			foreach(var file in filePaths)
			{
				var splitFilePath = file.Split('\\');
				fileName = splitFilePath[splitFilePath.Length - 1];
				newFile.AppendLine(fileName);
				fullPath.AppendLine(file);
			}

			File.WriteAllText(outputPath + "FileNames.txt", newFile.ToString());
			File.WriteAllText(outputPath + "FileNamesFullPath.txt", fullPath.ToString());
		}
	}
}
