using System;
using System.Linq;

namespace Boilers.Util
{
    public  class ByteUtil
    {
        public static int bytesToInt(params byte[] bytes)
        {
            return BitConverter.ToInt32(bytes, 0);
        }

        public static float bytesToFloat(params byte[] bytes)
        {
            return BitConverter.ToSingle(bytes, 0);
        }
    }
}
