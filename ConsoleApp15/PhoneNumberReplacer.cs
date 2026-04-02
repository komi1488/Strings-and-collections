using System.Text.RegularExpressions;

public class PhoneNumberReplacer {
	public string ReplacePhoneNumbers(string text) {
		string phonePattern = @"\(0(\d{2})\)\s(\d{3})-(\d{2})-(\d{2})";
		string replacement = "+380 $1 $2 $3 $4";
		return Regex.Replace(text, phonePattern, replacement);
	}
}
