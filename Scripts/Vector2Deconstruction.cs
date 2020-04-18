using UnityEngine;

namespace UniDeconstruction
{
	public static class Vector2Deconstruction
	{
		public static void Deconstruct
		(
			this Vector2 self,
			out  float   x,
			out  float   y
		)
		{
			x = self.x;
			y = self.y;
		}
	}
}