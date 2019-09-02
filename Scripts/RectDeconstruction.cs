using UnityEngine;

public static class RectDeconstruction
{
	public static void Deconstruct
	(
		this Rect    self,
		out  Vector2 position,
		out  Vector2 size
	)
	{
		position = self.position;
		size     = self.size;
	}

	public static void Deconstruct
	(
		this Rect  self,
		out  float x,
		out  float y,
		out  float width,
		out  float height
	)
	{
		x      = self.x;
		y      = self.y;
		width  = self.width;
		height = self.height;
	}
}