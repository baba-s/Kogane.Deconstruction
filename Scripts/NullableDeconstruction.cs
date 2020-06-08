namespace Kogane
{
	public static class NullableDeconstruction
	{
		public static void Deconstruct<T>
		(
			this T?   self,
			out  bool hasValue,
			out  T    value
		) where T : struct
		{
			hasValue = self.HasValue;
			value    = self ?? default;
		}
	}
}