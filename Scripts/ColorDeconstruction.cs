using UnityEngine;

namespace Kogane
{
	public static class ColorDeconstruction
	{
		public static void Deconstruct
		(
			this Color self,
			out  float r,
			out  float g,
			out  float b
		)
		{
			r = self.r;
			g = self.g;
			b = self.b;
		}

		public static void Deconstruct
		(
			this Color self,
			out  float r,
			out  float g,
			out  float b,
			out  float a
		)
		{
			r = self.r;
			g = self.g;
			b = self.b;
			a = self.a;
		}
	}
}