using System;
using System.IO;

class Program {
  static void Main(string[] args) {
		Console.Write("Enter the path to the directory with the text files: ");
		string directory = Console.ReadLine();

		if (Directory.Exists(directory)) {
			var processor = new FileProcessor();
			processor.ProcessFiles(directory);
			Console.WriteLine("Processing is completed!");
		} else {
			Console.WriteLine($"Error: directory '{directory}' It doesn't exist.");
		}

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}
