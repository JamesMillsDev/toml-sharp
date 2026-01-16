using System.Diagnostics;

namespace TomlSharp.Data
{
	public class TomlArray
	{
		private readonly object[] values;

		internal TomlArray(object[] values)
		{
			this.values = values;
		}

		public T Get<T>(int index)
		{
			Trace.Assert(index >= 0 && index < values.Length);

			return (T)values[index];
		}
	}
}