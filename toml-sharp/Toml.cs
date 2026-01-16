using TomlSharp.Parsing;

namespace TomlSharp
{
	public class Toml
	{
		public string FileName { get; }

		public Toml(string fileName, bool autoLoad = false)
		{
			this.FileName = fileName;

			if (autoLoad)
			{
				Load();
			}
		}

		public void Load()
		{
			Tuple<string, string>[] lines = TomlFileReader.Read(this.FileName);

			foreach ((string name, string value) in lines)
			{
				Console.WriteLine($"Name = {name} - Value = {value}");
			}
		}
	}
}