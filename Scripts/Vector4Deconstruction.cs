using UnityEngine;

namespace Kogane
{
	public static class Vector4Deconstruction
	{
		public static void Deconstruct
		(
			this Vector4 self,
			out  float   x,
			out  float   y
		)
		{
			x = self.x;
			y = self.y;
		}

		public static void Deconstruct
		(
			this Vector4 self,
			out  float   x,
			out  float   y,
			out  float   z
		)
		{
			x = self.x;
			y = self.y;
			z = self.z;
		}

		public static void Deconstruct
		(
			this Vector4 self,
			out  float   x,
			out  float   y,
			out  float   z,
			out  float   w
		)
		{
			x = self.x;
			y = self.y;
			z = self.z;
			w = self.w;
		}
	}
}