using TomlSharp;

namespace Pong
{
	public static class Program
	{
		private static void Main(string[] args)
		{
			Toml toml = new Toml(Path.Combine(Environment.CurrentDirectory, "test.toml"), true);
		}
    }
}