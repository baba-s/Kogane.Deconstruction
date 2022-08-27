using UnityEngine;

namespace Kogane
{
    public static class Color32Deconstruction
    {
        public static void Deconstruct
        (
            this Color32 self,
            out  byte    r,
            out  byte    g,
            out  byte    b
        )
        {
            r = self.r;
            g = self.g;
            b = self.b;
        }

        public static void Deconstruct
        (
            this Color32 self,
            out  byte    r,
            out  byte    g,
            out  byte    b,
            out  byte    a
        )
        {
            r = self.r;
            g = self.g;
            b = self.b;
            a = self.a;
        }
    }
}