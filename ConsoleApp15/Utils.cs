using System;
using System.IO;

public static class Utils {
	public static bool ValidateDirectory(string directoryPath) {
		if (!Directory.Exists(directoryPath)) {
			Console.WriteLine($"Error: directory '{directoryPath}' does not exist.");
			return false;
		}
		return true;
	}

	public static string[] GetTextFiles(string directoryPath) {
		return Directory.GetFiles(directoryPath, "*.txt");
	}
}
