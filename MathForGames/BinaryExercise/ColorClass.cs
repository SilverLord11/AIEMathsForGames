using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryExercise
{
    class ColorClass
    {
        public UInt32 colour;

        byte red = 255;

        public void SetRed(byte red)
        {
            colour = colour & 0x00ffffff;
            colour |= (UInt32)red << 24;
        }

        public byte GetRed()
        {
            return (byte)((colour & 0xff000000) >> 24);
            UInt32 value = colour & 0xff000000;
        }
    }
}
