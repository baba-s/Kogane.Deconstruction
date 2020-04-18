using UnityEngine;

namespace UniDeconstruction
{
	public static class Vector2IntDeconstruction
	{
		public static void Deconstruct
		(
			this Vector2Int self,
			out  int        x,
			out  int        y
		)
		{
			x = self.x;
			y = self.y;
		}
	}
}