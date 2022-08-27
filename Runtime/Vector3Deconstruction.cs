using UnityEngine;

namespace Kogane
{
    public static class Vector3Deconstruction
    {
        public static void Deconstruct
        (
            this Vector3 self,
            out  float   x,
            out  float   y
        )
        {
            x = self.x;
            y = self.y;
        }

        public static void Deconstruct
        (
            this Vector3 self,
            out  float   x,
            out  float   y,
            out  float   z
        )
        {
            x = self.x;
            y = self.y;
            z = self.z;
        }
    }
}