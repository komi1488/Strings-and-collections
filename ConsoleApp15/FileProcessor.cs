using System;
using System.IO;
using System.Text;

public class FileProcessor {
	private readonly TypoFixer _typoFixer = new TypoFixer();
	private readonly PhoneNumberReplacer _phoneReplacer = new PhoneNumberReplacer();

	public void ProcessFiles(string directoryPath) {
		string[] textFiles = Directory.GetFiles(directoryPath, "*.txt");

		if (textFiles.Length == 0) {
			Console.WriteLine("No text files (.txt) were found in the specified directory.");
			return;
		}

		foreach (string filePath in textFiles) {
			try {
				string content = File.ReadAllText(filePath, Encoding.UTF8);
				content = _typoFixer.FixTypos(content);
				content = _phoneReplacer.ReplacePhoneNumbers(content);

				File.WriteAllText(filePath, content, Encoding.UTF8);
				Console.WriteLine($"The file has been processed: {filePath}");
			} catch (Exception ex) {
				Console.WriteLine($"File processing error {filePath}: {ex.Message}");
			}
		}
	}
}
