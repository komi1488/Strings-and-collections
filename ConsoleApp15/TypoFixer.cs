using System.Collections.Generic;

public class TypoFixer {
	private readonly Dictionary<string, string> _typoDictionary;

	public TypoFixer() {
		_typoDictionary = TypoDictionary.GetDictionary();
	}

	public string FixTypos(string text) {
		foreach (var typo in _typoDictionary) {
			text = text.Replace(typo.Key, typo.Value);
		}
		return text;
	}
}
