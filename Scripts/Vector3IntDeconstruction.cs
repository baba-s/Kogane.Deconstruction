using UnityEngine;

namespace Kogane
{
	public static class Vector3IntDeconstruction
	{
		public static void Deconstruct
		(
			this Vector3Int self,
			out  int        x,
			out  int        y,
			out  int        z
		)
		{
			x = self.x;
			y = self.y;
			z = self.z;
		}
	}
}