namespace TomlSharp.Data
{
	public class TomlValue
	{
		private readonly object value;

		internal TomlValue(object value)
		{
			this.value = value;
		}

		public T Get<T>()
		{
			return (T)this.value;
		}
	}
}