using System.Text.RegularExpressions;

namespace TomlSharp.Parsing
{
	internal static partial class TomlFileReader
	{
		public static Tuple<string, string>[] Read(string filename)
		{
			string content = File.ReadAllText(filename);
			return TomlRegex()
				.Matches(content)
				.Select(v => v.Value
					.Replace(" = ", "=")
					.Replace(" =", "=")
					.Replace(" =", "="))
				.Select(v =>
				{
					string[] parts = v.Split('=');
					return parts.Length == 1
						? new Tuple<string, string>(parts[0], "Map")
						: new Tuple<string, string>(parts[0], parts[1]);
				}).ToArray();
		}

		[GeneratedRegex(@"((?<=^\s*)(?!#)[^#\s]+(?:\s+[^#\s]+)*)", RegexOptions.Multiline)]
		private static partial Regex TomlRegex();
	}
}