using System.Collections.Generic;

public static class KeyValuePairDeconstruction
{
	public static void Deconstruct<TKey, TValue>
	(
		this KeyValuePair<TKey, TValue> self,
		out  TKey                       key,
		out  TValue                     value
	)
	{
		key   = self.Key;
		value = self.Value;
	}
}