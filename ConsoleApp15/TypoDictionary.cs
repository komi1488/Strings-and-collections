using System.Collections.Generic;

public static class TypoDictionary {
  public static Dictionary<string, string> GetDictionary() {
    return new Dictionary<string, string> {
	  { "првиет", "привет" },
	  { "пирвет", "привет" },
	  { "здарова", "здравствуй" },
	  { "покаа", "пока" },
	  { "спс", "спасибо" },
	  { "окей", "ок" },
	  { "норм", "нормально" },
	  { "щас", "сейчас" },
	  { "грит", "говорит" }};
  }
}
