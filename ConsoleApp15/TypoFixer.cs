using System.Collections.Generic;
using System.Text.RegularExpressions;

public class TypoFixer {
	private readonly Dictionary<string, string> _typoDictionary;

	public TypoFixer() {
		_typoDictionary = TypoDictionary.GetDictionary();
	}

	public string FixTypos(string text) {
		foreach (var typo in _typoDictionary) {
			text = Regex.Replace(input: text, pattern: $@"\b{Regex.Escape(typo.Key)}\b", replacement: typo.Value, options: RegexOptions.IgnoreCase);
		}

		return text;
	}
}
